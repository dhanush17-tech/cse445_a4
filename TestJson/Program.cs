using System;
using System.Xml;

class Program {
    static void Main() {
        XmlDocument doc = new XmlDocument();
        doc.Load("NationalParks.xml");
        string jsonText = Newtonsoft.Json.JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented);
        Console.WriteLine(jsonText);
    }
}
