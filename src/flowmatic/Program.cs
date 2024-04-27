using System.CommandLine;
using System.CommandLine.Invocation;
using flowmatic.infraestructure.Commands;

var rootCommand = FlowmaticRootCommand.rootCommand; 

rootCommand.Description = "CLI Tool to generate CRUD operations.";

rootCommand.Handler = CommandHandler.Create((string model) =>
{
    Console.WriteLine($"Generating CRUD for model: {model}");
    // Implementar la generación de CRUD aquí
});

rootCommand.Invoke(args);