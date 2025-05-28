using PISKursovaya.Logic;
using PISKursovaya.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PISKursovaya
{
    public class BuisnessLogic
    {
        private IDatabaseAccess databaseAccess;

        public BuisnessLogic(IDatabaseAccess databaseAccess)
        {
            this.databaseAccess = databaseAccess;
        }

        public bool TryAuthorizeAccess(string login, string password, out User user)
        {
            List<User> users = databaseAccess.GetAllUsers();
            bool isAuthorized = users.Exists(x => (x.login == login && x.password == password));

            if (isAuthorized)
            {
                User authorizedUser = users.Find(x => (x.login == login && x.password == password));
                user = authorizedUser;
                return true;
            }
            user = null;
            return false;
        }

        public List<Product> GetProductsOfSupplier(int supplierId)
        {
            List<Product> allProducts = databaseAccess.GetAllProducts();
            List<Product> productsOfSupplier = allProducts.Where(x => x.supplier_id == supplierId).ToList();
            return productsOfSupplier;
        }

        public List<Product> GetProductsOnSale()
        {
            List<Product> allProducts = databaseAccess.GetAllProducts();
            List<Product> productsOnSale = allProducts.Where(x => x.is_on_sale == true).ToList();
            return productsOnSale;
        }

        public List<Order> GetAllOrdersInProgress()
        {
            List<Order> allOrders = databaseAccess.GetAllOrders();
            List<Order> ordersInProgressOfSupplier = allOrders
                .Where(x => (x.status == OrderStatus.InProgress || x.status == OrderStatus.AwaitsSupplierConfirmation || x.status == OrderStatus.AwaitsFirmConfirmation || x.status == OrderStatus.AwaitsSupplierAcceptance))
                .ToList();
            return ordersInProgressOfSupplier;
        }

        public List<Order> GetOrdersInProgressOfSupplier(int supplierId)
        {
            List<Order> allOrders = databaseAccess.GetAllOrders();
            List<Order> ordersInProgressOfSupplier = allOrders
                .Where(x => (x.status == OrderStatus.InProgress || x.status == OrderStatus.AwaitsSupplierConfirmation || x.status == OrderStatus.AwaitsFirmConfirmation || x.status == OrderStatus.AwaitsSupplierAcceptance))
                .Where(x => (x.supplier_id == supplierId))
                .ToList();
            return ordersInProgressOfSupplier;
        }

        public void ConfirmOrderInProgressBySupplier(Order confirmedOrder)
        {
            if (confirmedOrder.status == OrderStatus.AwaitsSupplierConfirmation)
            {
                confirmedOrder.status = OrderStatus.Finished;
                confirmedOrder.date_of_finish = DateTime.Now;
                SaveChangedOrder(confirmedOrder);
            }
            else if (confirmedOrder.status == OrderStatus.InProgress)
            {
                confirmedOrder.status = OrderStatus.AwaitsFirmConfirmation;
                SaveChangedOrder(confirmedOrder);
            }
        }

        public void ConfirmOrderInProgressByFirm(Order confirmedOrder)
        {
            if (confirmedOrder.status == OrderStatus.AwaitsFirmConfirmation)
            {
                confirmedOrder.status = OrderStatus.Finished;
                confirmedOrder.date_of_finish = DateTime.Now;
                SaveChangedOrder(confirmedOrder);
            }
            else if (confirmedOrder.status == OrderStatus.InProgress)
            {
                confirmedOrder.status = OrderStatus.AwaitsSupplierConfirmation;
                SaveChangedOrder(confirmedOrder);
            }
        }

        public List<Order> GetOrdersOfSupplier(int supplierId)
        {
            List<Order> allOrders = databaseAccess.GetAllOrders();
            List<Order> ordersOfSupplier = allOrders.Where(x => x.supplier_id == supplierId).ToList();
            return ordersOfSupplier;
        }

        public List<Order> GetAllOrders()
        {
            List<Order> allOrders = databaseAccess.GetAllOrders();
            return allOrders;
        }

        public void RecallOrder(Order order)
        {
            order.date_of_finish = DateTime.Now;
            databaseAccess.RecallOrder(order);
        }

        public void DeclineOrder(Order order)
        {
            order.date_of_finish = DateTime.Now;
            databaseAccess.DeclineOrder(order);
        }

        public List<Supplier> GetAllSuppliers()
        {
            return databaseAccess.GetAllSuppliers();
        }

        public Supplier GetSupplierByUserId(int userId)
        {
            return databaseAccess.GetAllSuppliers().Find(x => x.user_id == userId);
        }

        public void SaveChangedProduct(Product product)
        {
            databaseAccess.SaveChangedProduct(product);
        }

        public void SaveChangedOrder(Order order)
        {
            databaseAccess.SaveChangedOrder(order);
        }

        public void DeleteProduct(Product product)
        {
            databaseAccess.DeleteProduct(product);
        }

        public void AddProduct(Product product, int supplierId)
        {
            databaseAccess.AddProduct(product, supplierId);
        }

        public void AddOrder(Order order)
        {
            databaseAccess.AddOrder(order);
        }

        public void AcceptOrder(Order order)
        {
            databaseAccess.AcceptOrder(order);
        }

        public void SaveChangedUser(User user)
        {
            databaseAccess.SaveChangedUser(user);
        }
    }
}

public enum UserType
{
    None,
    Firm,
    Supplier
}