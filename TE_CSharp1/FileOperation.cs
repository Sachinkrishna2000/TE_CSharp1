using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp1
{
    internal class FileOperation
    {
        public static void Main()
        {
            string path1 = "C:\\Users\\Ei13077\\Documents\\sample1.txt";
            string path2 = "C:\\Users\\Ei13077\\Documents\\C_Sharp Files\\sample1.txt";
            string path3 = "C:\\Users\\Ei13077\\Documents\\sample2.txt";
            string path4 = "C:\\Users\\Ei13077\\Documents\\sample3.txt";
            string path5 = "C:\\Users\\Ei13077\\Documents\\C_Sharp Files\\sample3.txt";

            if (File.Exists(path3))
            {
                Console.WriteLine("File Exists");
                File.Delete(path3);
            }
            else
            {
                Console.WriteLine("File does not Exist");
            }
            Console.WriteLine("-----------------------------------------");

            //Read First Line
            string[] content;
            content = File.ReadAllLines(path2);
            int count = File.ReadAllLines(path2).Length;
            Console.WriteLine(content[0]);
           // Console.WriteLine(content[1]);
            Console.WriteLine("The Total No. Of Lines in the File are: "+count);



            //Move the file from one path to another
           File.Move(path5, path4);
            //File.Move(Source,destination)
           

            //Copy
            
            

            File.Copy(path2, path1);



        }
    }
}
