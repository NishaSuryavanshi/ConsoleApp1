using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assignment2DArray
{
    class TransposeOfMatrix
    {
        static int N = 4;

        // This function stores transpose
        // of A[][] in B[][]
        static void transpose(int[,] A, int[,] B)
        {
            int i, j;
            for (i = 0; i < N; i++)
                for (j = 0; j < N; j++)
                    B[i, j] = A[j, i];
        }

        // Driver code
        public static void Main()
        {
            int[,] A = { {1, 1, 1, 1},
                     {2, 2, 2, 2},
                     {3, 3, 3, 3},
                     {4, 4, 4, 4}};

            int[,] B = new int[N, N];

            // Function calling
            transpose(A, B);

            Console.Write("Result matrix is \n");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(B[i, j] + " ");
                Console.Write("\n");
            }
        }
    }
}
