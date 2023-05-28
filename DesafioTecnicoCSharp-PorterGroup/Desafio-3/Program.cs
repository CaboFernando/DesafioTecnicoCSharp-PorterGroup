using NCalc;

public class Calculadora
{
    public static double AvaliarExpressao(string expressao)
    {
        if (string.IsNullOrEmpty(expressao))
        {
            Console.WriteLine("Erro: Expressão matemática ausente.");
            Environment.Exit(1);
        }

        Expression expressaoCalculada = new Expression(expressao);
        VerificarErros(expressaoCalculada);

        try
        {
            return ExecutarExpressao(expressaoCalculada);
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Formato de expressão matemática inválido.");
            Environment.Exit(1);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: Ocorreu uma exceção durante a avaliação da expressão: {ex.Message}");
            Environment.Exit(1);
        }

        return 0;
    }

    private static void VerificarErros(Expression expressaoCalculada)
    {
        if (expressaoCalculada.HasErrors())
        {
            Console.WriteLine("Erro: Expressão matemática inválida.");
            Environment.Exit(1);
        }
    }

    private static double ExecutarExpressao(Expression expressaoCalculada)
    {
        return Convert.ToDouble(expressaoCalculada.Evaluate());
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a expressão matemárica simples a ser calculada: ");
        string expressao = Console.ReadLine();

        double resultado = AvaliarExpressao(expressao);
        Console.WriteLine($"Resultado: {resultado}");
    }
}
