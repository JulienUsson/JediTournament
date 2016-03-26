using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebService.Contract
{
    [DataContract(Name = "EPhaseTournoiContract")]
    public enum EPhaseTournoiContract
    {
        [EnumMember]
        QuartFinale,
        [EnumMember]
        HuitiemeFinale,
        [EnumMember]
        DemiFinale,
        [EnumMember]
        Finale
    }
}