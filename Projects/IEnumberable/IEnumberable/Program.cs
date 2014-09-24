using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumberable
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> ie = from value in Enumerable.Range(0, 12) select value;
            foreach (int value in ie)
            {
                Console.WriteLine(value);
            }
            double average = ie.Average() ;
            Console.WriteLine(average);
            List<int> list = ie.ToList();
            int[] array = ie.ToArray();
            Console.ReadLine();

            Display(new List<bool> { true, false, true });
        }
        static void Display(IEnumerable<bool> argument)
        {
            foreach (bool value in argument)
                Console.WriteLine(value);
        }

    }
}
