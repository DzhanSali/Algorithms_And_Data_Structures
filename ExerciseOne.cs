using System;
using System.Collections.Generic;

namespace ADS
{
    class ExerciseOne
    {
        //N 1


        static List<int> Obed(List<int> one, List<int> two)
        {
            List<int> dinenie = new List<int>();
            dinenie.AddRange(one);
            foreach (var num in two)
            {
                if (!dinenie.Contains(num))
                { dinenie.Add(num); }
            }
            return dinenie;
        }


        static List<int> Sec(List<int> one, List<int> two)
        {
            List<int> chenie = new List<int>();
            foreach (var jum in one)
            {
                if (two.Contains(jum) && one.Contains(jum))
                {
                    chenie.Add(jum);
                }
            }
            return chenie;
        }


        public static void PrintList(List<int> list)
        {
            Console.Write("( ");
            foreach (var num in list)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine(")");
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Please, enter 5 numbers into each of the lists.\n\n");

            List<int> one = new List<int>();
            for (int l = 0; l < 5; l++)
            {
                string k = Console.ReadLine();
                string[] numsInOne = k.Split("  ");
                int nnn;
                foreach (string s in numsInOne)
                {
                    if (Int32.TryParse(s, out nnn))
                        one.Add(nnn);
                }
            }
            Console.Write("\n\nList One contains the following items =>   ");
            PrintList(one);



            List<int> two = new List<int>();
            for (int u = 0; u < 5; u++)
            {
                string k = Console.ReadLine();
                string[] numsInTwo = k.Split("  ");
                int nnn;
                foreach (string s in numsInTwo)
                {
                    if (Int32.TryParse(s, out nnn))
                        two.Add(nnn);
                }
            }
            Console.Write("\n\nList Two contains the following items =>   ");
            PrintList(two);


            List<int> dinenie = Obed(one, two);


            Console.Write("\nWhen we unite both of the lists, we get =>   ");
            PrintList(dinenie);


            List<int> chenie = Sec(one, two);


            Console.Write("\nWhen we apply intersection onto the lists, we get =>   ");
            PrintList(chenie);
        }
    }
}
