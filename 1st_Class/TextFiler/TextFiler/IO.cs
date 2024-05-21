using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    internal class IO
    {
        public static void Filer()
        {
            const string path = @"C:\Users\deand\Documents\";
            StreamWriter writer = null;
            Console.Write("Enter the file name with .txt extension (ex. myfile.txt): ");
            string filename = path + Console.ReadLine();
            try
            {
                if (!File.Exists(filename))
                {
                    writer = File.CreateText(filename);
                    writer.WriteLine($"File created @ {DateTime.Now}\n");
                    Console.WriteLine("The file was created!\n");
                    Console.Write("Please enter your name: ");
                    writer.WriteLine("\nName: "+Console.ReadLine());
                    Console.Write("Please enter your age: ");
                    writer.WriteLine("Age: "+Console.ReadLine());
                    Console.Write("Please enter your address: ");
                    writer.WriteLine("Address: "+Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("The file already exists...");
                    Console.WriteLine("Do you want to add to it? [Y]/[N]");
                    if (Console.ReadLine() == "Y")
                        File.AppendAllText(filename, $"\nFile modified @ {DateTime.Now}\n");
                    Console.Write("Enter the number of lines you wish to write: ");
                    int linecount = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the additional information: ");
                    for (int i = 0; i < linecount; i++)
                    {
                        string line = Console.ReadLine();
                        writer.WriteLine(line);

                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                writer.Close();
            }

            Console.WriteLine("\n\nReading the text file... ");
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


        }
    }

}
