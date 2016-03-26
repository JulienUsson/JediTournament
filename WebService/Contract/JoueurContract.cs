using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebService.Contract
{
    [DataContract]
    public class JoueurContract : EntityContract
    {
        [DataMember]
        public string Nom { get; set; }

        [DataMember]
        public int Score { get; set; }
    }
}