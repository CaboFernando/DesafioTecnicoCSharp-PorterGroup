
public class NumerosEmPalavras
{
    private static string[] unidades = {
        "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze",
        "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove"
    };

    public static string ConverteNumerosEmPalavras(int numero)
    {
        if (numero < 20)
            return unidades[numero];

        return "";
    }

    public static void Main()
    {
        Console.WriteLine("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        string numeroPorExtenso = ConverteNumerosEmPalavras(numero);
        Console.WriteLine("Número por extenso: " + numeroPorExtenso);
    }
}
