using System;
using System.Collections.Generic;
using System.Linq;
 
namespace SimplePhoneBook
{
    class Program
    { 
        public  static List<Person> People = new List<Person>();
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
                   case  "delete" :
                          DeletePerson();
                          break;
                   case "search":
                            searchperson();
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
        private static  void DeletePerson(){
         List<Person> people = findperson();
         Console.Clear();
         Console.WriteLine("enter  the number");
         for(int i=0;i<people.Count;i++ ){
          Console.WriteLine(i);
          PrintContact(people.ElementAt(i));
          int removenumber = Convert.ToInt32(Console.ReadLine());
          removeperson(people.ElementAt(removenumber));

         }
        }
        private static  void searchperson(Person person){
            List<Person> people = findperson();
          PrintContact(person);

        }
         private static void removeperson(Person person)
        {
           People.Remove(person);
           Console.Clear();
           Console.WriteLine("Contact deleted");

    }
    private static List<Person>  findperson(){
string name = Console.ReadLine();
   return People.Where(x => x.FirstName.ToLower() == name.ToLower()).ToList();
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
