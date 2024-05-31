using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    internal class Visualizer
    {
        public static void CreateMatrix()
        {
            int row = 0;
            int col = 0;

            interror1:
            Console.Write("To create a 2D array, please enter the # of rows you wish to create: ");
            if(int.TryParse(Console.ReadLine(), out row))
            {
                
            }
            else
            {
                Console.WriteLine("Please enter an integer");
                goto interror1;
            }
            interror2:
            Console.Write("Please enter the # of columns you wish to create: ");
            if (int.TryParse(Console.ReadLine(), out col))
            {

            }
            else
            {
                Console.WriteLine("Please enter an integer");
                goto interror2;
            }

            Console.WriteLine("Please enter the integers for the array:\n");
            int[,] matrix = new int[row,col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++) 
                {
                    redo:
                    Console.Write($"[{i}][{j}]: ");
                    if(int.TryParse(Console.ReadLine(), out matrix[i, j]))
                    {

                    } else
                    {
                        Console.WriteLine("Please enter an integer");
                        goto redo;
                    }
                                            
                }
            }
            Console.WriteLine("\nHere is your matrix:\n");
            BuildVisual(matrix);
            

        }
        private static void BuildVisual(int[,] data)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0;i < data.GetLength(0); i++)
            {
                
                for(int j = 0; j < data.GetLength(1); j++)
                {
                    sb.Append("|"+data[i,j]);
                }
                sb.Append("|\n");
            }

            Console.WriteLine($"{sb.ToString()}");
        }
    }
}
