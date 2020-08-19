using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace WebSoap.Models
{
    [ServiceContract]
    interface IShoppingService
    {
        [OperationContract]
        string AddProduct(Product product);

        [OperationContract]
        string AddCustomer(Customer customer);

        [OperationContract]
        string AddOrder(int id, int customerId, int productId);

        [OperationContract]
        Product GetProduct(int id);

        [OperationContract]
        Order GetOrder(int id);

        [OperationContract]
        Customer GetCustomer(int id);

        [OperationContract]
        string DeleteOrder(int id);

        [OperationContract]
        string DeleteProduct(int id);

        [OperationContract]
        string DeleteCustomer(int id);
    }
}
