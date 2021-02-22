using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListLutetium
{
    public class CustomList<T>
    {

        private T[] _items;
        private int count;
        private int capacity;

        public CustomList()
        {
            count = 0;
            capacity = 4;
            _items = new T[capacity];
        }

        public void Add(T itemToAdd)
        {
            if (count == capacity)
            {
                // create new array/ resize array 
                // move items over 
                // new array is now _items array
            }
            _items[count] = itemToAdd;
            count++;
            // write code to implement and commit every time you get something working
        }
        public void Remove()
        {
            // implement here!
        }
    }    
}
