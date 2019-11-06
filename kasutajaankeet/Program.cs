using System;

namespace kasutajaankeet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kasutaja sisetab nime (ees ja perekonna) ning vanuse/sünniaasta.
            Console.WriteLine("Hello! Please enter your name (first and last) and year of birth:");
            string userData = Console.ReadLine();
            GetUserData(userData);
        }
        public static void GetUserData(string userData)
        {
            string[] userDataList = userData.Split(new char[]{',',' '}, StringSplitOptions.RemoveEmptyEntries);
            
            Console.WriteLine($"First name: {userDataList[0]}");
            Console.WriteLine($"Last name: {userDataList[1]}");
            Console.WriteLine($"Age: {2019-int.Parse(userDataList[2])}");
            
        }
    }
}