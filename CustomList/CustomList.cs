﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        public int count;
        public CustomList()
        {

        }

        public void AddToList(T newItem)
        {

        }
        public void SubtractFromList()
        {

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
        public void CountList(CustomList<T> list)
        {
        
        }
        public void ConcatList()
        {

        }

    }
}
