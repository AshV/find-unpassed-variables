using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLValidator1
{
    class FindDistinct
    {
        static void Main()
        {
            // List with duplicate elements.
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(3);
            list.Add(4);
            list.Add(4);
            list.Add(4);

            foreach (int value in list)
            {
                Console.WriteLine("Before: {0}", value);
            }

            // Get distinct elements and convert into a list again.
            list = list.Distinct().ToList();

            foreach (int value in list)
            {
                Console.WriteLine("After: {0}", value);
            }
            Console.Read();
        }
    }
}