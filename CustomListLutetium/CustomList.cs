using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListLutetium
{
    public class CustomList<T>
    {

        private T[] _items; // [] array

        // use get and set??
        private int Count
        {
            get
            {
                return Count;
            }

            set
            {
                Count = value;
            }
        }
        private int Capacity
        {
            get
            {
                return Capacity;
            }
        }

        public CustomList()
        {
            Count = 0;
            Capacity = 4;
            _items = new T[Capacity];
        }

        public void Add(T itemToAdd)
        {
            if (Count == Capacity)
            {
                // create new array/ resize array 
                // move items over 
                // new array is now _items array
            }
            _items[Count] = itemToAdd;
            Count++;

        }
        public void Remove()
        {
            // implement here!
        }

    }
}
