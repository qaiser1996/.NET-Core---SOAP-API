using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebSoap.Models
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int ID{ get; set; }

        [DataMember]
        public Customer Customer { get; set; }

        [DataMember]
        public Product Product { get; set; }
    }
}
