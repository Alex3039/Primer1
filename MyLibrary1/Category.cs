using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary1
{
      //  public class Rootobject
      //  {
      //      public Category[] Property1 { get; set; }
      //  }

        public class Category
        {
            public object[] razdels { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public string content { get; set; }
            public string title { get; set; }
            public string kw { get; set; }
            public string dsp { get; set; }
            public string image { get; set; }
            public string alias { get; set; }
        }   
}
