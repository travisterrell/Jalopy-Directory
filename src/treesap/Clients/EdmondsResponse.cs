using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace treesap.Clients
{
    public class EdmondsResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string niceName { get; set; }
        public List<Model> models { get; set; }

        public class Year
        {
            public int id { get; set; }
            public int year { get; set; }
        }

        public class Model
        {
            public string id { get; set; }
            public string name { get; set; }
            public string niceName { get; set; }
            public List<Year> years { get; set; }
        }
    }
}

