using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Linq;

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
                    sr.WriteLine(p.firstName + "," + p.lastName + "," + p.address + "," + p.city + "," + p.state + "," + p.zipCode);
                    sr.Close();
                }
                Console.WriteLine("Written to file successfully");
            }
            else
            {
                Console.WriteLine("File Does Not Exist");
            }
        }

        public static void WriteToCsv(Dictionary<string, List<Person>> dict)
        {
            string filePathCSV = @"C:\Users\Pranav V Jaguste\source\repos\Address Book\Address Book\Person.csv";

            foreach (string Key in dict.Keys)
            {
                string bookName = Key;
                List<Person> contacts = dict[Key];
                using (StreamWriter streamWriter = new StreamWriter(filePathCSV))
                {
                    using (CsvWriter writer = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                    {
                        writer.WriteRecords<Person>(contacts);
                    }
                }

            }
        }
    }
}
