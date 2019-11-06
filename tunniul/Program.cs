using System;

namespace tunniul
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kasutaja sisestab nime ja vanuse, millest tegib programm, kus teeb kasutaja nime pooleks. 


            Console.WriteLine("Hello! Please enter name (first and last name): ");
            string fullName = Console.ReadLine();
            GetArrayFromString(fullName);
        }

        public static void GetArrayFromString(string stringTosplit)
        {
            string[] personalData = stringTosplit.Split(" ");
            Console.WriteLine($"First name: {personalData[0]}");
            Console.WriteLine($"Last name: {personalData[1]}");
        }
    }
}