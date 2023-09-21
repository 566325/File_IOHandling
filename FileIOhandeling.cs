using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    public class FileIOhandeling
    {
        public static void CheckFile()
        {
            string path = @"C:\Users\nethi\source\repos\FileIODemo\TextFile1.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exist");
            }
        }
        public static void ReadAllLines()
        {
            string path = @"C:\Users\nethi\source\repos\FileIODemo\TextFile1.txt";
            string[] line;
            line = File.ReadAllLines(path);
            foreach (var data in line)
            {
                Console.WriteLine(data);
            }
        }
        public static void ReadAllText()
        {
            string path = @"C:\Users\nethi\source\repos\FileIODemo\TextFile1.txt";
            string line;
            line = File.ReadAllText(path);
            Console.WriteLine(line);
        }
        public static void Copy_File()
        {
            string path = @"C:\Users\nethi\source\repos\FileIODemo\TextFile1.txt";
            string copypath = @"C:\Users\nethi\source\repos\FileIODemo\TextFile2.txt";
            File.Copy(path, copypath);
            Console.WriteLine("File Copied Successfully ");
        }
        public static void DeleteFile()
        {
            string copypath = @"C:\Users\nethi\source\repos\FileIODemo\TextFile2.txt";
            File.Delete(copypath);
            Console.WriteLine("File Delete Successfully");
        }
        public static void WriteData()
        {
            string path = @"C:\Users\nethi\source\repos\FileIODemo\TextFile1.txt";
            string[] data = { "Sireesha", "Haveela", "Madhuri", "Mahi" };
            File.WriteAllLines(path, data);
            Console.WriteLine("Writen data Successfully");

        }
        public static void AppendFile()
        {
            string path = @"C:\Users\nethi\source\repos\FileIODemo\TextFile1.txt";
            string[] data = { "Apple", "Banana", "Orenge", "Kivi" };
            File.AppendAllLines(path, data);
            Console.WriteLine("Append Successfully");
        }
        public static void Stream_Reader()
        {
            string path = @"C:\Users\nethi\source\repos\FileIODemo\TextFile1.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string data = " ";
                while ((data = sr.ReadLine()) != null)
                {
                    Console.WriteLine(data);
                }
            }

        }
        public static void Stream_Writer()
        {
            string path = @"C:\Users\nethi\source\repos\FileIODemo\TextFile1.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Sireesha Nethi");
            }

        }
        public static void CreateFile()
        {
            string path = @"C:\Users\nethi\source\repos\FileIODemo\TextFile2.txt";
            FileStream obj = new FileStream(path, FileMode.Create);

        }
    }

}
