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
                new TextWriterTraceListener("Debug.txt")
            };
            Debug.Listeners.AddRange(listeners);
            Debug.WriteLine("Программа завершена без ошибок"); //Вывод в файл
            Debug.Flush();

            Console.Write("Введите количество работ N: ");
            int n = Convert.ToInt32(Console.ReadLine());    //Общее количество работ
            int i;
            int[] pov1 = new int[5];
            int[] pov2 = new int[5];
            for (i = 0; i < n; i++)
            {
                Console.Write("Ввод элементов: ");
                pov1[i] = int.Parse(Console.ReadLine());
                pov2[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Подсчёт дней: ");
            for (i = 0; i < n; i++)

            Console.Write("Критический путь: ");
            for (i = 0; i < n; i++)
                







            
            

            
            Console.ReadKey();
        }
    }

    

    public class Test
    {
        public void Sum(int x, int y)   //Метод для юнит теста на сумму
        {
            int sum = x + y;
        }

        public string s;

        public void Vvod()  //Метод для ввод в файл
        {
            StreamReader f = new StreamReader("Test.txt");
            while(!f.EndOfStream)
            {
                s = f.ReadLine();
                Console.WriteLine();
            }
            f.Close();

        }

        public void Vivod() //Метод для вывода
        {
            string[] lin = new string[] { s };
            File.WriteAllLines("1.csv", lin);
        }
    }

    public class Mat_model
    {
        
        public void Kr_p()
        {

        }
    }
}
