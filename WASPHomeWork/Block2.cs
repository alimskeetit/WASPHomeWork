namespace WASPHomeWork1
{
    public class Block2
    {
        public static void outBin(int a)
        {
            //с помощью рекурсии выводится в правильном порядке

            if (a != 0)
            {
                outBin(a / 2);
                //делится на 2? вывожу 0. нет - 1
                Console.Write((a % 2 == 0) ? 0 : 1);
            }
        }
        
        public static void Task1()
        {
            int a;
            Console.Write("Введите число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число в двоичной СС: ");
            outBin(a);
        }


        public static void Task3()
        {
            short shortik;
            long longik = 0;
            long longikTmp;
            for (int i = 0; i < 4; ++i)
            {
                shortik = Convert.ToInt16(Console.ReadLine());
                
                //из short в long
                longikTmp = shortik;
                
                //двигаем число short на столько битов, на сколько число старше
                longikTmp <<= i * 16;
                
                //"создаем" наше long число
                longik |= longikTmp;
            }
            Console.WriteLine(longik);
        }

        public static void Task4()
        {
            long longik;
            short shortik;
            longik = Convert.ToInt64(Console.ReadLine());
            for (int i = 0; i < 4; ++i)
            {
                //32767 - это единицы
                shortik = 32767; 

                //получаем число в первых двух байтах
                shortik &= (short)longik;

                //стираем два байта, которые прочитали
                longik >>= 16;
                Console.WriteLine(shortik);
            }
        }
    }
}
