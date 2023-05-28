
using System.Globalization;

public class Program
{
    public static List<T> ObterObjetosUnicos<T>(List<T> lista)
    {
        HashSet<T> objetosUnicos = new HashSet<T>(lista);
        return new List<T>(objetosUnicos);
    }

    public static List<object> LerValoresDaEntrada()
    {
        Console.WriteLine("Insira os valores separados por vírgula:");
        string input = Console.ReadLine();

        List<object> listaOriginal = new List<object>();
        foreach (string valor in input.Split(','))
        {
            if (int.TryParse(valor.Trim(), out int numero))
            {
                listaOriginal.Add(numero);
            }
            else if (double.TryParse(valor.Trim(), NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out double numeroDecimal))
            {
                listaOriginal.Add(numeroDecimal);
            }
            else if (DateTime.TryParse(valor.Trim(), out DateTime data))
            {
                listaOriginal.Add(data);
            }
            else
            {
                listaOriginal.Add(valor);
            }
        }

        return listaOriginal;
    }

    public static void Main(string[] args)
    {
        List<object> listaOriginal = LerValoresDaEntrada();

        if (listaOriginal.Count > 0)
        {
            List<object> listaUnica = ObterObjetosUnicos(listaOriginal);

            Console.WriteLine("Lista Original: " + string.Join(", ", listaOriginal));
            Console.WriteLine("Lista Única: " + string.Join(", ", listaUnica));
        }
        else
        {
            Console.WriteLine("Nenhum valor válido foi inserido na lista original.");
        }
    }
}
