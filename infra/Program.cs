var output = "";
var inputs = Environment.GetCommandLineArgs();
if (inputs.Length > 1) {
    output = inputs[1];
    Directory.CreateDirectory(output);
}

using (StreamWriter outputFile = new(Path.Combine(output,"abbreviations.json")))
{
    outputFile.Write(ABB.Generate());
}

using (StreamWriter outputFile = new(Path.Combine(output,"main.bicep")))
{
    outputFile.Write(MainBicep.Generate());
}

using (StreamWriter outputFile = new(Path.Combine(output,"main.parameters.json")))
{
    outputFile.Write(MainParams.Generate());
}

using (StreamWriter outputFile = new(Path.Combine(output,"api.bicep")))
{
    outputFile.Write(App.Generate());
}

using (StreamWriter outputFile = new(Path.Combine(output,"keyvault.bicep")))
{
    outputFile.Write(KeyVault.Generate());
}

using (StreamWriter outputFile = new(Path.Combine(output,"app-service-plan.bicep")))
{
    outputFile.Write(AppService.Generate());
}

using (StreamWriter outputFile = new(Path.Combine(output,"keyvault-access.bicep")))
{
    outputFile.Write(KeyVaultAccess.Generate());
}
