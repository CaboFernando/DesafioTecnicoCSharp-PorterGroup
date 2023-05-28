
public class Program
{
    public static List<T> ObterObjetosUnicos<T>(List<T> lista)
    {
        HashSet<T> objetosUnicos = new HashSet<T>(lista);
        return new List<T>(objetosUnicos);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Insira os valores separados por vírgula:");
        string input = Console.ReadLine();

        List<int> listaOriginal = new List<int>();
        foreach (string valor in input.Split(','))
        {
            if (int.TryParse(valor.Trim(), out int numero))
            {
                listaOriginal.Add(numero);
            }
        }

        if (listaOriginal.Count > 0)
        {
            List<int> listaUnica = ObterObjetosUnicos(listaOriginal);

            Console.WriteLine("Lista Original: " + string.Join(", ", listaOriginal));
            Console.WriteLine("Lista Única: " + string.Join(", ", listaUnica));
        }
        else
        {
            Console.WriteLine("Nenhum valor válido foi inserido na lista original.");
        }
    }
}
