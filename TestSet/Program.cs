using System;
using System.Collections.Generic;
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
            HashSet<int> a = new HashSet<int>(new int[] { 2, 5, 1, 6 });
            HashSet<int> b = new HashSet<int>(new int[] { 8, 7, 6, 2 });
            printCollection(a);
            printCollection(b);

            a.UnionWith(b);
            printCollection(a);
            //Объединение множеств a => 2 5 1 6 8 7 

            a = new HashSet<int>(new int[] { 2, 5, 1, 6 });
            a.SymmetricExceptWith(b);
            printCollection(a);
            //Симметрическая разность a => 5 1 8 7

            a = new HashSet<int>(new int[] { 2, 5, 1, 6 });
            a.ExceptWith(b);
            printCollection(a);
            //Разность
        }
    }
}
