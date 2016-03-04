﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebService.Contract;

namespace WebService
{
    [ServiceContract]
    public interface IJediService
    {
        [OperationContract]
        List<JediContract> GetJedis();

        [OperationContract]
        JediContract AddJedis(JediContract jedi);

        [OperationContract]
        JediContract UpdateJedis(JediContract jedi);

        [OperationContract]
        bool DelJedis(JediContract jedi);
    }
}