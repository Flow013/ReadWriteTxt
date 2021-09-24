using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadWriteTxt
{
    // TestPullRequests
    // Написать приложение, которое считает цифры из файла in.txt,
    // выведет в консоль, отсортирует, и запишет в out.txt

    class Program
    {
        static void Main(string[] args)
        {        
            string readPath = @"C:\Temp\in.txt";
            string writePath = @"C:\Temp\out.txt";

            List<string> textRead = new List<string>();

            // Построчное чтение до конца файла из пути readPath через цикл While
            using (StreamReader sr = new StreamReader(readPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    textRead.Add(line);
                }
            }

            // Сортировка текста из файла
            List<string> writeText = textRead.OrderBy(o => o).ToList();

            // Вывод на консоль
            foreach (var item in writeText)
            {
                Console.WriteLine(item);
            }

            // Запись текста по пути writePath
            using (StreamWriter sw = new StreamWriter(writePath, false))
            {
                foreach (var item in writeText)
                {
                    sw.WriteLine(item);
                }         
            }

            Console.ReadLine();
        }
    }
}
