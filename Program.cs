using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main()
        {
            int n=0;
            try
            {
                Console.WriteLine("введите размерность матрицы");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 1)
                    throw new Exception("некорректно введены данные ");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                p();
                return;
            }
            int[,] array= new int[n, n];
            Random rnd = new Random();
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(0, 11);
                    Console.Write("{0,7}", array[i, j]);
                }
                Console.WriteLine();
            }
            
            bool diagonal1 = true;
            bool diagonal2 = true;

           
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] != array[j, i])
                    {
                        diagonal1 = false;
                        break;
                    }
                }
                if (!diagonal1)
                    break;
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] != array[array.GetLength(0) - j - 1, array.GetLength(1) - i - 1])
                    {
                        diagonal2 = false;
                        break;
                    }
                }
                if (!diagonal2) break;
            }

            if (diagonal1 && diagonal2)
            {
                Console.WriteLine("матрица симметрична относитеьно главной и побочной диагонали");
            }
            else if (diagonal1)
            {
                Console.WriteLine("матрица симетрична относительно главной диагонали");
            }
            else if (diagonal2)
            {
                Console.WriteLine("матрица симметрична относительно побочной диагонали");
            }
            else
            {
                Console.WriteLine("матрица вообще не симметрична");
            }
            
            void p()
            {
                Console.WriteLine("повторить ввод если да то 1 нет то 0");
                string y = Convert.ToString(Console.ReadLine());
                if (y == "1")
                    Main();
                else
                    return;
            }
            p();
            return;
        }
       
    }
}