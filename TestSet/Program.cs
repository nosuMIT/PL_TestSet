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
             Stack<string> mess = new Stack<string>();

             StreamReader sr = new StreamReader("messenges_vk.txt");
             while (!sr.EndOfStream)
             {
                 string temp = sr.ReadLine();
                 mess.Push(temp);
             }
             sr.Close();

             while (mess.Count > 0)
             {
                 string[] temp = mess.Pop().Split();
                 string f = temp[0] + temp[1];
                if (!fio.Contains(f))
                {
                    Console.WriteLine(string.Join(" ", temp));
                    fio.Add(f);
                }
             }

        }
    }
}
