using System;
using System.Xml;
namespace XMLDemo
{
    //  This program demo how write XML file
    class Program
    {
        static void Main(string[] args)
        {
            //  To create file inside working directory
            using (XmlWriter xmlWriter = XmlWriter.Create("test.xml"))
            {
                //  To Start Wrting Doc.
                xmlWriter.WriteStartDocument();
                //  To Write Root Element
                xmlWriter.WriteStartElement("Students");

                //  To Write Parent Element
                xmlWriter.WriteStartElement("Student");
                // To create attribute
                xmlWriter.WriteAttributeString("RollNo", "100");
                xmlWriter.WriteAttributeString("Name", "Scott");
                xmlWriter.WriteString("scott@gmail.com");
                //  To end Parent Element
                xmlWriter.WriteEndElement();
                //  To close Root Element
                xmlWriter.WriteEndElement();

                //  To Writing Doc.
                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
                Console.WriteLine("XML file written successfully");
            }
            Console.ReadLine();
        }
    }
}
