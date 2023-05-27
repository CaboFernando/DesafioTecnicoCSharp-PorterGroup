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
        int[] numeros = new int[1000000];

        for (int i = 0; i < numeros.Length; i++)
            numeros[i] = 1;

        int resultado = SomarNumeros(numeros);
        

        Console.WriteLine("A soma dos números é: " + resultado);
    }
}
