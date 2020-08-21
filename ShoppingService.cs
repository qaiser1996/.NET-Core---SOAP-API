using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using WebSoap.Data;
using WebSoap.Models;

namespace WebSoap
{
    public class ShoppingService : IShoppingService
    {

        public string AddCustomer(Customer customer)
        {
            Customer c = new Customer()
            {
                ID = customer.ID,
                Name = customer.Name,
                Address = customer.Address,
                Email = customer.Email
            };

            //Perform DB Operation Here
            ShoppingData.customers.Add(c.ID, c);

            return "Customer Added Successfully!";
        }

        public string AddOrder(int id, int customerId, int productId)
        {
            Order order = new Order()
            {
                Customer = ShoppingData.customers[customerId],
                Product = ShoppingData.prodcuts[productId],
                ID = id
            };

            // Perform DB Operation Here
            ShoppingData.orders.Add(id, order);

            return "Order Added Successfully!";
        }

        public string AddProduct(Product product)
        {
            
                Product p = new Product()
                {
                    Name = product.Name,
                    ID = product.ID,
                    Description = product.Description,
                    imageUrl = product.imageUrl
                };

                //Perform DB Operation Here!
                ShoppingData.prodcuts.Add(p.ID, p);

                return "Successfully Added!";
        }

        public string DeleteCustomer(int id)
        {
            if (ShoppingData.customers.ContainsKey(id))
            {
                ShoppingData.customers.Remove(id);
                return "Successfully Removed!";
            }
            return "Error: Invalid ID!";
            
        }

        public string DeleteOrder(int id)
        {
            if (ShoppingData.orders.ContainsKey(id))
            {
                ShoppingData.orders.Remove(id);
                return "Successfully Removed!";
            }
            return "Error: Invalid ID!";
        }

        public string DeleteProduct(int id)
        {
            if (ShoppingData.prodcuts.ContainsKey(id))
            {
                ShoppingData.prodcuts.Remove(id);
                return "Successfully Removed!";
            }
            return "Error: Invalid ID!";
        }

        public Customer GetCustomer(int id)
        {
            if (ShoppingData.customers.ContainsKey(id))
            {
                // Fetch Results from DB and return
                return ShoppingData.customers[id];
            }
            else
            {
                return null;
            }
        }

        public Order GetOrder(int id)
        {
            if (ShoppingData.orders.ContainsKey(id))
            {
                // Fetch Results from DB and return
                return ShoppingData.orders[id];
            }
            else
            {
                return null;
            }
        }

        public Product GetProduct(int id)
        {
            if (ShoppingData.prodcuts.ContainsKey(id))
            {
                // Fetch Results from DB and returns
                return ShoppingData.prodcuts[id];
            }
            else
            {
                return null;
            }
            
        } 
    }
}
