class ABB {
    private const string content = """
{
    "analysisServicesServers": "as",
    "apiManagementService": "apim-",
    "appConfigurationConfigurationStores": "appcs-",
    "appManagedEnvironments": "cae-",
    "appContainerApps": "ca-",
    "authorizationPolicyDefinitions": "policy-",
    "automationAutomationAccounts": "aa-",
    "blueprintBlueprints": "bp-",
    "blueprintBlueprintsArtifacts": "bpa-",
    "cacheRedis": "redis-",
    "cdnProfiles": "cdnp-",
    "cdnProfilesEndpoints": "cdne-",
    "cognitiveServicesAccounts": "cog-",
    "cognitiveServicesFormRecognizer": "cog-fr-",
    "cognitiveServicesTextAnalytics": "cog-ta-",
    "computeAvailabilitySets": "avail-",
    "computeCloudServices": "cld-",
    "computeDiskEncryptionSets": "des",
    "computeDisks": "disk",
    "computeDisksOs": "osdisk",
    "computeGalleries": "gal",
    "computeSnapshots": "snap-",
    "computeVirtualMachines": "vm",
    "computeVirtualMachineScaleSets": "vmss-",
    "containerInstanceContainerGroups": "ci",
    "containerRegistryRegistries": "cr",
    "containerServiceManagedClusters": "aks-",
    "databricksWorkspaces": "dbw-",
    "dataFactoryFactories": "adf-",
    "dataLakeAnalyticsAccounts": "dla",
    "dataLakeStoreAccounts": "dls",
    "dataMigrationServices": "dms-",
    "dBforMySQLServers": "mysql-",
    "dBforPostgreSQLServers": "psql-",
    "devicesIotHubs": "iot-",
    "devicesProvisioningServices": "provs-",
    "devicesProvisioningServicesCertificates": "pcert-",
    "documentDBDatabaseAccounts": "cosmos-",
    "eventGridDomains": "evgd-",
    "eventGridDomainsTopics": "evgt-",
    "eventGridEventSubscriptions": "evgs-",
    "eventHubNamespaces": "evhns-",
    "eventHubNamespacesEventHubs": "evh-",
    "hdInsightClustersHadoop": "hadoop-",
    "hdInsightClustersHbase": "hbase-",
    "hdInsightClustersKafka": "kafka-",
    "hdInsightClustersMl": "mls-",
    "hdInsightClustersSpark": "spark-",
    "hdInsightClustersStorm": "storm-",
    "hybridComputeMachines": "arcs-",
    "insightsActionGroups": "ag-",
    "insightsComponents": "appi-",
    "keyVaultVaults": "kv-",
    "kubernetesConnectedClusters": "arck",
    "kustoClusters": "dec",
    "kustoClustersDatabases": "dedb",
    "loadTesting": "lt-",
    "logicIntegrationAccounts": "ia-",
    "logicWorkflows": "logic-",
    "machineLearningServicesWorkspaces": "mlw-",
    "managedIdentityUserAssignedIdentities": "id-",
    "managementManagementGroups": "mg-",
    "migrateAssessmentProjects": "migr-",
    "networkApplicationGateways": "agw-",
    "networkApplicationSecurityGroups": "asg-",
    "networkAzureFirewalls": "afw-",
    "networkBastionHosts": "bas-",
    "networkConnections": "con-",
    "networkDnsZones": "dnsz-",
    "networkExpressRouteCircuits": "erc-",
    "networkFirewallPolicies": "afwp-",
    "networkFirewallPoliciesWebApplication": "waf",
    "networkFirewallPoliciesRuleGroups": "wafrg",
    "networkFrontDoors": "fd-",
    "networkFrontdoorWebApplicationFirewallPolicies": "fdfp-",
    "networkLoadBalancersExternal": "lbe-",
    "networkLoadBalancersInternal": "lbi-",
    "networkLoadBalancersInboundNatRules": "rule-",
    "networkLocalNetworkGateways": "lgw-",
    "networkNatGateways": "ng-",
    "networkNetworkInterfaces": "nic-",
    "networkNetworkSecurityGroups": "nsg-",
    "networkNetworkSecurityGroupsSecurityRules": "nsgsr-",
    "networkNetworkWatchers": "nw-",
    "networkPrivateDnsZones": "pdnsz-",
    "networkPrivateLinkServices": "pl-",
    "networkPublicIPAddresses": "pip-",
    "networkPublicIPPrefixes": "ippre-",
    "networkRouteFilters": "rf-",
    "networkRouteTables": "rt-",
    "networkRouteTablesRoutes": "udr-",
    "networkTrafficManagerProfiles": "traf-",
    "networkVirtualNetworkGateways": "vgw-",
    "networkVirtualNetworks": "vnet-",
    "networkVirtualNetworksSubnets": "snet-",
    "networkVirtualNetworksVirtualNetworkPeerings": "peer-",
    "networkVirtualWans": "vwan-",
    "networkVpnGateways": "vpng-",
    "networkVpnGatewaysVpnConnections": "vcn-",
    "networkVpnGatewaysVpnSites": "vst-",
    "notificationHubsNamespaces": "ntfns-",
    "notificationHubsNamespacesNotificationHubs": "ntf-",
    "operationalInsightsWorkspaces": "log-",
    "portalDashboards": "dash-",
    "powerBIDedicatedCapacities": "pbi-",
    "purviewAccounts": "pview-",
    "recoveryServicesVaults": "rsv-",
    "resourcesResourceGroups": "rg-",
    "searchSearchServices": "srch-",
    "serviceBusNamespaces": "sb-",
    "serviceBusNamespacesQueues": "sbq-",
    "serviceBusNamespacesTopics": "sbt-",
    "serviceEndPointPolicies": "se-",
    "serviceFabricClusters": "sf-",
    "signalRServiceSignalR": "sigr",
    "sqlManagedInstances": "sqlmi-",
    "sqlServers": "sql-",
    "sqlServersDataWarehouse": "sqldw-",
    "sqlServersDatabases": "sqldb-",
    "sqlServersDatabasesStretch": "sqlstrdb-",
    "storageStorageAccounts": "st",
    "storageStorageAccountsVm": "stvm",
    "storSimpleManagers": "ssimp",
    "streamAnalyticsCluster": "asa-",
    "synapseWorkspaces": "syn",
    "synapseWorkspacesAnalyticsWorkspaces": "synw",
    "synapseWorkspacesSqlPoolsDedicated": "syndp",
    "synapseWorkspacesSqlPoolsSpark": "synsp",
    "timeSeriesInsightsEnvironments": "tsi-",
    "webServerFarms": "plan-",
    "webSitesAppService": "app-",
    "webSitesAppServiceEnvironment": "ase-",
    "webSitesFunctions": "func-",
    "webStaticSites": "stapp-"
}
""";

    public static string Generate() {
        return content;
    }
}

class MainBicep {

    private const string content = """
targetScope = 'subscription'

@minLength(1)
@maxLength(64)
@description('Name of the the environment which is used to generate a short unique hash used in all resources.')
param environmentName string

@minLength(1)
@description('Primary location for all resources')
param location string = 'eastus2'

param apiServiceName string = ''
param appServicePlanName string = ''
param keyVaultName string = ''
param resourceGroupName string = ''

@description('Flag to use Azure API Management to mediate the calls between the Web frontend and the backend API')
param useAPIM bool = false

@description('Id of the user or app to assign application roles')
param principalId string = ''

var abbrs = loadJsonContent('./abbreviations.json')
var resourceToken = toLower(uniqueString(subscription().id, environmentName, location))
var tags = { 'azd-env-name': environmentName }

// Organize resources in a resource group
resource rg 'Microsoft.Resources/resourceGroups@2021-04-01' = {
  name: !empty(resourceGroupName) ? resourceGroupName : '${abbrs.resourcesResourceGroups}${environmentName}'
  location: location
  tags: tags
}

// The application backend
module api 'api.bicep' = {
  name: 'api'
  scope: rg
  params: {
    name: !empty(apiServiceName) ? apiServiceName : '${abbrs.webSitesAppService}api-${resourceToken}'
    location: location
    tags: tags
    appServicePlanId: appServicePlan.outputs.id
    keyVaultName: keyVault.outputs.name
    allowedOrigins: [ ]
    appSettings: {
    }
    runtimeName: 'dotnetcore'
    runtimeVersion: '6.0'
    scmDoBuildDuringDeployment: false
  }
}

// Give the API access to KeyVault
module apiKeyVaultAccess 'keyvault-access.bicep' = {
  name: 'api-keyvault-access'
  scope: rg
  params: {
    keyVaultName: keyVault.outputs.name
    principalId: api.outputs.SERVICE_API_IDENTITY_PRINCIPAL_ID
  }
}

// Create an App Service Plan to group applications under the same payment plan and SKU
module appServicePlan 'app-service-plan.bicep' = {
  name: 'appserviceplan'
  scope: rg
  params: {
    name: !empty(appServicePlanName) ? appServicePlanName : '${abbrs.webServerFarms}${resourceToken}'
    location: location
    tags: tags
    sku: {
      name: 'B1'
    }
  }
}

// Store secrets in a keyvault
module keyVault 'keyvault.bicep' = {
  name: 'keyvault'
  scope: rg
  params: {
    name: !empty(keyVaultName) ? keyVaultName : '${abbrs.keyVaultVaults}${resourceToken}'
    location: location
    tags: tags
    principalId: principalId
  }
}

// App outputs
output AZURE_KEY_VAULT_ENDPOINT string = keyVault.outputs.endpoint
output AZURE_KEY_VAULT_NAME string = keyVault.outputs.name
output AZURE_LOCATION string = location
output AZURE_TENANT_ID string = tenant().tenantId
output REACT_APP_API_BASE_URL string = api.outputs.SERVICE_API_URI
output USE_APIM bool = useAPIM
""";
    public static string Generate() {
        return content;
    }
}

class MainParams {
    
    private const string content = """
{
  "$schema": "https://schema.management.azure.com/schemas/2019-04-01/deploymentParameters.json#",
  "contentVersion": "1.0.0.0",
  "parameters": {
    "environmentName": {
      "value": "${AZURE_ENV_NAME}"
    },
    "location": {
      "value": "eastus2"
    },
    "principalId": {
      "value": "${AZURE_PRINCIPAL_ID}"
    },
    "useAPIM": {
      "value": "${USE_APIM=false}"
    }
  }
}
""";
    public static string Generate() {
        return content;
    }
}

class App {
    
    private const string content = """
param name string
param location string = resourceGroup().location
param tags object = {}

// Reference Properties
param applicationInsightsName string = ''
param appServicePlanId string
param keyVaultName string = ''
param managedIdentity bool = !empty(keyVaultName)

// Runtime Properties
@allowed([
  'dotnet', 'dotnetcore', 'dotnet-isolated', 'node', 'python', 'java', 'powershell', 'custom'
])
param runtimeName string
param runtimeNameAndVersion string = '${runtimeName}|${runtimeVersion}'
param runtimeVersion string

// Microsoft.Web/sites Properties
param kind string = 'app,linux'

// Microsoft.Web/sites/config
param allowedOrigins array = []
param alwaysOn bool = true
param appCommandLine string = ''
@secure()
param appSettings object = {}
param clientAffinityEnabled bool = false
param enableOryxBuild bool = contains(kind, 'linux')
param functionAppScaleLimit int = -1
param linuxFxVersion string = runtimeNameAndVersion
param minimumElasticInstanceCount int = -1
param numberOfWorkers int = -1
param scmDoBuildDuringDeployment bool = false
param use32BitWorkerProcess bool = false
param ftpsState string = 'FtpsOnly'
param healthCheckPath string = ''

resource appService 'Microsoft.Web/sites@2022-03-01' = {
  name: name
  location: location
  tags: union(tags, { 'azd-service-name': 'api' })
  kind: kind
  properties: {
    serverFarmId: appServicePlanId
    siteConfig: {
      linuxFxVersion: linuxFxVersion
      alwaysOn: alwaysOn
      ftpsState: ftpsState
      minTlsVersion: '1.2'
      appCommandLine: appCommandLine
      numberOfWorkers: numberOfWorkers != -1 ? numberOfWorkers : null
      minimumElasticInstanceCount: minimumElasticInstanceCount != -1 ? minimumElasticInstanceCount : null
      use32BitWorkerProcess: use32BitWorkerProcess
      functionAppScaleLimit: functionAppScaleLimit != -1 ? functionAppScaleLimit : null
      healthCheckPath: healthCheckPath
      cors: {
        allowedOrigins: union([ 'https://portal.azure.com', 'https://ms.portal.azure.com' ], allowedOrigins)
      }
    }
    clientAffinityEnabled: clientAffinityEnabled
    httpsOnly: true
  }

  identity: { type: managedIdentity ? 'SystemAssigned' : 'None' }

  resource configLogs 'config' = {
    name: 'logs'
    properties: {
      applicationLogs: { fileSystem: { level: 'Verbose' } }
      detailedErrorMessages: { enabled: true }
      failedRequestsTracing: { enabled: true }
      httpLogs: { fileSystem: { enabled: true, retentionInDays: 1, retentionInMb: 35 } }
    }
  }

  resource basicPublishingCredentialsPoliciesFtp 'basicPublishingCredentialsPolicies' = {
    name: 'ftp'
    properties: {
      allow: false
    }
  }

  resource basicPublishingCredentialsPoliciesScm 'basicPublishingCredentialsPolicies' = {
    name: 'scm'
    properties: {
      allow: false
    }
  }
}

resource settings 'Microsoft.Web/sites/config@2022-03-01' = if (!empty(appSettings)) {
  name: 'appsettings'
  parent: appService
  properties: union(appSettings,
      {
        SCM_DO_BUILD_DURING_DEPLOYMENT: string(scmDoBuildDuringDeployment)
        ENABLE_ORYX_BUILD: string(enableOryxBuild)
      },
      runtimeName == 'python' && appCommandLine == '' ? { PYTHON_ENABLE_GUNICORN_MULTIWORKERS: 'true'} : {},
      !empty(applicationInsightsName) ? { APPLICATIONINSIGHTS_CONNECTION_STRING: applicationInsights.properties.ConnectionString } : {},
      !empty(keyVaultName) ? { AZURE_KEY_VAULT_ENDPOINT: keyVault.properties.vaultUri } : {})
}

resource keyVault 'Microsoft.KeyVault/vaults@2022-07-01' existing = if (!(empty(keyVaultName))) {
  name: keyVaultName
}

resource applicationInsights 'Microsoft.Insights/components@2020-02-02' existing = if (!empty(applicationInsightsName)) {
  name: applicationInsightsName
}

output SERVICE_API_IDENTITY_PRINCIPAL_ID string = managedIdentity ? appService.identity.principalId : ''
output name string = appService.name
output SERVICE_API_URI string = 'https://${appService.properties.defaultHostName}'

""";
    public static string Generate() {
        return content;
    }
}

class KeyVault {
        private const string content = """
param name string
param location string = resourceGroup().location
param tags object = {}

param principalId string = ''

resource keyVault 'Microsoft.KeyVault/vaults@2022-07-01' = {
  name: name
  location: location
  tags: tags
  properties: {
    tenantId: subscription().tenantId
    sku: { family: 'A', name: 'standard' }
    accessPolicies: !empty(principalId) ? [
      {
        objectId: principalId
        permissions: { secrets: [ 'get', 'list' ] }
        tenantId: subscription().tenantId
      }
    ] : []
  }
}

output endpoint string = keyVault.properties.vaultUri
output name string = keyVault.name

""";
    public static string Generate() {
        return content;
    }
}

class KeyVaultAccess {
        private const string content = """
param name string = 'add'

param keyVaultName string
param permissions object = { secrets: [ 'get', 'list' ] }
param principalId string

resource keyVaultAccessPolicies 'Microsoft.KeyVault/vaults/accessPolicies@2022-07-01' = {
  parent: keyVault
  name: name
  properties: {
    accessPolicies: [ {
        objectId: principalId
        tenantId: subscription().tenantId
        permissions: permissions
      } ]
  }
}

resource keyVault 'Microsoft.KeyVault/vaults@2022-07-01' existing = {
  name: keyVaultName
}

""";
    public static string Generate() {
        return content;
    }
}

class AppService {
        private const string content = """
param name string
param location string = resourceGroup().location
param tags object = {}

param kind string = ''
param reserved bool = true
param sku object

resource appServicePlan 'Microsoft.Web/serverfarms@2022-03-01' = {
  name: name
  location: location
  tags: tags
  sku: sku
  kind: kind
  properties: {
    reserved: reserved
  }
}

output id string = appServicePlan.id
output name string = appServicePlan.name

""";
    public static string Generate() {
        return content;
    }
}