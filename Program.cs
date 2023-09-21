using System.IO;

namespace FileIODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileIOhandeling.CheckFile();
            Console.WriteLine("=====================");
            FileIOhandeling.ReadAllLines();
            Console.WriteLine("=====================");
            FileIOhandeling.ReadAllText();
            Console.WriteLine("=====================");
            FileIOhandeling.Copy_File();
            Console.WriteLine("=====================");
            FileIOhandeling.DeleteFile();
            Console.WriteLine("=====================");
            FileIOhandeling.WriteData();
            Console.WriteLine("=====================");
            FileIOhandeling.AppendFile();
            Console.WriteLine("=====================");
            Console.WriteLine("Reading data from the Stream Reader");
            FileIOhandeling.Stream_Reader();
            Console.WriteLine("=====================");
            FileIOhandeling.Stream_Writer();
            Console.WriteLine("=====================");
            //FileIOhandeling.CreateFile();
            Console.WriteLine("=====================");
            Serialization.SerializeData();
            Console.WriteLine("=====================");
            Serialization.DeserializeData();
            Console.WriteLine("=====================");
            //Serialization.XML_Serialization();
            //Serialization.XML_Deserialization();
            Console.WriteLine("======JSON===========");
            //Serialization.JSON_Serialization();
            Serialization.JSON_Deserialization();
        }


    }
}