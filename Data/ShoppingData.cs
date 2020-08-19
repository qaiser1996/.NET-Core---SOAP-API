using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSoap.Models;

namespace WebSoap.Data
{
    public class ShoppingData
    {
        public static Dictionary<Int32, Product> prodcuts = new Dictionary<int, Product>();
        public static Dictionary<Int32, Customer> customers = new Dictionary<int, Customer>();
        public static Dictionary<Int32, Order> orders = new Dictionary<int, Order>();
    }
}
