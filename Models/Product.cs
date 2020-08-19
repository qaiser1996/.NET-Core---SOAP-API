using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebSoap.Models
{
    [DataContract]
    public class Product
    {

        public Product()
        {}

        public Product(int id, string name, string description, string imageURL)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.imageUrl = imageUrl;
        }

        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string imageUrl { get; set; }
    }
}
