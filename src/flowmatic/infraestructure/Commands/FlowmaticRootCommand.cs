using System.CommandLine;

namespace flowmatic.infraestructure.Commands;

public static class FlowmaticRootCommand
{
    public static RootCommand rootCommand = new RootCommand
    {
        new Option<string>("--model", "Model name for which CRUD operations will be generated."),
    };
}