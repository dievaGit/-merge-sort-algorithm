using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    class Program
    {
        static void Sorting(int[,] matrix, int col, int row)
        {
            int num = 0;

            for (int k = 0; k < row; k++)
            {
                for (int i = 0; i < col ; i++)
                {
                    if (i == col -1 && k < row - 1)
                    {
                      if (matrix[k, i] > matrix[k +1, 0])
                        {
                            num = matrix[k, i];
                            matrix[k, i] = matrix[k + 1, 0];
                            matrix[k + 1, 0] = num;
                        }
                    }
                    else
                    { 
                        if(i < col - 1)
                        {
                            if (matrix[k, i] > matrix[k, i + 1])
                            {
                                num = matrix[k, i];
                                matrix[k, i] = matrix[k, i + 1];
                                matrix[k, i + 1] = num;
                            }
                        }
                        
                    }
                   
                    
                    
                }
            }
        }

        static void Main(string[] args)
        {
            int n = 0, m = 0;

            do
            {
                Console.WriteLine(" Write the number of row greater than 2:");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n < 2);

            do
            {
                Console.WriteLine(" Write the number of columns greater than 2:");
                m = Convert.ToInt32(Console.ReadLine());
            }
            while (m < 2);

            int[,] matrixInt = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine(" Write one number:");
                    matrixInt[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" {0}", matrixInt[i, j]);
                }
                Console.Write(" \n");
            }
            Console.Write(" \n");

            Sorting(matrixInt, n, m);

            Console.WriteLine(" Ordered Matrix:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" {0}", matrixInt[i, j]);
                }
                Console.Write(" \n");
            }
            
            Console.ReadKey();

        }
    }
}
           
           
