using flowmatic.infraestructure.generators;

namespace flowmatic.infraestructure;

public class CommandLineInterface
{
    private readonly ICodeGenerator codeGenerator;

    public CommandLineInterface(ICodeGenerator codeGenerator)
    {
        this.codeGenerator = codeGenerator;
    }

    public void HandleCommand(string[] args)
    {
        string modelName = args[0]; // Simplificación del parsing de argumentos
        codeGenerator.GenerateCode(modelName);
    }
}