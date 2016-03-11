using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebService.Contract
{
    [DataContract]
    public class MatchContract : EntityContract
    {
        [DataMember]
        public JediContract Vainqueur { get; set; }

        [DataMember]
        public JediContract Jedi1 { get; set; }

        [DataMember]
        public JediContract Jedi2 { get; set; }

        [DataMember]
        public EPhaseTournoiContract PhaseTournoi { get; set; }

        [DataMember]
        public StadeContract Stade { get; set; }
    }
}