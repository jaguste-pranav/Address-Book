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
            List<Person> people = new List<Person>(); ;
            Console.WriteLine("Press 1 for creating Address Book\n 2 for Adding New Person\n 3 for Editing Details\n 4 for Deleting Contact\n 5 For exit");
            choice = Convert.ToInt32(Console.ReadLine());

            while (choice != 5)
            {
                switch (choice)
                {
                    case (1):
                        {
                            people = new List<Person>();
                            Console.WriteLine("Address Book created!");
                            break;
                        }


                }
            }
        }
    }
}
