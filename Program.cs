using System;
using System.Collections.Generic;
using System.Linq;

namespace MockAssessment2a
{
    internal class Challange
    {
        static void Main(string[] args)
        {

            // 1

            static int AddStarWarsCharacters()
            {

                string[] names = new string[4];

                names[0] = "Luke";
                names[1] = "Anakin";
                names[2] = "Yoda";
                names[3] = "Leia";

                int a = Array.IndexOf(names, "Yoda");

                return a;

            }
            Console.WriteLine(AddStarWarsCharacters());


            // 2

            Dictionary<string, int> combat = new Dictionary<string, int>();
            combat.Add("Luke", 7);
            combat.Add("Leia", 3);
            combat.Add("Anakin", 9);
            combat.Add("Yoda", 8);



            // 3

            string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus" };

            List<string> list = planets.ToList();
            list.Reverse();
            foreach (string planet in list)
            {
                Console.WriteLine(planet);
            }

            // 4

            List<int> droidList = new List<int>();
            droidList.Add(1);
            droidList.Add(2);
            droidList.Add(3);
            droidList.Add(4);
            droidList.Add(5);
            droidList.Add(6);
            droidList.Add(7);
            droidList.Add(8);
            droidList.Add(9);
            droidList.Add(10);

            List<int> evenDroid = new List<int>();
            foreach (int droid in droidList)
            {
                if (droid % 2 == 0)
                {
                    evenDroid.Add(droid);
                    return evenDroid.Average();
                }
            }







        }

    }
}
