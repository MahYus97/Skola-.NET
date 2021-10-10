using System;
using System.Collections.Generic;

namespace inlämning_2

{
    public class contactlist
    {
        //mina olika var
        private string firstname;

        private string lastname;
        private int age;
        private string alias;
        private string email;
        private string favoritdjur;
        private string hobby;
        private string favoritMat;
        private string favoritMusik;

        public contactlist(string firstname, string lastname, int age, string alias, string email, string favoritdjur, string hobby,
            string favoritMat, string favoritMusik)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.alias = alias;
            this.email = email;
            this.favoritdjur = favoritdjur;
            this.hobby = hobby;
            this.favoritMat = favoritMat;
            this.favoritMusik = favoritMusik;
        }

        public string Firstname

        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Favoritdjur
        {
            get { return favoritdjur; }
            set { favoritdjur = value; }
        }

        public string Hobby
        {
            get { return hobby; }
            set { hobby = value; }
        }

        public string FavoritMat
        {
            get { return favoritMat; }
            set { favoritMat = value; }
        }

        public string FavoritMusik
        {
            get { return favoritMusik; }
            set { favoritMusik = value; }
        }
    }

    internal class Program

    {  // början av programmet
        private static List<contactlist> contactlist = new List<contactlist>();

        private static void Main(string[] args)
        {
            while (!Login())
            {
                Login();
            }

            Contactlist();

            while (!Menu())
            {
                Menu();
            }
        }

        private static bool Login()
        {
            if (true)
            {
                Console.Clear();

                return true;
            }
        }

        private static void Contactlist()
        {
            // kontakt listan
            contactlist.Add(new contactlist("Mahamed Abdirahman", "Yusuf", 24, "Amin", "97mahyus@gafe.molndal.se", "Katt", "Tv Spel", "canjero", "Rap/afroFusion"));
        }

        public static bool Menu()
        {
            Console.WriteLine("Välkommen till ChatUp: ");
            Console.WriteLine("\n[1]\tKontakter \n[2]\tInformation om Kontakter \n[3]\tta bort användare \n[4]\tLägg till användare \n[n]\tAvsluta programet");

            string Menu = Console.ReadLine();
            string menuChoice = Menu.ToUpper();

            // En switch som läser av strängen menuChoice, det kunde såklart också vara en char
            switch (menuChoice)
            {
                case "1":
                    AllPerson();
                    return false;

                case "2":
                    PersonInfo();
                    return false;

                case "3":
                    RemovePerson();
                    return false;

                case "4":
                    AddPerson();
                    return false;

                case "n":
                    Console.WriteLine("Tack för besöket");
                    return true;

                default:
                    Console.WriteLine("Ogiltigt val prova igen");
                    return false;
            }
        }

        //kontaktman
        private static void AllPerson()
        {
            foreach (var person in contactlist)
            {
                Console.Write($"{{0}},", person.Firstname);
                Console.Clear();
            }
        }

        // kontakinf
        private static void PersonInfo()
        {
            Console.Clear();
            foreach (var person in contactlist)
            {
                Console.WriteLine($" firstname:{{0}}\n lastname: {{1}}\n Ålder: {{2}}\n alias: {{3}}\n email: {{4}}\n favoritdjur: {{5}}\n Hobby: {{6}}\n Favorit maträtt: {{7}}\n Favorit musik: {{8}}\n"
                    , person.Firstname, person.Lastname, person.Age, person.Alias, person.Email, person.Favoritdjur, person.Hobby, person.FavoritMat, person.FavoritMusik);
                contactlist[0].Firstname = Console.ReadLine();
            }
        }

        private static void AddPerson()
        {
            Person person = new Person();

            Console.Write("Enter First Name: ");
            person.Firstname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.Lastname = Console.ReadLine();

            Console.Write("Enter Email: ");
            person.Email = Console.ReadLine();
        }

        private static void RemovePerson()
        {
            Console.Clear();
            for (int i = 0; i < contactlist.Count; i++)
            {
                Console.WriteLine($" {i + 1} {contactlist[i].Firstname}");
            }

            Console.WriteLine("Skriv numret på den du vill ta bort");
            Console.Write("");
            int iRemove = Convert.ToInt32(Console.ReadLine());
            contactlist.RemoveAt(iRemove - 1);
        }

        private class Person
        {
            public string Email { get; internal set; }
            public string Lastname { get; internal set; }
            public string Firstname { get; internal set; }
        }
    }
}