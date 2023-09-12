using Cdk.Core;
using Azure.Core;
using Azure.ResourceManager.KeyVault;
using Azure.ResourceManager.KeyVault.Models;

namespace Cdk.KeyVault
{
    public class KeyVault : Resource<KeyVaultData>
    {
        public override string Name { get; } = $"kv{Infrastructure.Seed}";

        public KeyVault(Resource scope, string name, string version = "2023-02-01", AzureLocation? location = default, Guid? accessPrincipal = default)
            : base(scope, version, ArmKeyVaultModelFactory.KeyVaultData(
                name: name is null ? $"kv-{Infrastructure.Seed}" : $"{name}-{Infrastructure.Seed}",
                resourceType: "Microsoft.KeyVault/vaults",
                location: location ?? AzureLocation.WestUS,
                properties: ArmKeyVaultModelFactory.KeyVaultProperties(
                sku: new KeyVaultSku(KeyVaultSkuFamily.A, KeyVaultSkuName.Standard),
                accessPolicies: accessPrincipal.HasValue ? new List<KeyVaultAccessPolicy>()
                {
                    new KeyVaultAccessPolicy(Guid.Empty, accessPrincipal.Value.ToString(), new IdentityAccessPermissions()
                    {
                        Secrets =
                        {
                            IdentityAccessSecretPermission.Get,
                            IdentityAccessSecretPermission.List
                        }
                    })
                } : default)))
        {
        }

        public void ParameterizeAccessPolicyObjectId(string instance, Parameter parameter)
        {
            ParameterOverrides.Add("objectId", parameter.Name);
            Parameters.Add(parameter);
        }
    }
}
