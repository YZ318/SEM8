class Program
{
    static void Main()
    {
        int[,] arr = new int[4, 4]; // создаем массив
        int n = 1, i = 0, j = 0, m = 4; // инициализируем переменные

        while (n <= m * m)
        {
            for (int k = i; k < m; k++)
            {
                arr[i, k] = n++;
            }
            for (int k = i + 1; k < m; k++)
            {
                arr[k, m - 1] = n++;
            }
            for (int k = m - 2; k >= j; k--)
            {
                arr[m - 1, k] = n++;
            }
            for (int k = m - 2; k > i; k--)
            {
                arr[k, j] = n++;
            }
            i++; j++; m -= 1;
        }

        for (i = 0; i < 4; i++)
        { // выводим массив на экран
            for (j = 0; j < 4; j++)
            {
                Console.Write("{0:D2} ", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}