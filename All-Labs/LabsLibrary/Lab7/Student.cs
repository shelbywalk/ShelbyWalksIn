using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LabsLibrary.Lab7
{
    [DataContract]
    public class Student : Person
    {
        [DataMember]
        public string Group { get; set; }
        [DataMember]
        public string Institution { get; set; }
        [DataMember]
        public string Specialization { get; set; }
    }
}
