using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace XMLValidator1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlSchema schema = null;
                using (XmlReader reader = XmlReader.Create("sample.xsd"))
                {
                    schema = XmlSchema.Read(reader, null);
                }

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationType = ValidationType.Schema;

                settings.Schemas.Add(schema);

                using (XmlReader reader = XmlReader.Create("sample.tc", settings))
                {
                    while (reader.Read()) ;
                }
            }
            catch (XmlException xe)
            {
                Console.WriteLine("Either XML Schema or Provided XML File in Invalid");
                Console.WriteLine(xe.Message);
            }
            catch (XmlSchemaValidationException xe)
            {
                Console.WriteLine("Given XML file Having Syntax Error Against Provided Schema Please Check By Opening in Visual Studio.");
                Console.WriteLine(xe.Message);
            }
            Console.ReadLine();
        }
    }
}