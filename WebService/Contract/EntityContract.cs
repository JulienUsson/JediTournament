using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebService.Contract
{
    [DataContract]
    public class EntityContract
    {
        [DataMember]
        public int ID { get; set; }
    }
}