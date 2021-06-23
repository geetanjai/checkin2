using System;
using System.Linq;
using System.Xml.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = "clients.xml";

            string xml = "<?xml version=\"1.0\" encoding=\"utf-8\"?><SessionId><Source></Source></SessionId>";
            XDocument doc = XDocument.Parse(xml);
            XElement source = doc.Descendants("Source").FirstOrDefault();
            source.Add(new XElement("User", new object[] {
new XAttribute("username", "AqB"),
new XElement("DOB", "25/5/1981"),
new XElement("FirstName", "AVS"),
new XElement("LastName", "WDW"),
new XElement("Location", "FWAWE")
}));
            source.Save(fileLocation);
            Console.WriteLine("Done");
        
    }
    }
}
