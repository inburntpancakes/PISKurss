using PISKursovaya.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISKursovaya.Logic
{
    public interface IDatabaseAccess
    {
        List<User> GetAllUsers();
        List<Product> GetAllProducts();
        List<Order> GetAllOrders();
        List<Supplier> GetAllSuppliers();
        List<Firm> GetAllFirms();
        void SaveChangedProduct(Product product);
        void SaveChangedOrder(Order order);
        void SaveChangedUser(User user);
        void DeleteProduct(Product product);
        void AddProduct(Product product, int supplierId);
        void AddOrder(Order order);
        void RecallOrder(Order order);
        void DeclineOrder(Order order);
        void AcceptOrder(Order order);
    }
}
