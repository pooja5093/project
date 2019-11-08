using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBookApplication
{
   public class PhoneBook
    {
         List<Contact> Contacts=new List<Contact>();
         public static void AddContact()
        {
            Contact contact= new Contact();
                   
            Console.WriteLine("Enter firstName : ");
            contact.firstName=Console.ReadLine();
            Console.WriteLine("Enter lastName : ");
            contact.lastName=Console.ReadLine();
            Console.WriteLine("Enter phoneNumber : ");
            contact.phoneNumber=Console.ReadLine();
            Console.WriteLine("Enter emailId : ");
            contact.emailId=Console.ReadLine();
            Contact.Add(contact);
            Console.WriteLine("Details added successfully ");
            Main();
        }
        public static void DeleteContact()
        {
            Console.Write("Enter phone number you want to delete:");
            int phonenumber=int.Parse(Console.ReadLine());
            Contact.RemoveAll(mobileNumber => mobileNumber.phoneNumber == phonenumber);
            Console.Write("Contact deleted successfully");
            Main();
        } 
        public static void ShowContact()
        {
            foreach (var person in Contacts)
            {
                Console.WriteLine("Name : "+person.firstName+" "+person.lastName+",PhoneNumber :"+person.phoneNumber+", Email Id:"+person.emailId);
            }
            Main();
        }
}
}