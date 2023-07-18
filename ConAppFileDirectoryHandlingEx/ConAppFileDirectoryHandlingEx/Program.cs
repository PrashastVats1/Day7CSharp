using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConAppFileDirectoryHandlingEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string fFolder = "D:\\Mphasis\\Live Session\\Day7\\";
            //string newDir;
            //Console.WriteLine("Enter new directory name");
            //newDir = Console.ReadLine();
            //string fPath = fFolder + newDir;
            //DirectoryInfo directoryInfo = new DirectoryInfo(fPath);
            //if(directoryInfo.Exists )
            //{
            //    Console.WriteLine($"Directory {newDir} already exists");
            //}
            //else
            //{
            //    directoryInfo.Create();
            //    Console.WriteLine($"Directory {newDir} creation on {fPath} success");
            //}

            string fPath;
            Console.WriteLine("Enter director path");
            fPath = Console.ReadLine();
            DirectoryInfo di = new DirectoryInfo(fPath);
            foreach (FileInfo fi in di.GetFiles())
            {
                Console.WriteLine("File Name: \t" + fi.FullName);
                Console.WriteLine("File Length: \t" + fi.Length);
                Console.WriteLine("Creation Time: \t" + fi.CreationTime);
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
