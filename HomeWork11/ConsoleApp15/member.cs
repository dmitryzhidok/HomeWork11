global using ConsoleApp15;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    [DataContract]
    public class Member
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int age { get; set; }
        [DataMember]
        public string secretIdentity { get; set; }
        [DataMember]
        public string[] powers { get; set; }
    }
}
