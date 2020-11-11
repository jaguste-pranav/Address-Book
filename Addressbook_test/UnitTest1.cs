using AddressBook;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddressBookTest
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// UC16
        /// </summary>
        [TestMethod]
        public void CompareRetrievedDataFromDB()
        {
            ContactsDB expected = new ContactsDB()
            {
                first_name = "Pranav",
                last_name = "Jaguste",
                address = "Mulund",
                city = "Mumbai",
                state = "Mh",
                zipcode = 400081,
                phone_no = "1234567890",
                email = "pj@gmail.com",
                Contact_Type = "Family",
                Book_Name = "Book1"
                
            };

            var actual = AddressBookRepoDB.RetrieveData();

            Assert.AreEqual(expected.first_name, actual.first_name);
            Assert.AreEqual(expected.last_name, actual.last_name);
            Assert.AreEqual(expected.city, actual.city);
            Assert.AreEqual(expected.phone_no, actual.phone_no);
            Assert.AreEqual(expected.Book_Name, actual.Book_Name);
            Assert.AreEqual(expected.Contact_Type, actual.Contact_Type);

        }

        [TestMethod]
        public void CompareUpdatedDataFromDB()
        {
            string expected = "Karnataka";

            string actual = AddressBookRepoDB.UpdateDetailsInDB();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDateBetweenRangeNow()
        {
            string expected = "RachitTanmayAkhil";

            string actual = AddressBookRepoDB.GetDateBetweenRange();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddContact()
        {
            bool expected = true;
            ContactsDB contactDetails = new ContactsDB();
            contactDetails.first_name = "Rakesh";
            contactDetails.last_name = "Sharma";
            contactDetails.Book_Name = "Book4";
            contactDetails.Contact_Type = "Family";
            contactDetails.B_ID = "BK4";
            AddressBookRepoDB addressBookRepoDB = new AddressBookRepoDB();
            bool actual = addressBookRepoDB.AddContactDetailsInDB(contactDetails);
            Assert.AreEqual(expected, actual);
        }
    }

}