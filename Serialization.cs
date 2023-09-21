using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIODemo
{
    [Serializable]
    public class contact
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Serialization
    {
        static string path = @"C:\Users\nethi\source\repos\FileIODemo\Serialization.txt";
        public static void SerializeData()
        {
            List<contact> list = new List<contact>()
            {
                new contact {Age =22,Name ="Sireesha"},
                new contact {Age =23,Name ="Madhu"},
                new contact {Age =29,Name ="Sam"},
                new contact {Age =26,Name ="Havi"},
            };
            FileStream stream = new FileStream(path, FileMode.Create);
            BinaryFormatter BF = new BinaryFormatter();
            BF.Serialize(stream,list);
            stream.Close();
            Console.WriteLine("Converting Object to Binary");
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
        }
        public static void DeserializeData()
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            BinaryFormatter BF = new BinaryFormatter();
            var data =(List<contact>)BF.Deserialize(stream);
            stream.Close();
            Console.WriteLine("Converting List of Binary data to Object");
            foreach(var item in data)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }
        public static void XML_Serialization()
        {
            string path = @"C:\Users\nethi\source\repos\FileIODemo\Serialization.xml";
            FileStream stream = new FileStream(path, FileMode.Create);
            XmlSerializer XMlSObj = new XmlSerializer(typeof(List<contact>));
            List<contact> list = new List<contact>()
            {
                new contact {Age =22,Name ="Sireesha"},
                new contact {Age =23,Name ="Madhu"},
                new contact {Age =29,Name ="Sam"},
                new contact {Age =26,Name ="Havi"},
            };
            XMlSObj.Serialize(stream,list);
        }
        public static void XML_Deserialization()
        {
            string path = @"C:\Users\nethi\source\repos\FileIODemo\Serialization.xml";
            FileStream stream = new FileStream(path, FileMode.Open);
            XmlSerializer XMlSObj = new XmlSerializer(typeof(List<contact>));
            List<contact> list = (List<contact>)XMlSObj.Deserialize(stream);
            stream.Close();
            foreach(contact item in list)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }
        public static void JSON_Serialization()
        {
            List<contact> list = new List<contact>()
            {
                new contact {Age =22,Name ="Sireesha"},
                new contact {Age =23,Name ="Madhu"},
                new contact {Age =29,Name ="Sam"},
                new contact {Age =26,Name ="Havi"},
            };
            string JsonData = JsonConvert.SerializeObject(list);
            Console.WriteLine(JsonData);
        }
        public static void JSON_Deserialization()
        {
            string json = @"{""Name"":""Sireesha"",""Age"":22},{""Name"":""Madhu"",""Age"":23},{""Name"":""Sam"",""Age"":29},{""Name"":""Havi"",""Age"":26}";
            
            contact JsonData = JsonConvert.DeserializeObject<contact>(json);
            Console.WriteLine(JsonData);
            
        }


    }
}
