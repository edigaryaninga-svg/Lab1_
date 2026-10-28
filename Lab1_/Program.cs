using System;

namespace Lab1
{
    public class MatrixProcessor
    {
        public int N { get; set; }
        public int A { get; set; }
        public int B { get; set; }

        private int[,] matrix;
        private static Random random = new Random();

        public MatrixProcessor(int n, int a, int b)
        {
            N = n;
            A = a;
            B = b;
            matrix = new int[N, N];

            FillMatrix();
        }

        private void FillMatrix()
        {
            int min = Math.Min(A, B);
            int max = Math.Max(A, B);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = random.Next(min, max + 1);
                }
            }
        }

        public void ShowMatrix()
        {
            Console.WriteLine($"\n--- Մատրիցա ({N}x{N}) ---");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{matrix[i, j],5} ");
                }
                Console.WriteLine();
            }
        }

        public int GetOddNumbersCount()
        {
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int a = 10;
            int b = 50;

            MatrixProcessor myMatrix = new MatrixProcessor(n, a, b);

            myMatrix.ShowMatrix();

            int oddCount = myMatrix.GetOddNumbersCount();
            Console.WriteLine($"\n {oddCount}");

            Console.ReadKey();
        }
    }
}