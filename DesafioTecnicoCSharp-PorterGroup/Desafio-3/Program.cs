using NCalc;

public class Calculadora
{
    public static double AvaliarExpressao(string expressao)
    {
        expressao = expressao.Replace(" ", "");

        if (string.IsNullOrEmpty(expressao))
        {
            throw new ArgumentException("Erro: Expressão matemática ausente.");
        }

        if (expressao.Contains("/0"))
        {
            throw new DivideByZeroException("Erro: Expressão matemática tentou dividir por zero.");
        }

        Expression expressaoCalculada = new Expression(expressao);
        VerificarErros(expressaoCalculada);

        try
        {
            return ExecutarExpressao(expressaoCalculada);
        }
        catch (FormatException)
        {
            throw new FormatException("Erro: Formato de expressão matemática inválido.");
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro: Ocorreu uma exceção durante a avaliação da expressão: {ex.Message}");
        }
    }

    private static void VerificarErros(Expression expressaoCalculada)
    {
        if (expressaoCalculada.HasErrors())
        {
            throw new ArgumentException("Erro: Expressão matemática inválida.");
        }
    }

    private static double ExecutarExpressao(Expression expressaoCalculada)
    {
        return Convert.ToDouble(expressaoCalculada.Evaluate());
    }

    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Digite a expressão matemárica simples a ser calculada: ");
            string expressao = Console.ReadLine();

            double resultado = AvaliarExpressao(expressao);
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
