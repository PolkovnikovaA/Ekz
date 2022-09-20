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
            Console.Write("");

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
            Console.ReadKey();
        }
    }

    public class Test
    {
        public string s;

        public void Vvod()
        {
            StreamReader f = new StreamReader("Test.txt");
            while(!f.EndOfStream)
            {
                s = f.ReadLine();
                Console.WriteLine();
            }
            f.Close();

        }

        public void Vivod()
        {
            string[] lin = new string[] { s };
            File.WriteAllLines("1.csv", lin);
        }
    }
}
