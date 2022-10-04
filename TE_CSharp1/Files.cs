using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    public class Files_Demo
    {
        /// <summary>
        /// Write contents into the file using StreamWriter class
        /// </summary>
        string path1 = "C:\\Users\\Ei13077\\Documents\\C_Sharp Files\\mult.txt";
        string path2 = "C:\\Users\\Ei13077\\Documents\\C_Sharp Files\\sample1.txt";
        string path3 = "C:\\Users\\Ei13077\\Documents\\C_Sharp Files\\sample2.txt";
        string path4 = "C:\\Users\\Ei13077\\Documents\\C_Sharp Files\\sample3.txt";
        public void Write()
        {
            //Specify the filename and the path of the file to be created 
            //Fileinfo - class
            FileInfo fileInfo = new FileInfo(path1);
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fileStream);
            try
            {
                for(int i = 1; i < 11; i++)
                {
                    for(int j = 1; j < 11; j++)
                    {
                        writer.WriteLine($"{i}x{j}={i*j}");
                    }
                    writer.WriteLine();
                }
                
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
                fileStream.Close();
            }

        }
        /// <summary>
        /// Read the contents of the file using StreamReader class
        /// </summary>

        public void read()
        {

            //Specify the filename and the path of the file to be created 
            //Fileinfo - class
            FileInfo fileInfo = new FileInfo(path1);
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(fileStream);
            try
            {
                string contents = reader.ReadToEnd();
                Console.WriteLine(contents);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                reader.Close();
                fileStream.Close();
            }

        }

      


    }
    internal class Files
    {
        public static void Main()
        {
            Files_Demo demo = new Files_Demo();
            demo.Write();
            demo.read();
        }
        
    }
}
