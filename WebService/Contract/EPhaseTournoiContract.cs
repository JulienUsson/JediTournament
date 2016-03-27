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
        HuitiemeFinale,
        [EnumMember]
        QuartFinale,
        [EnumMember]
        DemiFinale,
        [EnumMember]
        Finale
    }
}