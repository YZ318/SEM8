class Program
{
    static void SortRowDescending(ref int[] row)
    {
        Array.Sort(row);
        Array.Reverse(row);
    }

    static void Main(string[] args)
    {
        int[,] array = new int[,] {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
        };

        Console.WriteLine("Original array:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0} ", array[i, j]);
            }
            Console.WriteLine();
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int[] row = new int[array.GetLength(1)];
            for (int j = 0; j < array.GetLength(1); j++)
            {
                row[j] = array[i, j];
            }
            SortRowDescending(ref row);
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = row[j];
            }
        }

        Console.WriteLine("Sorted array:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0} ", array[i, j]);
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}