using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Polkovnikova
{
    /// <summary>
    /// Основной класс приложения
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Стартовый метод приложения
        /// </summary>
        /// <param name="args">
        /// Аргументы, передаваемые в качестве параметров
        /// </param>
        static void Main(string[] args)
        {
            Test test = new Test();
            test.Vvod();
            test.Vivod();
            TextWriterTraceListener[] listeners = new TextWriterTraceListener[]
            {
                new TextWriterTraceListener("Debug.txt")    //Создание файла Debug.txt
            };
            Debug.Listeners.AddRange(listeners);
            Debug.WriteLine("Программа завершена без ошибок"); //Вывод в файл Debug.txt
            Debug.Flush();
            try
            {
                Console.Write("Введите продолжительность дней работы 1-2: ");
                int q12 = Convert.ToInt32(Console.ReadLine());  //3
                Console.Write("Введите продолжительность дней работы 1-3: ");
                int q13 = Convert.ToInt32(Console.ReadLine());  //7
                Console.Write("Введите продолжительность дней работы 1-4: ");
                int q14 = Convert.ToInt32(Console.ReadLine());  //1
                Console.Write("Введите продолжительность дней работы 2-4: ");
                int q24 = Convert.ToInt32(Console.ReadLine());  //8
                Console.Write("Введите продолжительность дней работы 3-4: ");
                int q34 = Convert.ToInt32(Console.ReadLine());  //9
                Console.Write("Введите продолжительность дней работы 4-5: ");
                int q45 = Convert.ToInt32(Console.ReadLine());  //4
                Console.Write("Введите продолжительность дней работы 4-6: ");
                int q46 = Convert.ToInt32(Console.ReadLine());  //2
                Console.Write("Введите продолжительность дней работы 5-6: ");
                int q56 = Convert.ToInt32(Console.ReadLine());  //6
                Console.Write("Введите продолжительность дней работы 6-7: ");
                int q67 = Convert.ToInt32(Console.ReadLine());  //3


            }
            catch(Exception)
            {
                Console.WriteLine("Были введены не корректные данные!");
                Debug.WriteLine("Программа завершена с ошибками!");
            }

            
            Console.ReadKey();
        }
    }

    

    public class Test
    {
        public string s;

        public void Vvod()  //Метод для ввод данных в файл Test.txt
        {
            StreamReader f = new StreamReader("Test.txt");
            while(!f.EndOfStream)
            {
                s = f.ReadLine();
                Console.WriteLine();
            }
            f.Close();

        }

        public void Vivod() //Метод для вывода данных в файл 1.csv
        {
            string[] lin = new string[] { s };
            File.WriteAllLines("1.csv", lin);
        }
    }

    public class Mat_model
    {
        public void Sum(int x, int y)   //Метод для юнит-теста на сумму
        {
            int sum = x + y;
        }
    }
}
