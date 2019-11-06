using System;

namespace exshopinglist
{
    class Program
    {
        static void Main(string[] args)
        {
            //Poenimekirja loomine 
            Console.WriteLine("Enter the list of supplies separated by comma: ");
            string userList = Console.ReadLine();

            string[] shoppingList = userList.Split(new char[] {',',' '}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < shoppingList.Length; i++)
            {
                Console.WriteLine($"Item {i+1}: {shoppingList[i]} ");
            }

        }
    }
}