using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLValidator1
{
   public class Parsing
    {
        static void Main()
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
                        AllTCs.Add(new Testcase { name = reader.GetAttribute("name"),var=new List<Var>(),map=new List<Map>() });
                    }
                    if (reader.NodeType == XmlNodeType.Element && "var" == reader.LocalName)
                    {
                        AllTCs[i].var.Add(new Var { Line = reader.LineNumber, name = reader.GetAttribute("name") });
                    }
                    if (reader.NodeType == XmlNodeType.Element && "map" == reader.LocalName && reader.GetAttribute("value")[0]=='@')
                    {
                        AllTCs[i].map.Add(new Map { Line = reader.LineNumber, value = reader.GetAttribute("value") });
                    }
                }
            }
            
            foreach (Testcase t1 in AllTCs)
            {
                Console.WriteLine(t1.name);
                foreach (Var v1 in t1.var)
                {
                    Console.WriteLine("     " + v1.Line + " " + v1.name);
                }
                foreach (Map m1 in t1.map)
                {
                    Console.WriteLine("     " + m1.Line + " " + m1.value);
                }
            }
            Comparing c = new Comparing();
            c.Comparison(AllTCs);

            Console.ReadLine();
        }
    }

   public class Comparing
   {
       public void Comparison(List<Testcase> LT)
       {
           for (int i = 0; i < LT.Count(); i++)
           {
               for(int j=0;j<LT[i].var.Count();j++)
               {
                   for (int k = 0; k < LT[i].map.Count(); k++)
                   {
                       if (LT[i].var[j].name == LT[i].map[k].value)
                           LT[i].map.RemoveAt(k);
                   }
               }
           }

           foreach(Testcase t in LT)
           {
             if(t.map.Count()>0)
             {
                 Console.WriteLine(t.name);
                 foreach(Map m in t.map)
                 {
                     Console.WriteLine("Variable " + m.value + " is not passed from Data Section which is used at Line No." + m.Line);
                 }
             }
           }
       }
   }
}