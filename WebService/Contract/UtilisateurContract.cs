using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebService.Contract
{
    [DataContract]
    public class UtilisateurContract : EntityContract
    {
        [DataMember]
        public string Login { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}