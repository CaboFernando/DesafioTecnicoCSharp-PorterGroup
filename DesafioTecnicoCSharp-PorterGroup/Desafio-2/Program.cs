public class Program
{
    public static int SomarNumeros(int[] numeros)
    {
        int tamanho = numeros.Length;
        int soma = 0;

        for (int i = 0; i < tamanho; i++)
        {
            soma += numeros[i];
        }

        return soma;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Digite os números separados por vírgula:");
        string entrada = Console.ReadLine();

        string[] numerosString = entrada.Split(',');
        int[] numeros = new int[numerosString.Length];

        for (int i = 0; i < numerosString.Length; i++)
        {
            numeros[i] = Convert.ToInt32(numerosString[i]);
        }

        int resultado = SomarNumeros(numeros);

        Console.WriteLine("A soma dos números é: " + resultado);
    }
}
