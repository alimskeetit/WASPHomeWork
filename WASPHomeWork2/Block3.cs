using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASPHomeWork2
{
    internal class Block3
    {
        //пузырёк
        static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }

        public static void Task2()
        {
            Console.Write("Введите длину массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            Console.Write("Введите сам массив: ");
            //такое вот заполнение массива
            for (int i = 0;
                i < n;
                array[i - 1] = Convert.ToInt32(Console.ReadLine())) ;

            Console.Write("Введите, какой минимум в массиве найти: ");
            int k = Convert.ToInt32(Console.ReadLine());
            //сортируем массив
            BubbleSort(array);

            //просто берем k-тое минимальное число
            Console.WriteLine($"{k}-тый минимум - {array[k - 1]}");
        }

        //метод, который из обращения берет цифры, при этом каждый раз удаляя ':'
        public static int GetNum(ref string str)
        {
            StringBuilder num = new StringBuilder();
            
            //иду по символам, создавая число num
            for (int i = 0; i != str.Length; ++i)
            {
                //встречаю ':', удаляю из строки подстроку, которая шла до ':'
                if (str[i] == ':')
                {
                    str = str.Remove(0, i + 1);
                    break;
                }
                //создаю число
                num.Append(str[i]);
            }

            //возращаю число
            return Convert.ToInt32(num.ToString());
        }

        public static void Task3()
        {
            Console.Write("Введите длину массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            Console.Write("Введите сам массив: ");
            //такое вот заполнение массива
            for (int i = 0;
                i < n;
                array[i++] = Convert.ToInt32(Console.ReadLine())) ;

            Console.Write("Введите строку обращения: ");
            string command = Console.ReadLine();

            int start, end, step;

            //получаю начальную и конечную точки и шаг 
            start = GetNum(ref command);
            end = GetNum(ref command);
            step = GetNum(ref command);

            for (
                //определяю с какого индекса начинать вывод, с начального или конечного
                int i = step > 0 ? start : end; 
                //пока индекс в нужном диапозоне между start и end
                start <= i && i <= end; 
                //шагаю на step
                i += step
                )
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
