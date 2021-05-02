using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.EnterpriseServices;

namespace TransactionComponent
{
    public class TransactionClass
    {
        public string AddDetails(string prodName, string prodDescription, string prodType)
        {
            ServiceConfig config = new ServiceConfig();
            config.Transaction = TransactionOption.Required;
            ServiceDomain.Enter(config);
            try
            {
                Products prod = new Products();
                int ProdID = prod.AddProducts(prodName, prodDescription);
                ProductType pType = new ProductType();
                pType.AddProductType(ProdID, prodType);

            }

            catch
            {
                throw;
            }
            finally
            {
                ServiceDomain.Leave();
            }
            return "Data entered successfully";
        }

    }
}
