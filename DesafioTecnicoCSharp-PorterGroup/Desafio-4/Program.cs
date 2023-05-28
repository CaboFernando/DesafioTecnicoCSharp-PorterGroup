
public class Program
{
    public static List<T> ObterObjetosUnicos<T>(List<T> lista)
    {
        HashSet<T> objetosUnicos = new HashSet<T>(lista);
        return new List<T>(objetosUnicos);
    }

    public static void Main(string[] args)
    {
        // Exemplo de uso da função
        List<int> listaOriginal = new List<int> { 1, 2, 3, 3, 4, 5, 5, 6, 7, 7 };
        List<int> listaUnica = ObterObjetosUnicos(listaOriginal);

        // Exibindo a lista com objetos únicos
        Console.WriteLine("Lista Original: " + string.Join(", ", listaOriginal));
        Console.WriteLine("Lista Única: " + string.Join(", ", listaUnica));
    }
}
