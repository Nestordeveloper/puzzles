class Program
{
    static void Main()
    {
        // RandomArray
        int[] randomArray = RandomArray();
        Console.WriteLine("Array aleatorio:");
        PrintArray(randomArray);
        Console.WriteLine($"Min Valor: {randomArray.Min()}");
        Console.WriteLine($"Max Valor: {randomArray.Max()}");
        Console.WriteLine($"Suma: {randomArray.Sum()}");
        Console.WriteLine();

        // TossCoin
        string tossResult = TossCoin();
        Console.WriteLine($"Resultado del lanzamiento de moneda: {tossResult}");
        Console.WriteLine();

        // Nombres
        List<string> names = Nombres();
        Console.WriteLine("Nombres filtrados:");
        PrintList(names);

        // Optional: Shuffle the list
        names = ShuffleList(names);
        Console.WriteLine("Nombres cambiados de orden:");
        PrintList(names);
    }

    static int[] RandomArray()
    {
        Random rand = new Random();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(5, 26);
        }
        return array;
    }

    static string TossCoin()
    {
        Random rand = new Random();
        Console.WriteLine("Lanzando la moneda...");
        bool isHeads = rand.Next(2) == 0;
        string result = isHeads ? "Cara" : "Cruz";
        Console.WriteLine(result);
        return result;
    }

    static List<string> Nombres()
    {
        List<string> names = new List<string> { "Todd", "Tiffany", "Charlie", "Ginebra", "Sydney" };
        return names.Where(name => name.Length > 5).ToList();
    }

    static List<string> ShuffleList(List<string> list)
    {
        Random rand = new Random();
        return list.OrderBy(item => rand.Next()).ToList();
    }

    static void PrintArray(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }

    static void PrintList(List<string> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
