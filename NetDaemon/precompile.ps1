
$config = $args[0]

if($config -eq "Fast Remote Debug")
{
    echo "Fast Remote Debug"
}
else
{

    # Update all nugets to latest versions
    $regex = 'PackageReference Include="([^"]*)" Version="([^"]*)"'
    
    ForEach ($file in get-childitem . -recurse | where { $_.extension -like "*proj" }) {
    $packages = Get-Content $file.FullName |
    select-string -pattern $regex -AllMatches | 
    ForEach-Object { $_.Matches } | 
    ForEach-Object { $_.Groups[1].Value.ToString() } | 
    sort -Unique
    
    ForEach ($package in $packages) {
        write-host "Update $file package :$package"  -foreground 'magenta'
        $fullName = $file.FullName
        iex "dotnet add $fullName package $package"
    }
    }
    
    echo "Clear CodeGen folder"
    rm -r -fo NetDaemonCodegen
    
    # Update the codegen
    echo "Update Codegen"
    dotnet tool update -g joysoftware.netdaemon.hassmodel.codegen
    echo "Run Codegen"
    nd-codegen -host 192.168.1.20
    echo "-----------------------------------------------------------------"
    
    echo "Replace Transition from long to float"
    $base = Get-Location
    $location = "$base\HomeAssistantGenerated.cs"
    echo "$location"
    $content = [System.IO.File]::ReadAllText("$location")
    $content = $content.Replace("long? Transition","float? Transition")
    $content = $content.Replace("long? transition","float? transition")
    $content = $content.Replace("long? @transition","float? @transition")
    [System.IO.File]::WriteAllText("$location", $content)
}

if($config -eq "Publish"){
    echo "PUBLISH FOR SERVER ----------------------------------------------------------"
    $location = "$base\appsettings.json"
    $appconfig = Get-Content "$location" | ConvertFrom-Json
    $appconfig.HomeAssistant.Host = "127.0.0.1"
    $appconfig | ConvertTo-Json | Out-File "$location"

}
else{
    echo "BUILD FOR REMOTE ------------------------------------------------------------"
    $location = "$base\appsettings.json"
    $appconfig = Get-Content "$location" | ConvertFrom-Json
    $appconfig.HomeAssistant.Host = "192.168.1.20"
    $appconfig | ConvertTo-Json | Out-File "$location"

}