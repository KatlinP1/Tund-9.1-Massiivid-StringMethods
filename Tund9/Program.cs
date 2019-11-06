using System;
using System.Reflection;

namespace Tund9
{
    class Program
    {
        static void Main(string[] args)
        {
            //nimede kordus massiivis, mitu korda nimi massiivis kordub

            string[] names = new string[5];
            names[0] = "Tiina";
            names[1] = "Anna";
            names[2] = "Kerstin";
            names[3] = "Anna";
            names[4] = "Jack";

            string searchWord = "Anna";
            int counter = 0;

            CountNames(names, searchWord);

            /*foreach (string name in names)
            {
                if (name == searchName)
                {
                    counter++; 
                }
            }*/

            //Console.WriteLine($"There are {counter} {searchName}s in the array");

        }
        public static  void CountNames(string[] searchArray, string searchWord)
        {
            int counter = 0;
            foreach (string word in searchArray)
            {
                if (word == searchWord)
                {
                    counter++;
                }
            }
            Console.WriteLine($"There are {counter} {searchWord}s in the array.");
        }
    }
}