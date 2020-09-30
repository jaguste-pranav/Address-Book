using System;
using System.Collections.Generic;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();

            person1.setFirstName("A");
            person1.setLastName("Z");
            person1.setAddress("xxx");
            person1.setCity("C1");
            person1.setState("S1");
            person1.setContactNo(123);
            person1.setZip(1);
            person1.setEmailId("a.z@gmail.com");

            person2.setFirstName("B");
            person2.setLastName("Y");
            person2.setAddress("xxx");
            person2.setCity("C2");
            person2.setState("S2");
            person2.setContactNo(567);
            person2.setZip(2);
            person2.setEmailId("b.y@gmail.com");

            List<Person> people = new List<Person>();

            people.Add(person1);
            people.Add(person2);

            foreach (var i in people)
            {
                Console.WriteLine(i.getLastName());
            }
        }
    }
}
