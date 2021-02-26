using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListLutetium
{
    public class CustomList<T>
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
        public int Capacity
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
                    throw new IndexOutOfRangeException("Input is out of range exception ");
                }
                return _items[index];
            }

            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Input is out of range exception ");
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
        public void Remove(T itemToRemove) // still not completed 
        {
            T[] removeTemp = new T[capacity];
            for (int i = 1; i < count; i++) // needs the ability to add so you can remove? 
            {
                if (_items[i].Equals(itemToRemove))
                {
                    for (int t = 0; t < count; t++)
                    {
                        _items[t] = _items[t + 1];
                    }
                    count--;   
                }
                else
                {
                    removeTemp[i] = _items[i];
                }
                _items = removeTemp;


            }
        }
    }
}
