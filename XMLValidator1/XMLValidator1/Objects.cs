using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLValidator1
{
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