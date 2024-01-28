# Summary

This is a really quick and simple test to see how [TypeGen](https://github.com/jburzynski/TypeGen) works with simple classes.

## How to use

1. Clone this repo
2. Either use the devcontainer configuration or install the dependencies locally (see below)
3. Run the build command which is "Generate typescript types" from the command palette in vscode or by running:
    
    ```bash
    dotnet build csharp-typegen-test.sln && dotnet typegen generate
    ```
4. Check the output in the `dist` folder

## Dependencies

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [TypeGen](https://github.com/jburzynski/TypeGen) - this can be installed with `dotnet tool install --global dotnet-typegen --version 5.0.1`

## Notes

- It looks like I could have used the `buildProject` setting in the [tgconfig.json](./tgconfig.json) file to avoid having to run the build command first. But this allows for the build to be optional.
- I chose to generate interfaces on the TypeScript side by using the `ExportTsInterface` attribute. `ExportTsClass` is also available, but I prefer interfaces on the TypeScript side.
