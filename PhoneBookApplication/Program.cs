using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBookApplication
{
    class Program
    {
       // Contact contact= new Contact();
        static void Main(string[] args)
        {
        Console.WriteLine("1 : Add ContactDetails");
        Console.WriteLine("2 : Delete ContactDetails");
        Console.WriteLine("3 : Display ContactDetails");
        Console.WriteLine("4 : Exit");
        int UserInput = Int32.Parse(Console.ReadLine());
             if(UserInput==1)
             {
                 PhoneBook.AddContact();
             }
             else if(UserInput==2)
             {
                 PhoneBook.DeleteContact();
             }
             else if(UserInput==3)
             {
                 PhoneBook.ShowContact();
             }
             else
             {
                 Console.WriteLine("You have entered a wrong option.Please try again with different option.");
                 main();
             }  
        }
    }
}
