using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Dictionary<string, List<Person>> dict = new Dictionary<string, List<Person>>();
            Console.WriteLine("Press\n 1 for creating Address Book\n 2 for Adding New Person\n 3 for Editing Details\n 4 for Deleting Contact\n 5 For exit\n 6 for search by City or State\n 7 For displaying contacts City Wise\n 8 For displaying contacts State Wise\n 9 For displaying contacts Zip Wise\n 10 For displaying contacts Name Wise\n  11 for writing to file");
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

                            Console.WriteLine("Address Book with name " + addressBookName + " created!!");
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

                    case (6):
                        {
                            Console.WriteLine("Enter the name of city or state: ");
                            string location = Console.ReadLine();
                            int counter = 0;
                            foreach (string Key in dict.Keys)
                            {
                                counter = 0;
                                Console.WriteLine("For Address Book " + Key + " the contact Info is: \n");
                                foreach (var i in dict[Key])
                                {
                                    if (i.getCity().Equals(location) || i.getState().Equals(location))
                                    {
                                        counter++;
                                        Console.WriteLine("First name - " + i.getFirstName());
                                        Console.WriteLine("Last Name - " + i.getLastName());
                                    }
                                    Console.Write("\n");
                                }

                                Console.WriteLine("For " + location + " the number of people found in Address Book " + Key + " is " + counter);
                                Console.WriteLine("******************************************************");
                            }
                            break;
                        }

                    case (7):
                        {
                            Console.WriteLine("Sorting according to Name: ");
                            foreach (string Key in dict.Keys)
                            {
                                dict[Key].Sort((person1, person2) => person1.getFirstName().CompareTo(person2.getFirstName()));
                                PrintList(dict[Key]);
                            }
                            break;
                        }
                    case (8):
                        {
                            Console.WriteLine("Sorting according to City: ");
                            foreach (string Key in dict.Keys)
                            {
                                dict[Key].Sort((person1, person2) => person1.getCity().CompareTo(person2.getCity()));
                                PrintList(dict[Key]);
                            }
                            break;
                        }

                    case (9):
                        {
                            Console.WriteLine("Sorting according to State: ");
                            foreach (string Key in dict.Keys)
                            {
                                dict[Key].Sort((person1, person2) => person1.getState().CompareTo(person2.getState()));
                                PrintList(dict[Key]);
                            }
                            break;
                        }

                    case (10):
                        {
                            Console.WriteLine("Sorting according to Zip: ");
                            foreach (string Key in dict.Keys)
                            {
                                dict[Key].Sort((person1, person2) => person1.getZip().CompareTo(person2.getZip()));
                                PrintList(dict[Key]);
                            }
                            break;
                        }

                    case (11):
                        {
                            Console.WriteLine("Enter the name of city or state: ");
                            string location = Console.ReadLine();
                            int counter = 0;
                            foreach (string Key in dict.Keys)
                            {
                                counter = 0;
                                Console.WriteLine("For Address Book " + Key + " the contact Info is: \n");
                                foreach (var person in dict[Key])
                                {
                                    if (person.getCity().Equals(location) || person.getState().Equals(location))
                                    {
                                        WriteToFile.WriteFile(person);
                                    }
                                    Console.Write("\n");
                                }

                                Console.WriteLine("For " + location + " the number of people found in Address Book " + Key + " is " + counter);
                                Console.WriteLine("******************************************************");
                            }
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
            PrintList(dict[addressbookname]);
        }
        public static void PrintList(List<Person> p)
        {
            foreach (var person in p)
            {
                Console.WriteLine("First name - " + person.getFirstName());
                Console.WriteLine("Last Name - " + person.getLastName());
                Console.WriteLine("Address - " + person.getAddress());
                Console.WriteLine("City - " + person.getCity());
                Console.WriteLine("State - " + person.getState());
                Console.WriteLine("Contact No - " + person.getContactNo());
                Console.WriteLine("Zip Code - " + person.getZip());
                Console.WriteLine("Email ID - " + person.getEmailId());
                Console.Write("\n");
            }
        }
    }
}
