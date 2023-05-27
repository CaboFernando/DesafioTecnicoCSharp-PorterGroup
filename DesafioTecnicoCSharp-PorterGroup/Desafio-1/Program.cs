
public class NumerosEmPalavras
{
    private static string[] unidades = {
        "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze",
        "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove"
    };

    private static string[] dezenas = {
        "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa"
    };

    private static string[] centenas = {
        "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos",
        "oitocentos", "novecentos"
    };

    public static string ConverteNumerosEmPalavras(int numero)
    {
        if (numero < 0)
            return "menos " + ConverteNumerosEmPalavras(Math.Abs(numero));

        if (numero < 20)
            return unidades[numero];

        if (numero < 100)
            return dezenas[numero / 10] + ((numero % 10 != 0) ? " e " + ConverteNumerosEmPalavras(numero % 10) : "");

        if (numero < 1000)
        {
            if (numero == 100) return "cem";

            return centenas[numero / 100] + ((numero % 100 != 0) ? " e " + ConverteNumerosEmPalavras(numero % 100) : "");
        }

        if (numero < 1000000)
        {
            if (numero == 1000) return "mil";

            return ConverteNumerosEmPalavras(numero / 1000) + " mil" + ((numero % 1000 != 0) ? " e " + ConverteNumerosEmPalavras(numero % 1000) : "");
        }

        if (numero < 1000000000)
            return ConverteNumerosEmPalavras(numero / 1000000) + " milhão" + ((numero % 1000000 != 0) ? " e " + ConverteNumerosEmPalavras(numero % 1000000) : "");


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
