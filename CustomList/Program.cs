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
            CustomList<int> testList = new CustomList<int>();
            newList.Add(3);
            newList.Add(2);
            newList.Add(5);
            newList.Add(4);
            newList.Add(5);
            newList.Add(7);
            newList.Remove(5);
            newList.Remove(3);
            newList.Remove(7);
            testList.Add(8);
            testList.Add(3);
            testList.Add(2);
            testList.Add(6);
            testList.Add(9);
            CustomList<int> UpdatedList = newList + testList;
            Console.WriteLine(UpdatedList.ToString());
            Console.WriteLine(newList.Count);
            Console.ReadLine();
           

        }
    }
}
