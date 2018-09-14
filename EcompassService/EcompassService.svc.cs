using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EcompassService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EcompassService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EcompassService.svc or EcompassService.svc.cs at the Solution Explorer and start debugging.
    public class EcompassService : IEcompassService
    {
        public void DoWork()

        {
        }
        private EcompassContext ecompassContext = new EcompassContext();

        public List<PnpProducts> GetProductsData()
        {
            return ecompassContext.Products.ToList();
        }

        public string SayHelloTo()
        {
            return "Hello World to you, Ecompass";
        }

    }
}
