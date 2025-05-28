using PISKursovaya.Logic;
using PISKursovaya.Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISKursovaya.Logic
{
    public class DataBaseAccess : IDatabaseAccess
    {
        private OleDbConnection conn;

        public DataBaseAccess(string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=SupplierFirm.mdb")
        {
            conn = new OleDbConnection(connectionString);
            conn.Open();
        }

        public List<User> GetAllUsers()
        {
            OleDbCommand cmd = new OleDbCommand($"SELECT * FROM users", conn);
            OleDbDataReader reader = cmd.ExecuteReader();

            List<User> users = new List<User>();
            while (reader.Read())
            {
                User newUser = new User(reader);
                users.Add(newUser);
            }
            return users;
        }

        public List<Order> GetAllOrders()
        {
            OleDbCommand cmd = new OleDbCommand($"SELECT * FROM orders ORDER BY date_of_finish DESC, date_of_order DESC", conn);
            OleDbDataReader reader = cmd.ExecuteReader();

            List<Order> orders = new List<Order>();
            while (reader.Read())
            {
                Order newOrder = new Order(reader);
                orders.Add(newOrder);
            }
            return orders;
        }

        public List<Product> GetAllProducts()
        {
            OleDbCommand cmd = new OleDbCommand($"SELECT * FROM products", conn);
            OleDbDataReader reader = cmd.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product newProduct = new Product(reader);
                products.Add(newProduct);
            }
            return products;
        }

        public List<Supplier> GetAllSuppliers()
        {
            OleDbCommand cmd = new OleDbCommand($"SELECT * FROM suppliers", conn);
            OleDbDataReader reader = cmd.ExecuteReader();

            List<Supplier> suppliers = new List<Supplier>();
            while (reader.Read())
            {
                Supplier newSupplier = new Supplier(reader);
                suppliers.Add(newSupplier);
            }
            return suppliers;
        }

        public List<Firm> GetAllFirms()
        {
            OleDbCommand cmd = new OleDbCommand($"SELECT * FROM firms", conn);
            OleDbDataReader reader = cmd.ExecuteReader();

            List<Firm> firms = new List<Firm>();
            while (reader.Read())
            {
                Firm newFirm = new Firm(reader);
                firms.Add(newFirm);
            }
            return firms;
        }

        public void SaveChangedProduct(Product product)
        {
            OleDbCommand cmd = new OleDbCommand($"UPDATE products SET product_name = '{product.product_name}', cost = {product.cost}, is_on_sale = '{(product.is_on_sale == true ? "True" : "False")}' WHERE product_article = '{product.product_article}'", conn);
            cmd.ExecuteNonQuery();
        }

        public void SaveChangedOrder(Order order)
        {
            OleDbCommand cmd = new OleDbCommand($"UPDATE orders SET status = '{Order.GetStringByOrderStatus(order.status)}', date_of_order = '{order.date_of_order}', product_article = '{order.product_article}', date_of_finish = {(order.date_of_finish == DateTime.MinValue ? "NULL" : $"'{order.date_of_finish.ToShortDateString()}'")} WHERE order_id = {order.order_id}", conn);
            cmd.ExecuteNonQuery();
        }

        public void DeleteProduct(Product product)
        {
            OleDbCommand cmd = new OleDbCommand($"DELETE FROM products WHERE product_article = '{product.product_article}'", conn);
            cmd.ExecuteNonQuery();
        }

        public void AddProduct(Product product, int supplierId)
        {
            OleDbCommand cmd = new OleDbCommand($"INSERT INTO products VALUES ('{product.product_article}', '{product.product_name}', {supplierId}, {product.cost}, '{(product.is_on_sale == true ? "True" : "False")}')", conn);
            cmd.ExecuteNonQuery();
        }

        public void AddOrder(Order order)
        {
            OleDbCommand cmd = new OleDbCommand($"INSERT INTO orders (supplier_id, status, cost, date_of_order, product_article, quantity, date_of_finish) VALUES ({order.supplier_id},'{Order.GetStringByOrderStatus(OrderStatus.AwaitsSupplierAcceptance)}', {order.cost}, '{DateTime.Now.ToShortDateString()}', '{order.product_article}', {order.quantity}, null)", conn);
            cmd.ExecuteNonQuery();
        }

        public void RecallOrder(Order order)
        {
            OleDbCommand cmd = new OleDbCommand($"UPDATE orders SET status = '{Order.GetStringByOrderStatus(OrderStatus.RecalledByFirm)}', date_of_finish = '{order.date_of_finish.ToShortDateString()}' WHERE order_id = {order.order_id}", conn);
            cmd.ExecuteNonQuery();
        }

        public void DeclineOrder(Order order)
        {
            OleDbCommand cmd = new OleDbCommand($"UPDATE orders SET status = '{Order.GetStringByOrderStatus(OrderStatus.DeclinedBySupplier)}', date_of_finish = '{order.date_of_finish.ToShortDateString()}' WHERE order_id = {order.order_id}", conn);
            cmd.ExecuteNonQuery();
        }

        public void AcceptOrder(Order order)
        {
            OleDbCommand cmd = new OleDbCommand($"UPDATE orders SET status = '{Order.GetStringByOrderStatus(OrderStatus.InProgress)}' WHERE order_id = {order.order_id}", conn);
            cmd.ExecuteNonQuery();
        }

        public void SaveChangedUser(User user)
        {
            OleDbCommand cmd = new OleDbCommand($"UPDATE users SET need_change_password = '{(user.need_change_password == true ? "True" : "False")}', [password] = '{user.password}' WHERE user_id = {user.user_id}", conn);
            cmd.ExecuteNonQuery();
        }
    }
}
