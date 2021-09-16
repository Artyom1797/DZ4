using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4
{
    //Губарь Артём
    class MyArr
    {
        int[] arr;
        public MyArr(int[] arr)
        {
            this.arr = arr;
        }
        /// <summary>
        /// Создать массив, зная его размер, начальное значение и шаг
        /// </summary>
        /// <param name="a">Размер массива</param>
        /// <param name="b">Значение первого элемента массива</param>
        /// <param name="c">Шаг массива</param>
        public MyArr (int a, int b, int c)
        {
            arr[0] = b;
            for(int i = 1; i < a; i++)
            {
                arr[i] = b + a * i;
            }

        }
        /// <summary>
        /// Создать случайный массив
        /// </summary>
        /// <param name="number">Размер массива</param>
        public MyArr (int number)
        {
            Random random = new Random();
            arr = new int[number];
            for (int i = 0; i < number; i++)
            {
                int numeric = random.Next(-10000, 10001);
                arr[i] = numeric;
            }
        }
        /// <summary>
        /// Распечатать массив
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
        }
        /// <summary>
        /// Количество пар, в которых хотя бы один элемент делится на 3
        /// </summary>
        /// <param name="arr">Массив</param>
        public static void Couples (int[] arr)
        {
            
            int a = 0;
            int b = 1;
            int sum = 0;
            for (int i = 0; i < arr.Length/2; i++)
            {
                if (arr[a] % 3 == 0 && arr[b] % 3 != 0)
                {
                    sum++;
                }
                if (arr[a] % 3 != 0 && arr[b] % 3 == 0)
                {
                    sum++;
                }
                a += 2;
                b += 2;
            }

                Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3 равно {sum}");
                Console.ReadKey();
            
        }
        /// <summary>
        /// Сумма элементов массива
        /// </summary>
        /// <param name="arr">Массив</param>
        public static void Sum(int[]arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
                
            Console.WriteLine($"Сумма элементов массива равна {sum}");
        }
        /// <summary>
        /// Меняет знаки элементов массива
        /// </summary>
        /// <param name="arr">Массив</param>
        public static void Inverse (int[] arr)
        {
            int[] arr1 = arr;
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = -arr1[i];
            }
            Console.WriteLine($"Новый массив с изменнёнными знаками - {arr1}");
        }
        /// <summary>
        /// Умножает каждый элемент массива на определённое число
        /// </summary>
        /// <param name="arr">Массив</param>
        /// <param name="a">Множитель</param>
        public static void Multi (int[] arr, int a)
        {
            int[] arr1 = arr;
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] *= a;
            }
            Console.WriteLine($"Произведение элементов массива {arr} на множитель {a} равно {arr1}");
        }
        /// <summary>
        /// Показывает количество максимальных элементов массива
        /// </summary>
        /// <param name="arr">Массив</param>
        public static void MaxCount (int[] arr)
        {
            int[] arr1 = arr;
            Array.Sort(arr1);
            int max = arr1[arr1.Length - 1];
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] == max)
                {
                    sum++;
                }
            }
            Console.WriteLine($"Количество максимальных элементов равно {sum}");
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            int TaskNumber = int.Parse(Console.ReadLine());
            switch(TaskNumber)
            {
                case 1:
                    {
                        Task1();
                        break;
                    }
                case 2:
                    {
                        Task2();
                        break;
                    }
                case 3:
                    {
                        Task3();
                        break;
                    }
            }
        }
        static void Task1()
        { 
            Console.Title = "Работа с одномерными массивами";
            int[] arr = new int[20];
            Console.WriteLine("Введите любые 20 чисел от -10000 до 10000 включительно");
            for (int i = 0; i < 20; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            int a = 0;
            int b = 1;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (arr[a] % 3 == 0 && arr[b] % 3 != 0)
                {
                    sum++;
                }
                if (arr[a] % 3 != 0 && arr[b] % 3 == 0)
                {
                    sum++;
                }
                a += 2;
                b += 2;
            }
                Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3 равно {sum}");
                Console.ReadKey();
             
        }
        static void Task2()
        {
            Console.WriteLine("Укажите размер массива");
            int a = int.Parse(Console.ReadLine());
            MyArr myarray = new MyArr(a);
            int[] f = { 2, 3, 5, 6 };
            MyArr.Sum(f);
            myarray.Print();
            Console.WriteLine(myarray);
            Console.ReadKey();
        }
        static void Task3()
        {

        }

        
    }
}
