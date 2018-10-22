using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EcompassService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEcompassService" in both code and config file together.

    [ServiceContract(SessionMode = SessionMode.Allowed)]
    public interface IEcompassService
    {
        [OperationContract]
        string SayHelloTo();

        [OperationContract]
        List<PnpProducts> GetProductsData();
    }
}
