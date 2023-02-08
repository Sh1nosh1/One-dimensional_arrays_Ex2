using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_dimensional_arrays_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.
            //Заполнить одномерный массив случайным образом, подсчитать кол-во отрицательных элементов.

            /*Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];                        //С конструктором new
            Random rand = new Random();                      //Заполнили случайным образом
            int i;
            for (i = 0; i < array.Length; i++)               //Заполнение и вывод
            {
                array[i] = rand.Next(-15, 15);
                Console.WriteLine($"Array[{i}] = {array[i]}");
            }
            int count = 0;                                //Подсчёт количества
            for (i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    count += 1;
                }
            }
            foreach(int elem in array)
            {
                if (elem < 0)
                {
                    count += 1;

                }
            }
            Console.WriteLine($"Кол-во отрицательных элементов: {count}");*/


            //Задача 2.
            //В одномерном массиве значения всех элементов увеличить в 2 раза.

            /*int[] array = {-5, 5,-6, 6,-7, 7};
            int i;
            for (i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
                Console.WriteLine($"Array[{i}] = {array[i]}");
            }
            foreach(int elem in array)
            {
                Console.Write($"{elem}\t");
            }*/


            Console.ReadKey();



        }
    }
}
