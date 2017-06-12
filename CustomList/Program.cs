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
            newList.AddToList(3);
            newList.AddToList(2);
            newList.AddToList(5);
            newList.AddToList(4);
            newList.AddToList(5);
            newList.AddToList(7);
            newList.SubtractFromList(5);
            newList.SubtractFromList(3);
            newList.SubtractFromList(7);
            Console.WriteLine(newList.Count);
            Console.ReadLine();


        }
    }
}
