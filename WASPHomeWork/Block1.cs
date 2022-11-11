using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASPHomeWork1
{
    public class Block1
    {
        public static void Task1()
        {
            //есть подозрения, что возможно это решается как-то через рекурсию...
            for(int a = 1; a < 10; a++)
                for (int b = 0; b < 10; b++)
                    for (int c = 0; c < 10; c++)
                        for (int d = 0; d < 10; d++)
                        {
                            if (a > b && b > c && c > d)
                            {
                                Console.Write(a);
                                Console.Write(b);
                                Console.Write(c);
                                Console.WriteLine(d);
                            }
                        }
        }

        public static void Task2()
        {
            //размерность матрицы
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            
            //переменная, которую будем то увеличивать на 1, то уменьшать
            int tmp_n = n;
            
            //шаг, на который будем увеличивать или уменьшать переменную
            int step;

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; j++)
                {
                    //ставим шаг положительным
                    step = 1;
            
                    //условие для вывода пробелов: перед первым числом не выводим
                    if (j != 0) Console.Write(" ");

                    //если мы уже вывели число равное размеру n, то следующие числа
                    //должны уменьшаться. По этому шаг будет отрицательным
                    if (tmp_n == n) step = -1;

                    //выводим число
                    Console.Write(tmp_n);
                    //увеличиваем/уменьшаем число
                    tmp_n += step;
                }
                Console.WriteLine();

                //высчитываем с какого числа начнется ряд
                tmp_n = n - i - 1;           
            }
        }
    }
}
