using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLabs
{
    internal class FileReader
    {
        static StreamWriter writer = null;
        static StreamReader reader = null;
        const string path = @"C:\Users\deand\Documents\";
        static string filecopy = path;
        static string ext = ".txt";
        public static void Filer()
        {


            Console.Write("Enter the file name w/out .txt extension (ex. myfile): ");
            string filename = path + Console.ReadLine();
            try
            {
                if (!File.Exists(filename + ext))
                {
                    writer = File.CreateText(filename + ext);
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
                        File.AppendAllText(filename + ext, $"\nFile modified @ {DateTime.Now}");
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
            using (StreamReader reader = new StreamReader(filename + ext))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();

        }
        public static void Copier()
        {
            const string path = @"C:\Users\deand\Documents\";
            StreamWriter writer = null;
        retry:
            Console.Write("\nTo copy, enter the file name w/out .txt extension (ex. myfile): ");
            string name = Console.ReadLine();
            string filename = path + name;
            
            
            try
            {
                if (File.Exists(filename + ext))
                {
                    filecopy = path;
                    Console.Write("\nThe file was found! Please enter the new filename: ");
                    filecopy += Console.ReadLine() + ext;
                    File.Copy(filename + ext, filecopy);
                    

                }
                else
                {
                    Console.WriteLine("\nThat file does not exists...");
                    Console.WriteLine("Do you want to try copying a different file? [Y]/[N]");
                    if (Console.ReadLine().ToUpper() == "Y")
                        goto retry;


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.WriteLine($"\n\nReading the new text file... \nHere is the content of {filecopy}:\n");
            using (StreamReader reader = new StreamReader(filecopy))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        }
    }

}
