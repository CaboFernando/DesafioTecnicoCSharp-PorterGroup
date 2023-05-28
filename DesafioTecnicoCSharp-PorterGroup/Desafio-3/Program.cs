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
        double resultado = 0;

        try
        {
            resultado = Convert.ToDouble(expressaoCalculada.Evaluate());
        }
        catch (EvaluationException)
        {
            Console.WriteLine("Erro: Expressão matemática inválida.");
            Environment.Exit(1);
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Formato de expressão matemática inválido.");
            Environment.Exit(1);
        }

        return resultado;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a expressão matemárica simples a ser calculada: ");
        string expressao = Console.ReadLine();

        double resultado = AvaliarExpressao(expressao);
        Console.WriteLine($"Resultado: {resultado}");
    }
}
