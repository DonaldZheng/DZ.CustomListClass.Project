using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListLutetium
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CustomList<int> runTest = new CustomList<int>();
            runTest.Add(1);
            runTest.Add(2);
            runTest.Add(3);
            runTest.Remove(2);
                 
        }

    }
}
