using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebService.Contract
{
    [DataContract]
    public class StadeContract : EntityContract
    {
        [DataMember]
        public int NbPlaces { get; set; }

        [DataMember]
        public string Planete { get; set; }
    }
}