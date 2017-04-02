using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace FindUnPassedVariables
{
    public class Parsing
    {
        public List<Testcase> Parse()
        {
            try
            {
                int i = -1;
                List<Testcase> AllTCs = new List<Testcase>();
                using (XmlTextReader reader = new XmlTextReader("sample.tc"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && "testcase" == reader.LocalName)
                        {
                            i++;
                            AllTCs.Add(new Testcase { name = reader.GetAttribute("name"), var = new List<Var>(), map = new List<Map>() });
                        }
                        if (reader.NodeType == XmlNodeType.Element && "var" == reader.LocalName)
                        {
                            AllTCs[i].var.Add(new Var { Line = reader.LineNumber, name = reader.GetAttribute("name") });
                        }
                        if (reader.NodeType == XmlNodeType.Element && "map" == reader.LocalName && reader.GetAttribute("value")[0] == '@')
                        {
                            AllTCs[i].map.Add(new Map { Line = reader.LineNumber, value = reader.GetAttribute("value") });
                        }
                    }
                }
                return AllTCs;
            }
            catch
            {
                throw;
            }
        }
   
    }

    public class Comparing
    {
        public string Comparison(List<Testcase> LT)
        {
            try
            {
                string result = "";
                for (int i = 0; i < LT.Count(); i++)
                {
                    for (int j = 0; j < LT[i].var.Count(); j++)
                    {
                        for (int k = 0; k < LT[i].map.Count(); k++)
                        {
                            if (LT[i].var[j].name == LT[i].map[k].value)
                            {
                                LT[i].map.RemoveAt(k);
                                k--;
                            }
                        }
                    }
                }

                foreach (Testcase t in LT)
                {
                    if (t.map.Count() > 0)
                    {
                        result += "On TestCase " + t.name;
                        foreach (Map m in t.map)
                        {
                            result += "\n\t    Variable " + m.value + " at Line No." + m.Line+"\n";
                        }
                    }
                }
                return result;
            }
            catch
            {
                throw;
            }
        }
    }


    public class Var
    {
        public int Line { get; set; }
        public string name { get; set; }
    }
    public class Map
    {
        public int Line { get; set; }
        public string value { get; set; }
    }
    public class Testcase
    {
        public string name { get; set; }
        public List<Var> var { get; set; }
        public List<Map> map { get; set; }
    }
}
