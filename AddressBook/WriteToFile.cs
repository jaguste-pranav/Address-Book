using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CsvHelper;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json;

namespace Address_Book
{
    class WriteToFile
    {
        public static void WriteFile(Person p) //Function to Write All contacts of all books in Text File
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

        /// <summary>
        /// Function to Write All contacts of all books in CSV File
        /// </summary>
        /// <param name="dict">The dictionary</param>
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

        public static void WriteToJson(Dictionary<string, List<Person>> dict) //Function to Write All contacts of all books in Json File
        {
            string filePathJson = @"C:\Users\Pranav V Jaguste\source\repos\Address Book\Address Book\Person.json";
            foreach (string Key in dict.Keys)
            {
                string bookName = Key;
                List<Person> contacts = dict[Key];
                JsonSerializer jsonSerializer = new JsonSerializer();

                using (StreamWriter stw = new StreamWriter(filePathJson))
                {
                    jsonSerializer.Serialize(stw, contacts);
                }
            }
        }
    }
}
