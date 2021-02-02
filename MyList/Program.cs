using System;
using System.Collections.Generic;

namespace MyList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyList<string> mylist = new MyList<string>();

            mylist.Add("Çağkan");
            mylist.Add("Selin");
            mylist.Add("Ece");

            Console.WriteLine($"Dizinin şu anki boyutu: {mylist.Count}");

            foreach (string item in mylist.GetAll())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--------------------\n");

            mylist.Add("Timuçin");

            Console.WriteLine($"Dizinin şu anki boyutu: {mylist.Count}");


            foreach (string item in mylist.GetAll())
            {
                Console.WriteLine(item);
            }

        }
    }
}