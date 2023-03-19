using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterviewProblems.Hashing
{
    internal class Hash
    {
        /// <summary>
        /// Given an integral array of size n, find all the elements that appear more than [n/3] times
        /// </summary>
        /// <param name="array"></param>
        public static void FindMajorityElement(int[] array)
        {
            if(array.Length == 0)
                return;
            Dictionary<int,int> hash = new();
            int maxRequest = array.Length / 3;
            for (int i = 0; i < array.Length; i++)
            {
                int key = array[i];
                if (hash.ContainsKey(key))
                    hash[key]++;
                else
                    hash[key] = 1;
            }
            Console.WriteLine("Most appeared Elements :");

            foreach (KeyValuePair<int,int> item in hash)
            {
                if(item.Value > maxRequest)
                    Console.Write(item.Key + "[" + item.Value + "]");
            }
        }
        /// <summary>
        /// Find the union of two arrays
        /// </summary>
        /// <param name="array"></param>
        /// <param name = "array2" ></ param >
        public static void FindUnionOf2Arrays(int[] array1, int[] array2)
        {
            if(array1.Length == 0 || array2.Length == 0) return;
            HashSet<int> myMap = new HashSet<int>(); //hashset used to store unique values
            for(int i = 0; i<array1.Length; i++)
            {
                int key = array1[i];
                myMap.Add(key);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                int key = array2[i];
                myMap.Add(key);
            }
            Console.WriteLine("Union of two Arrays :");
            foreach(var item in myMap)
            {
                Console.Write(item + ", ");
            }
        }

        /// <summary>
        /// Find the intersection of two arrays
        /// </summary>
        /// <param name="array1"></param>
       ///  <param name = "array2" ></ param >
        public static void FindIntersectionOf2Arrays(int[] array1, int[] array2)
        {
            HashSet<int> map = new HashSet<int>();
            for(int i = 0; i < array1.Length; i++)
            {
                map.Add(array1[i]);
            }
            Console.WriteLine("Interaction Of Two Arrays: ");
            for(int i = 0; i< array2.Length; i++)
            {
                if (map.Contains(array2[i]))
                {
                    Console.Write(array2[i] + ", ");
                    map.Remove(array2[i]);
                }
            }

        }

        /// <summary>
        /// Find Itinerary from Tickets
        /// </summary>
        
        public static void FindItinerayFromTickets()
        {
            Dictionary<string, string> tickets = new Dictionary<string, string>
            {
                { "Karachi", "Hyderabad" },
                { "Shahdadkot", "Dadu" },
                { "Larkana", "Karachi" },
                { "Dadu", "Larkana" }
            };
            string startingCity = "";
            foreach(var fromCity in tickets.Keys)
            {
                if (!tickets.Values.Contains(fromCity))
                {
                    startingCity = fromCity;
                }
            }
            Console.WriteLine("Itineray From Tickets: ");
            Console.Write(startingCity + "-->");
            while(tickets.ContainsKey(startingCity))
            {
                Console.Write(tickets[startingCity] + "-->");
                startingCity = tickets[startingCity];
            }

        }


    }
}
