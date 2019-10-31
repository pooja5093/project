using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    class Program
    {
        public static List<Person> Phonebook = new List<Person>();
        static void Main(String[] args)
        {
            string choice = "";
            while (choice != "exit")
            {
                Console.WriteLine("Please enter a choice: ");
                choice= Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "add":
                        AddPerson();
                        break;
                 /**    case "remove":
                        RemovePerson();
                        break;  **/
                    default:
                        if (choice != "exit")
                        {
                            DisplayHelp();
                        }
                        break;
                }
            }
        }

      private static void DisplayHelp()
        {
            Console.WriteLine("Available Commands:");
            Console.WriteLine("add \n Add a person" );
            Console.WriteLine("remove \n Removes a person");
            Console.WriteLine("Press any key to continue.");
           Console.ReadKey();
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

            Phonebook.Add(person);
        }
            
        private static void PrintPerson(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
        }
    public class Person
    
        {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        
        }
    }
}
