using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebService.Contract
{
    [DataContract]
    public class TournoiContract : EntityContract
    {
        [DataMember]
        public List<MatchContract> Matchs { get; set; }

        [DataMember]
        public string Nom { get; set; }
    }
}