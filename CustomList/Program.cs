using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> newList = new CustomList<int>();
            newList.Add(3);
            newList.Add(2);
            newList.Add(5);
            newList.Add(4);
            newList.Add(5);
            newList.Add(7);
            newList.Remove(5);
            newList.Remove(3);
            newList.Remove(7);
            Console.WriteLine(newList.Count);
            Console.ReadLine();

            Console.WriteLine(newList.ToString());
            Console.ReadLine();


        }
    }
}
