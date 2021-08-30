using System;
using System.IO;

namespace DRY2
{
    struct MatrixOperations
    {
        public int n, m, p, q;

        // ...................................        
        public void FirstInitialization(int n, int m, double[,] arr1)
        {
            Console.Write("\nEnter elements in the first matrix: After every input press Enter\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatrix 1:\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr1[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void SecondtInitialization(int p, int q, double[,] arr2)
        {
            Console.Write("\nEnter elements in the second matrix: After every input press Enter\n");
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatrix 2:\n ");
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    Console.Write(arr2[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // After refactoring
        public void Initialization(int a, int b, double[,] arr, string seq)
        {
            Console.Write($"\nEnter elements in the {seq} matrix: After every input press Enter\n");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine($"\nMatrix {seq}:\n ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        // ..................................................
    }

    class Program
    {
        static void Main()
        {
            MatrixOperations operation = new MatrixOperations();
            // TODO: move array to struct as a member
            // The Task List window
            // To open Task List, select View > Task List, or from the keyboard press Ctrl+\,T.
            double[,] arr1 = new double[2, 1];
            double[,] arr2 = new double[1, 2];

            operation.FirstInitialization(2, 1, arr1);
            operation.SecondtInitialization(1, 2, arr2);

            Console.WriteLine("************************ After refactoring !!! ************************\n");
            // After refactoring
            operation.Initialization(2, 1, arr1, "first");
            operation.Initialization(1, 2, arr2, "second");

            // ..................................................

            Console.ReadLine();
        }
    }
}