using Cdk.Core;
using Cdk.KeyVault;
using Cdk.ResourceManager;
using Cdk.Sql;
using Azure.Core;

namespace Hello.Cdk
{
    public class HelloCdkInfrastructure : Infrastructure
    {
        public HelloCdkInfrastructure(AzureLocation? location = default)
        {
            location ??= AzureLocation.WestUS;

            Parameter sqlAdminPasswordParam = new Parameter("sqlAdminPassword", "SQL Server administrator password", isSecure: true);
            Parameters.Add(sqlAdminPasswordParam);

            Parameter appUserPasswordParam = new Parameter("appUserPassword", "Application user password", isSecure: true);
            Parameters.Add(appUserPasswordParam);

            ResourceGroup resourceGroup = new ResourceGroup(Resource.SubscriptionScope, location: location);
            resourceGroup.Properties.Tags.Add("key", "value");
            Resources.Add(resourceGroup);

            KeyVault keyVault = new KeyVault(resourceGroup, "hello-adk-kevault", location: location, accessPrincipal: Guid.NewGuid());
            keyVault.AddOutput("endpoint", nameof(keyVault.Properties.Properties.VaultUri));

            KeyVaultSecret sqlAdminSecret = new KeyVaultSecret(keyVault, "sqlAdminPassword");
            sqlAdminSecret.AssignParameter(nameof(sqlAdminSecret.Properties.Properties.Value), sqlAdminPasswordParam);

            KeyVaultSecret appUserSecret = new KeyVaultSecret(keyVault, "appUserPassword");
            appUserSecret.AssignParameter(nameof(appUserSecret.Properties.Properties.Value), appUserPasswordParam);

            SqlServer sqlServer = new SqlServer(resourceGroup, "hello-adk-sqlserver", location: location);
            sqlServer.AssignParameter(nameof(sqlServer.Properties.AdministratorLoginPassword), sqlAdminPasswordParam);
        }
    }
}
