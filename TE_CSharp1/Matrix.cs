using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class Matrix
    {
        public static void Main()
        {
            Console.WriteLine("Matrix Addition");
            int row, col;
            Console.WriteLine("Enter the number of rows");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns");
            col = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[row, col];
            int[,] matrix2 = new int[row, col];
            int[,] sum = new int[row, col];
            Console.WriteLine("First Matrix");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for(int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter the [{i + 1},{j + 1}] Element");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("Second Matrix");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter the [{i + 1},{j + 1}] Element");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("First Matrix");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.Write(matrix1[i,j]+" ");
                    
                    
                    
                }
                Console.WriteLine();

            }
            Console.WriteLine("Second Matrix");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write(matrix2[i,j]+" ");
                    
                }
                Console.WriteLine();

            }

            Console.WriteLine("Sum Of 2 Matrix is :");
            
            for (int i = 0; i < sum.GetLength(0); i++)
            {
                for (int j = 0; j < sum.GetLength(1); j++)
                {
                    sum[i,j]= matrix1[i, j] + matrix2[i, j];
                    Console.Write(sum[i,j]+" ");
                }
                Console.WriteLine();

            }
     
        }
    }
}
