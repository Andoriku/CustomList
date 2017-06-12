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
        public T this[int i]
        {
            get { return listArray[i]; }
            set { listArray[i] = value; }
        }
        public CustomList()
        {
            listArray = new T[4];
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
            T[] tempArray = new T[listArray.Length];
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

        public void ZipItUp(CustomList<T> list1, CustomList<T> list2)
        {

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
        public CustomList<T> OverloadAdditonOperator(CustomList<T> list2)
        {
            CustomList<T> NewList = new CustomList<T>();
            return NewList;
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
