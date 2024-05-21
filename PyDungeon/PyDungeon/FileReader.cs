using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyDungeon
{
    internal class FileReader
    {
        static StreamWriter writer = null;
        static StreamReader reader = null;
        const string path = @"C:\Users\deand\Documents\";
        static string filecopy = path;
        public static void Filer()
        {
            
            
            Console.Write("Enter the file name with .txt extension (ex. myfile.txt): ");
            string filename = path + Console.ReadLine();
            try
            {
                if (!File.Exists(filename))
                {
                    writer = File.CreateText(filename);
                    writer.WriteLine($"File created @ {DateTime.Now}");
                    Console.WriteLine("The file was created!");
                    Console.Write("Please enter your name: ");
                    writer.WriteLine(Console.ReadLine());
                    Console.Write("Please enter your age: ");
                    writer.WriteLine(Console.ReadLine());
                    Console.Write("Please enter your address: ");
                    writer.WriteLine(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("The file already exists...");
                    Console.WriteLine("Do you want to add to it? [Y]/[N]");
                    if (Console.ReadLine() == "Y")
                        File.AppendAllText(filename, $"\nFile modified @ {DateTime.Now}");
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
            Console.ReadKey();

        }
        public static void Copier()
        {
            const string path = @"C:\Users\deand\Documents\";
            StreamWriter writer = null;
            retry:
            Console.Write("Enter the file name w/out .txt extension (ex. myfile): ");
            string filename = path + Console.ReadLine();
            string ext = ".txt";
            try
            {
                if (File.Exists(filename+ext))
                {
                    filecopy = path;
                    Console.Write("The file was found! Please enter the new filename: ");
                    filecopy += Console.ReadLine() + ext;
                    File.Copy(filename+ext,filecopy);
                    

                }
                else
                {
                    Console.WriteLine("That file does not exists...");
                    Console.WriteLine("Do you want to try copying a different file? [Y]/[N]");
                    if (Console.ReadLine() == "Y")
                        goto retry;
                    

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

            Console.WriteLine("\n\nReading the new text file... \n");
            using (StreamReader reader = new StreamReader(filecopy))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();

        }
    }
    
}
