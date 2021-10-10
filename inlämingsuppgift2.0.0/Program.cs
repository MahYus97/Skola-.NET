using System;

namespace inlämingsuppgift2._0._0
{
    internal class Program
    {
        public static System.Collections.Generic.List<Person> People { get => People; set => People = value; }

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void AddPerson()
        {
            Person person = new Person();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Address 1: ");
            string[] addresses = new string[2];
            addresses[0] = Console.ReadLine();
            Console.Write("Enter Address 2 (Optional): ");
            addresses[1] = Console.ReadLine();
            person.Email = addresses;

            People.Add(person);
        }
    }
}