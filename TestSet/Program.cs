using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestSet
{
    class Program
    {
        static void printCollection(HashSet<int> s)
        {
            foreach (var el in s)
                Console.Write(el + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            HashSet<string> fio = new HashSet<string>();
            SortedSet<string> subjects = new SortedSet<string>();

            StreamReader sr = new StreamReader("ege.txt");
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split();
                fio.Add(temp[0] + " " + temp[1] + " " + temp[2]);
                subjects.Add(temp[3]);
            }
            sr.Close();

            foreach(var el in fio)
                Console.WriteLine(el);
            Console.WriteLine();

            foreach(var el in subjects)
                Console.WriteLine(el);

        }
    }
}
