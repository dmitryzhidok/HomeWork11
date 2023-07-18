global using ConsoleApp15;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    [DataContract]
    public class Squad
    {
        [DataMember]
        public string squadName { get; set; }
        [DataMember]
        public string homeTown { get; set; }
        [DataMember]
        public int formed { get; set; }
        [DataMember]
        public string secretBase { get; set; }
        [DataMember]
        public bool active { get; set; }
        [DataMember]
        public Member[] members { get; set; }

    }
}
