using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    internal class MatrixRotation
    {
        public static void RotateClockwise(int[,] matrix) // Z swap
        {
            StringBuilder sb = new StringBuilder();
            int temp = 0;
            int x = 0;
            int y = matrix.GetLength(0)-1;
            int i2 = 0;

            for (int i = i2; i < matrix.GetLength(0) - 1 - i2; i++)
            {
                
                temp = matrix[(x + i), (y - i2)];
                matrix[(x + i), (y - i2)] = matrix[(y - i), (x + i2)];
                matrix[(y - i), (x + i2)] = temp;

                temp = matrix[(x + i2), (x + i)];
                matrix[(x + i2), (x + i)] = matrix[(x + i), (y - i2)];
                matrix[(x + i), (y - i2)] = temp;

                temp = matrix[(y - i), (x + i2)];
                matrix[(y - i), (x + i2)] = matrix[(y - i2), (y - i)];
                matrix[(y - i2), (y - i)] = temp;
                if (i == matrix.GetLength(0) - 2 - i2)
                {
                    i2++;
                    i = i2-1;
                }
                if (i2 == matrix.GetLength(0) - 2)
                    break;
            }



            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sb.Append("[");
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sb.Append(matrix[i,j]+",");
                }
                sb.Remove(sb.Length - 1, 1);
                sb.Append("]\n");
            }
           

            Console.WriteLine(sb.ToString());

        }

        

        public static void RotateClockwiseCheat(int[,] matrix)
        {
            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sb.Append("[");
                for (int j = matrix.GetLength(0) - 1; j >= 0; j--)
                {
                    sb.Append(matrix[j, i] + ",");
                }
                sb.Remove(sb.Length - 1, 1);
                sb.Append("]\n");
            }
            

            Console.WriteLine(sb.ToString());

        }


        
    }
}
