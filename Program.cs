using System;
using System.Collections.Generic;


namespace SimplePhoneBook
{
    class Program
    {
        public static List<Person> People = new List<Person>();
  static void Main()
        {
            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Please enter a command: ");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":
                        AddPerson();
                        break;
                 
                       
                   case "list":
                        ListPeople();
                        break;
                   
                                        default:
                      
                 Console.Write("Enter Correct Command  ");
                 break;}
            }
        }

       

        private static void AddPerson()
        {
            Console.Clear();

            Person person = new Person();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

           
           
            People.Add(person);
        }

   


     
        private static void ListPeople()
        {
            Console.Clear();
            if (People.Count == 0)
            {
                Console.WriteLine("Your phone book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your phoneboook\n");
            foreach (var person in People)
            {
                PrintContact(person);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
  private static void PrintContact(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("-------------------------------------------");
     
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        
        } 
    }
}
