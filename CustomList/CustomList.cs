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
        private int capacity = 4;
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
            if (count < 4)
            {
                T[] tempArray = new T[listArray.Length];
                for (int i = 0; i < listArray.Length;)
                {
                    tempArray[i] = listArray[i];
                    i++;
                }

                for (int i = 0; i <= tempArray.Length;)
                {
                    if (count == 0)
                    {
                        tempArray[i] = item;
                        listArray = tempArray;
                        count++;
                        i = tempArray.Length + 1;
                    }
                    else if (count == i)
                    {
                        tempArray[i] = item;
                        listArray = tempArray;
                        count++;
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
                }

                for (int i = 0; i <= tempArray.Length;)
                {
                    if (count == i)
                    {
                        tempArray[i] = item;
                        listArray = tempArray;
                        count++;
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
            T[] tempArray = new T[listArray.Length-1];
            tempCount = 0;
            for (int i = 0; i < Count;)
            {
                if (listArray[i].Equals(item))
                {
                    count--;
                    i = count + 1;
                    
                }
                else
                {
                    tempArray[i] = listArray[i];
                    tempCount++;
                    i++;
                }
            }

            for (int i = tempCount; i < listArray.Length - 1;)
            {
                tempArray[i] = listArray[i + 1];
                i++;

            }
            listArray = tempArray;
        }

        //public T[] ZipItUp(CustomList<T> list2)
        //{
        //    T[] tempList = new T[listArray.Length];

        //    for (int i=0; i < listArray.Length;)
        //    {
        //        tempList[i]= tempList[i] + listArray[i];
        //        tempList[i + 1].Equals(list2[i]);

        //    }
        //    listArray = tempList;
        //    return listArray;
        //}
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
        public static CustomList<T> operator+(CustomList<T> theList, CustomList<T> list2)
        {
            T[] NewArray = new T[theList.Count+ list2.Count];
            theList.count = 0;
            theList.tempCount = 0;
            for (int i =0 ; i < theList.listArray.Length ;)
            {
                NewArray[i] = theList.listArray[i];
                theList.tempCount++;
                theList.count++;
                i++;
            }
            for (int i = theList.tempCount; i < list2.listArray.Length + theList.listArray.Length;)
            {
                NewArray[i] = list2[i-theList.TempCount];
                theList.count++;
                i++;
            }
            theList.listArray = NewArray;
            return theList;
        }
        public CustomList<T> OverloadSubtractionOperator(CustomList<T> list2)
        {
            CustomList<T> NewList = new CustomList<T>();
            return NewList;
        }

        public void ConcatList()
        {

        }

    }
}
