class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[,] {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4},
            {5, 2, 6, 7}
        };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0} ", array[i, j]);
            }
            Console.WriteLine();
        }

        int minSum = int.MaxValue;
        int minSumRow = -1;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                rowSum += array[i, j];
            }
            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRow = i;
            }
        }

        Console.WriteLine("Строка с наименьшей суммой: {0}", minSumRow + 1);

        Console.ReadKey();
    }
}
