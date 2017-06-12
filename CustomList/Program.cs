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
            CustomList<bool> newList = new CustomList<bool>();
            newList.AddToList(true);
            newList.AddToList(true);
            newList.AddToList(true);
            newList.AddToList(true);
            newList.AddToList(true);
            newList.AddToList(true);

            Console.WriteLine(newList.Count);
            Console.ReadLine();


        }
    }
}
