class Program
{
    static void Main(string[] args)
    {
        int[,] matrix1 = new int[,] {
            {2, 4},
            {3, 2}
        };
        int[,] matrix2 = new int[,] {
            {3, 4},
            {3, 3}
        };

        int rows1 = matrix1.GetLength(0);
        int columns1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int columns2 = matrix2.GetLength(1);

        if (columns1 != rows2)
        {
            Console.WriteLine("Matrices cannot be multiplied: columns of the first matrix do not match rows of the second matrix.");
            return;
        }

        int[,] result = new int[rows1, columns2];
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                int sum = 0;
                for (int k = 0; k < columns1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }

        Console.WriteLine("Matrix 1:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns1; j++)
            {
                Console.Write("{0} ", matrix1[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Matrix 2:");
        for (int i = 0; i < rows2; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                Console.Write("{0} ", matrix2[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Result:");
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                Console.Write("{0} ", result[i, j]);
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}