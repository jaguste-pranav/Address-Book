using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace Address_Book
{
    class WriteToFile
    {
        public static void WriteFile(Person p)
        {
            string pathToFile = @"C:\Users\Pranav V Jaguste\source\repos\Address Book\Address Book\Person.txt";

            if (File.Exists(pathToFile))
            {
                using (StreamWriter sr = File.AppendText(pathToFile))
                {
                    sr.WriteLine(p.getFirstName() + " " + p.getLastName() + " " + p.getAddress() + " " + p.getCity() + " " + p.getState() + " " + p.getZip());
                    sr.Close();
                }
                Console.WriteLine("Written to file successfully");
            }
            else
            {
                Console.WriteLine("File Does Not Exist");
            }
        }
    }
}
