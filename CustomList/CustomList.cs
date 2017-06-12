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
        private T[] listArray;
        public T[] item;
        public CustomList()
        {
            listArray = new T[4];
        }

        public void AddToList(T item)
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
                T[] tempArray = new T[listArray.Length + 2];
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
        public T[] SubtractFromList(T item)
        {
            return listArray;
        }

        public void ZipItUp(CustomList<T> list1, CustomList<T> list2)
        {

        }
        public void IderateTheList()
        {

        }
        public override string ToString()
        {
            string newString = "the list";

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
