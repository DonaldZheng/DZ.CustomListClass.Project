﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListLutetium
{
    public class CustomList<T> : IEnumerable
    {
        //member variables
        private T[] _items; // [] array
        private int count;
        private int capacity;

        // use get and set so i am able to view or set something 
        public int Count
        {
            get
            {
                return count; //read only prop
            }
        }
        public int Capacity // nevin's comment: change the size of items above
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException("Input is out of range exception ");
                }
                return _items[index];
            }

            set
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException("Input is out of range exception ");
                }
                _items[index] = value;
            }

        }

        //constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            _items = new T[capacity];
        }

        // member methods
        public void Add(T itemToAdd)
        {
            if (count == capacity)
            {
                T[] tempList = new T[capacity *= 2]; // capacity must be x2 if array is passed 4, 8, 16 etc 
                for (int i = 0; i < count; i++)
                {
                    tempList[i] = _items[i];
                }
                _items = tempList;
            }
            _items[count] = itemToAdd;
            count++;
            // create new array/ resize array 
            // move items over 
            // new array is now _items array
        }
        public bool Remove(T itemToRemove)
        {
            T[] removeTemp = new T[capacity];
            bool isRemoved = false;
            for (int i = 0, t = 0; i < count; i++, t++)
            {
                if (_items[i].Equals(itemToRemove) && isRemoved == false)
                {
                    t--;
                    isRemoved = true;
                }
                else
                {
                    removeTemp[t] = _items[i];
                }
            }
            _items = removeTemp;
            if (isRemoved)
            {
                count--;
            }
            return isRemoved;
        }

        public override string ToString()
        {
            StringBuilder stringTemp = new StringBuilder(); // Brett said StringBuilder is okay to use
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                { 
                    stringTemp.Append(_items[i].ToString()); //Append(add) 
                }
            }
            return stringTemp.ToString();
            
            
        }

        //add two instances of a custom list class together: 10 points 
        public static CustomList<T> operator + (CustomList<T> listOne, CustomList<T> listTwo) // use "operators" to declare an operator in overload 
        {
            CustomList<T> OperatorAdd = new CustomList<T>();
            for (int i = 0; i < listOne.Count; i++)
            {
                OperatorAdd.Add(listOne[i]); // add list one index i in OperatorAdd
            }
            for (int i = 0; i < listTwo.Count; i++)
            {
                OperatorAdd.Add(listTwo[i]); // ""
            }
            return OperatorAdd;
        }

        //sub one instance of a custom list from another instance: 10 points 

        public static CustomList<T> operator - (CustomList<T> listOne, CustomList<T> listTwo) // use "operators" to declare an operator in overload 
        {
            CustomList<T> OperatorSub = new CustomList<T>();
            for (int i = 0; i < listOne.Count; i++) // reference the remove method above 
            {
                for (int t = 0; t < listTwo.Count; t++)
                {
                    if (listOne._items[i] == listTwo._items[t]) // if list are both equal
                    {
                        listTwo.Remove(t); // remove from class two subtract {1,3,5} - {2,1,6} = {3,5}
                    }
                }
            }
            return OperatorSub;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return _items[i];
            }
        }
    }

}
