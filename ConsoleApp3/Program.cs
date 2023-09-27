using System;

namespace _16 //в массиве из тысячи элементов со значениями от 1 до 6 найти самую длинную цепочку повторяющихся элементов.
              //Вывести значения элементов, длину цепочки,и начальный индекс цепочки
{
    class Program
    {
        const int n = 1000;
        static void Main()
        {

            int[] array = new int[n];
            Random rand = new Random();
            //for (int i = 0; i < n; i++)
            //    Console.Write("{0,4}", i);
            //Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(1, 7);
                //Console.Write("{0,4}", array[i]);
            }
            int N = 1, index = 0, value = 0, Nmax = 1, valuemax = 0, indexmax = 0;
            for (int i = 0; i < n - 1; i++)
                if (array[i] == array[i + 1])
                {
                    if (N == 1)
                        index = i;
                    value = array[i];
                    N++;
                }
                else
                {
                    if (N > Nmax)
                    {
                        Nmax = N;
                        valuemax = value;
                        indexmax = index;
                    }
                    N = 1;
                }
            Console.WriteLine("Значение повторяющегося элемента: {0}\nДлина цепочки: " +
                "{1}\nНачальный индекс цепочки: {2}", valuemax, Nmax, indexmax);
            {
                Console.WriteLine("Esli hotite povtorit vvod, vvedite 1, inache lubuyu dr cifru");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1) Main();
                return;
            }
        }
    }
}
