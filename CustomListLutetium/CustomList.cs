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
                T[] _items = new T[5];
               _items.count + 1;
                itemToAdd.

                // create new array/ resize array 
                // move items over 
                // new array is now _items array
            }
            _items[count] = itemToAdd;
            count++;

        }
        public void Remove()
        {
            // implement here!
        }

        public void FindIndex()
        {
        
        }

    }
}
