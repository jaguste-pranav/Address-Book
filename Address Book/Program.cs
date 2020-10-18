using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Dictionary<string, List<Person>> dict = new Dictionary<string, List<Person>>();
            Console.WriteLine("Press 1 for creating Address Book\n 2 for Adding New Person\n 3 for Editing Details\n 4 for Deleting Contact\n 5 For exit");
            choice = Convert.ToInt32(Console.ReadLine());

            while (choice != 5)
            {
                switch (choice)
                {
                    case (1):
                        {
                            List<Person> list = new List<Person>();
                            Console.WriteLine("Enter the name of Address Book");
                            string addressBookName = Console.ReadLine();
                            dict.Add(addressBookName, list);

                            Console.WriteLine("Address Book with name "+ addressBookName+" created!!");
                            break;
                        }

                    case (2):
                        {
                            Console.WriteLine("The list of Address Books are ");
                            foreach (string Key in dict.Keys)
                            {
                                Console.WriteLine(Key);
                            }
                            Console.WriteLine("\n\nEnter name of address book to add Contact");
                            string addressBookAdd = Console.ReadLine();

                            if (dict.ContainsKey(addressBookAdd))
                            {
                                bool recordWithSameNameFound = false;
                                Person person = new Person();
                                Console.WriteLine("Enter the First Name: ");
                                string firstName = Console.ReadLine();
                                Console.WriteLine("Enter the Last Name: ");
                                string lastName = Console.ReadLine();

                                foreach (var i in dict[addressBookAdd])
                                {
                                    if (i.getFirstName().Equals(firstName) && i.getLastName().Equals(lastName))
                                    {
                                        Console.WriteLine("Error! Person with same record found in Address Book");
                                        recordWithSameNameFound = true;
                                        break;
                                    }
                                }

                                if (!recordWithSameNameFound)
                                {
                                    Console.WriteLine("Enter the Address: ");
                                    string address = Console.ReadLine();

                                    Console.WriteLine("Enter the City: ");
                                    string city = Console.ReadLine();

                                    Console.WriteLine("Enter the State: ");
                                    string state = Console.ReadLine();

                                    Console.WriteLine("Enter the Contact Details: ");
                                    int contactNo = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Enter the Zip Code: ");
                                    int zip = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Enter the email ID: ");
                                    string emailId = Console.ReadLine();

                                    person.setFirstName(firstName);
                                    person.setLastName(lastName);
                                    person.setAddress(address);
                                    person.setCity(city);
                                    person.setState(state);
                                    person.setContactNo(contactNo);
                                    person.setZip(zip);
                                    person.setEmailId(emailId);


                                    dict[addressBookAdd].Add(person);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No such address Book");
                            }
                            break;
                        }


                    case (5):
                        {
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Please Select correct option");
                            break;
                        }
                        
                }
                Console.WriteLine("______________________________________________________________________________________");
                Console.WriteLine("Press your choice again");
                choice = Convert.ToInt32(Console.ReadLine());
                
            }

            Console.WriteLine("\nThe details of contacts in address are as follows: ");

            foreach (string Key in dict.Keys)
            {
                Console.WriteLine(Key);
            }
            Console.WriteLine("Enter the name of address book you want to print");
            string addressbookname = Console.ReadLine();

            foreach (var i in dict[addressbookname])
            { 
                Console.WriteLine("First name - " + i.getFirstName());
                Console.WriteLine("Last Name - " + i.getLastName());
                Console.WriteLine("Address - " + i.getAddress());
                Console.WriteLine("City - " + i.getCity());
                Console.WriteLine("State - " + i.getState());
                Console.WriteLine("Contact No - " + i.getContactNo());
                Console.WriteLine("Zip Code - " + i.getZip());
                Console.WriteLine("Email ID - " + i.getEmailId());
                Console.Write("\n");
            }
        }
    }
}
