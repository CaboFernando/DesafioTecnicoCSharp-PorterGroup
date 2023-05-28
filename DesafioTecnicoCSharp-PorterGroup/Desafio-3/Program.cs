using NCalc;

public class Calculadora
{
    public static double AvaliarExpressao(string expressao)
    {
        Expression expressaoCalculada = new Expression(expressao);
        double resultado = 0;

        try
        {
            resultado = Convert.ToDouble(expressaoCalculada.Evaluate());
        }
        catch (EvaluationException)
        {
            Console.WriteLine("Erro: Expressão matemática inválida.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Formato de expressão matemática inválido.");
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
