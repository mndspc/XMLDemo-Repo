using System;
using System.Xml;
namespace XMLDemo
{
    class ToReadXML
    {
        static void Main()
        {
            using (XmlReader xmlReader = XmlReader.Create("test1.xml"))
            {
                xmlReader.ReadToFollowing("Student");
                do
                {
                    xmlReader.ReadToFollowing("Name");
                    Console.WriteLine("Name={0}", xmlReader.ReadElementContentAsString());

                    xmlReader.ReadToFollowing("Location");
                    Console.WriteLine("Location={0}", xmlReader.ReadElementContentAsString());

                    Console.WriteLine("-----------------------------------------------");
                } while (xmlReader.ReadToFollowing("Student"));
            }
            Console.ReadLine();
        }
    }
}
