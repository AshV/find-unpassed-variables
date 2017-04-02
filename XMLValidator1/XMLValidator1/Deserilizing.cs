using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace XMLValidator1
{
    class Deserilizing
    {
        public static void Main()
        {
            Deserilizing d = new Deserilizing();
            d.DeserializeObject("sample.tc");
        }
        public void DeserializeObject(string filename)
        {
            Console.WriteLine("Reading with XmlReader.....");

            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "testcases";
            xRoot.IsNullable = true;

            XmlSerializer serializer = new XmlSerializer(typeof(Testcase),xRoot);

            FileStream fs = new FileStream(filename, FileMode.Open);
            XmlReader reader = XmlReader.Create(fs);

            Testcase t;

            t = (Testcase)serializer.Deserialize(reader);

            fs.Close();


            Console.ReadLine();
        }
    }
}
