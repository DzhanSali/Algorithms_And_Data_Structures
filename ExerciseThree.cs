using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS
{
    class ExerciseThree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter desired sequence of numbers. Separate them with blank spaces.\n");
            var numbList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> pos = new List<int>();
            foreach (var m in numbList)
            {
                pos = numbList.Where(m => m >= 0).ToList();

                
            }
            foreach(var k in pos)
            {
                Console.WriteLine(k);
            }
        }
    }

}
