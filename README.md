# fsharp-azure-functions-v2

# Azure Functions V2 FSharp HTTP Template

At the time this package was created, the F# tooling support for Azure Functions v2 is basically non-existent. This package is a 'dotnet new' template for creating an Azure Functions project targeting F# and .net core 2. 

The template contains one function with an HTTP trigger. It also contains all of the necessary files in the .vscode folder to enable local debugging. Should be able to just hit F5 (assuming you have the azure functions extension installed in VSCode).

Alternately, if you have the azure functions core tools installed, you can execute a `dotnet build`, `dotnet publish`, then navigate to the /bin/Debug/netcoreapp2.1/publish and run `func start` to execute without debugging in VSCode. Unfortunately, you have to execute that command in the publish folder as the azure functions core tools don't seem to support execution from the root folder as of yet (like they do for C# projects).
