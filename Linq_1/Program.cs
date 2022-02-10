using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
             int[] intArray = new int[] { 1, 2, 3 };
            IEnumerable<int> ints = intArray.Select(i => i);

            foreach (int i in ints)
                Console.WriteLine(i);

            // Изменить элемент, в источнике данных
            intArray[0] = 5;

            Console.WriteLine("---------");

            foreach (int i in ints)
                Console.WriteLine(i);
        
        }
    }
}
