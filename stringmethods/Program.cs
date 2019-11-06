using System;

namespace stringmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trim()-trimmib ainult tühikuid,

            string fullname = "Kätlin Paju ";
            Console.WriteLine($"Full name length before trim: {fullname.Length}");

            fullname = fullname.Trim();
            Console.WriteLine($"Full name length after trim: {fullname.Length}");

            ////IndexOf()- näitab tühiku asukohta 
            //Console.WriteLine($"{fullname[0]}");

            int indexOfSpace = fullname.IndexOf(" ");
            Console.WriteLine($"The position of the space is {indexOfSpace}");

            //Substrings ()- väljaarvatud mingi asi, kui soovid midagi välja arvata. 

            string firstName = fullname.Substring(0, indexOfSpace);
            Console.WriteLine($"Name: {firstName}");

            string lastName = fullname.Substring(indexOfSpace + 1);
            Console.WriteLine($"Name: {lastName}");

            //Split()- poolitab originaal stringi 

            string[] personalData = fullname.Split(" ");
            foreach (string value in personalData)
            {
                Console.WriteLine($"Value from personalData: {value}");
            }


        }
    }
}