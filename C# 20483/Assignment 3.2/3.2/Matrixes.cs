using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    internal class Matrixes
    {
        private  int row;
        private   int col;
        private   int[,] matrix;
        public   int this[int index0,int index1] { get { return matrix[index0,index1]; } set { matrix[index0,index1] = value; } }
        public  int Row { get { return row; }  }
        public int Col { get { return col; }  }
        
        

        //method for creating matrix 
        
        //operator overload methods *2
        public void CreateMatrix(int row, int col, params int[] arr)
        {
            this.row = row;
            this.col = col;
            this.matrix = new int[row,col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++) 
                {
                    
                    matrix[i, j] = arr[j+(i*col)];
                
                                            
                }
            }
            
            

        }
        public void BuildVisual()
        {
            
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < row; i++)
            {
                
                for(int j = 0; j < col; j++)
                {
                    sb.Append("|"+this[i,j]);
                }
                sb.Append("|\n");
            }

            Console.WriteLine($"{sb.ToString()}");
        }

        public static Matrixes operator +(Matrixes m1, Matrixes m2)
        {
            Matrixes m3 = new Matrixes();
            m3.row = m1.Row;
            m3.col = m1.Col;
            m3.matrix = new int[m3.row, m3.col];  // how to initialize this without the bs...
            for (int i = 0; i < m3.Row; i++)
            {

                for (int j = 0; j < m3.Col; j++)
                {
                    m3.matrix[i,j] = (m1.matrix[i,j] + m2.matrix[i,j]);
                }
                
            }
            return m3;
         
        } 

        public static Matrixes operator -(Matrixes m1, Matrixes m2)
        {
            Matrixes m3 = new Matrixes();
            m3.row = m1.Row;
            m3.col = m1.Col;
            m3.matrix = new int[m3.row,m3.col]; // how to initialize this without the bs...
            for (int i = 0; i < m3.Row; i++)
            {

                for (int j = 0; j < m3.Col; j++)
                {
                    m3.matrix[i, j] = (m1.matrix[i, j] - m2.matrix[i, j]);
                }

            }
            return m3;

        }

    }
}
