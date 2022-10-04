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

            //ReadAllLines
            /*string[] content;
            content = File.ReadAllLines(path2);
            Console.WriteLine(content[0]);
            Console.WriteLine(content[1]);
            Console.WriteLine("-----------------------------------------");

            //ReadAllText
            string content1;
            content1 = File.ReadAllText(path2);
            Console.WriteLine(content1);
            Console.WriteLine("-----------------------------------------");

            //LINQ
            var str = from info in File.ReadLines(path2) //@"E:\TE.txt"
                      where info.StartsWith("Files") || info.Contains("append")
                      select info;

            File.AppendAllLines(@"E:\TE1.txt", str);*/

            //Move the file from one path to another
            File.Move(path5, path4);
            //File.Move(Source,destination)
           

            //Copy
            
            

            File.Copy(path2, path1);



        }
    }
}
