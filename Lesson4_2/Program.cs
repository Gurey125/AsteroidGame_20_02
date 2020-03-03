using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() ;


            Random rnd = new Random();
            

            for (int i = 0; i < 100; i++)
            {
                myList.Add(rnd.Next(1,25));
            }

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            
            Dictionary<int, int> myD = new Dictionary<int, int>();


            foreach (var item in myList)
            {
                if (myD.ContainsKey(item))
                {
                    myD[item]++;
                }
                else
                {
                    myD.Add(item, 1);
                }
            }

            foreach (var item in myD)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


        }
    }
}
