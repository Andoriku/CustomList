using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private int count;
        public int Count { get { return count; } }
        private int tempCount;
        public int TempCount { get { return tempCount; } }
        private T[] listArray;
        public T[] item;
        private int capacity = 1;
        public T this[int i]
        {
            get { return listArray[i]; }
            set { listArray[i] = value; }
        }
        public CustomList()
        {
            listArray = new T[capacity];
        }

        public void Add(T item)
        {
            if (count < 1)
            {
                T[] tempArray = new T[listArray.Length];
                for (int i = 0; i < listArray.Length;)
                {
                    tempArray[i] = listArray[i];
                    i++;
                    capacity = i;
                }

                for (int i = 0; i <= tempArray.Length;)
                {
                    if (count == 0)
                    {
                        tempArray[i] = item;
                        listArray = tempArray;
                        count++;
                        capacity = i + 1;
                        i = tempArray.Length + 1;
                    }
                    else if (count == i)
                    {
                        tempArray[i] = item;
                        listArray = tempArray;
                        count++;
                        capacity = i + 1;
                        i = tempArray.Length + 1;
                    }
                    else
                    {
                        i++;
                    }

                }

            }
            else
            {
                T[] tempArray = new T[listArray.Length + 1];
                for (int i = 0; i < listArray.Length;)
                {
                    tempArray[i] = listArray[i];
                    i++;
                    capacity = i + 1;
                }

                for (int i = 0; i <= tempArray.Length;)
                {
                    if (count == i)
                    {
                        tempArray[i] = item;
                        listArray = tempArray;
                        count++;
                        capacity = i + 1;
                        i = tempArray.Length + 1;
                    }
                    else
                    {
                        i++;
                    }

                }
            }
        }
        public void Remove(T item)
        {
            T[] tempArray = new T[listArray.Length - 1];
            tempCount = 0;
            for (int i = 0; i < Count;)
            {
                if (listArray[i].Equals(item))
                {
                    count--;
                    capacity = i;
                    i = count + 1;

                }
                else
                {
                    tempArray[i] = listArray[i];
                    tempCount++;
                    capacity = i + 1;
                    i++;
                }
            }

            for (int i = tempCount; i < listArray.Length - 1;)
            {
                tempArray[i] = listArray[i + 1];
                i++;
                capacity = i + 1;

            }
            listArray = tempArray;
        }

        public CustomList<T> ZipItUp(CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();           
            int listLength=0;
            if (listArray.Length < list2.listArray.Length)
            {
                 listLength = listArray.Length;
            }
            else if (listArray.Length > list2.listArray.Length)
            {
                listLength = list2.listArray.Length;
            }
            else
            {
                listLength = listArray.Length;
            }

            T[] tempList = new T[listLength * 2];

            for (int i = 0; i < listLength;)
            {
                tempList[i] = listArray[i];
                tempList[i + 1] = list2[i];
                i++;
            }
            newList.listArray = tempList;
            return newList;
        }
        public void IderateTheList()
        {

        }
        public override string ToString()
        {

            string newString = null;
            string stringValue;
            foreach (T i in listArray)
            {
                if (i is string)
                {
                    newString += i;
                }
                else
                {
                    stringValue = i.ToString();
                    newString += stringValue;
                }
            }
            return newString;
        }
        public static CustomList<T> operator +(CustomList<T> theOldList, CustomList<T> list2)
        {
            T[] tempArray = new T[theOldList.capacity + list2.capacity];
            theOldList.count = 0;
            theOldList.tempCount = 0;
            for (int i = 0; i < theOldList.capacity;)
            {
                tempArray[i] = theOldList.listArray[i];
                theOldList.tempCount++;
                theOldList.count++;
                i++;
            }
            for (int i = theOldList.tempCount; i < list2.capacity + theOldList.capacity;)
            {
                tempArray[i] = list2[i - theOldList.TempCount];
                theOldList.count++;
                i++;
            }
            theOldList.listArray = tempArray;
            return theOldList;
        }
        public static CustomList<T> operator -(CustomList<T> theOldList, CustomList<T> list2)
        {
            T[] newArray = new T[theOldList.capacity + list2.capacity];
            foreach (T o in list2.listArray)
            {
                int i = 0;
                int n = 0;
                do
                {
                    if (theOldList.capacity < list2.capacity)
                    {
                        i = theOldList.capacity + 1;
                    }
                    else if (theOldList.listArray[i] == null)
                    {
                        theOldList.capacity--;
                        i++;
                    }
                    else if (theOldList.listArray[i].Equals(o))
                    {
                        theOldList.capacity--;
                        i++;
                    }
                    else
                    {
                        newArray[n] = theOldList.listArray[i];
                        n++;
                        i++;
                    }
                }
                while (i <= theOldList.capacity);
                theOldList.listArray = newArray;
            }


            int e = theOldList.listArray.Length-1;
            do
            {
                if (theOldList.listArray[e].Equals(0) || theOldList.listArray[e] == null)
                {
                    theOldList.Remove(theOldList.listArray[theOldList.listArray.Length - 1]);
                    e--;
                    theOldList.capacity--;
                }
                else
                {
                    e--;
                }
            } while (e >= theOldList.capacity-1);
            return theOldList;
        }

    }
}
