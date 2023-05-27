
public class NumerosEmPalavras
{
    private static string[] unidades = {
        "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze",
        "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove"
    };

    private static string[] dezenas = {
        "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa"
    };

    public static string ConverteNumerosEmPalavras(int numero)
    {
        if (numero < 20)
            return unidades[numero];

        if (numero < 100)
            return dezenas[numero / 10] + ((numero % 10 != 0) ? " e " + ConverteNumerosEmPalavras(numero % 10) : "");

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
