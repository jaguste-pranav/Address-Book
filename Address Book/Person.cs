using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Address_Book
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private int zip;
        private int contactNo;
        private string emailId;

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }
        public void setCity(string city)
        {
            this.city = city;
        }

        public void setState(string state)
        {
            this.state = state;
        }
        public void setZip(int zip)
        {
            this.zip = zip;
        }
        public void setContactNo(int contactNo)
        {
            this.contactNo = contactNo;
        }
        public void setEmailId(string emailId)
        {
            this.emailId = emailId;
        }
        public string getFirstName()
        {
            return this.firstName;
        }
        public string getLastName()
        {
            return this.lastName;
        }

        public string getAddress()
        {
            return this.address;
        }
        public string getCity()
        {
            return this.city;
        }
        public string getState()
        {
            return this.state;
        }
        public int getContactNo()
        {
            return this.contactNo;
        }
        public int getZip()
        {
            return this.zip;
        }
        public string getEmailId()
        {
            return this.emailId;
        }

        public void SortByCity(List<Person> person)
        {
            person.Sort((contact1, contact2) => contact1.city.CompareTo(contact2.city));
        }
        public void SortByState(List<Person> person)
        {
            person.Sort((contact1, contact2) => contact1.state.CompareTo(contact2.state));
        }
        public void SortByZip(List<Person> person)
        {
            person.Sort((contact1, contact2) => contact1.zip.CompareTo(contact2.zip));
        }
    }
}
