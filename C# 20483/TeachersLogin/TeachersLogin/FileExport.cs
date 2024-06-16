using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeachersLogin
{
    internal class FileExport
    {
        public static void StarStudentFile(Student s)
        {
            const string path = @"C:\Users\deand\Documents\";
            StreamWriter writer = null;
            
            string filename = path + "star_student.txt";
            try
            {
                newfile:
                if (!File.Exists(filename))
                {
                    
                    writer = File.CreateText(filename);
                    
                    writer.WriteLine($"\t\tStar Student!\n",filename);
                    writer.WriteLine($"\n\tName: {s.Name} ID: {s.ID} GPA: {s.GPA}");
                    MessageBox.Show("Star Student file created successfuly!", "File Created");

                }
                else
                {
                    var result =MessageBox.Show("Do you want to overwrite?", "File Exists", MessageBoxButtons.YesNo);
                    
                    if (result==DialogResult.Yes)
                        File.Delete(filename);
                    goto newfile;

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
            /*
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

            */
        }
    }
}
