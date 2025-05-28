using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace PISKursovaya
{
    public class Order
    {
        public int order_id { get; set; }
        public int supplier_id { get; set; }
        public string product_article { get; set; }
        public OrderStatus status;
        public string orderStatus { get => GetStringByOrderStatus(status); }
        public int quantity { get; set; }
        public decimal cost { get; set; }
        public DateTime date_of_order { get; set; }
        public DateTime date_of_finish { get; set; }

        private static Dictionary<string, OrderStatus> StringToOrderStatus = new Dictionary<string, OrderStatus>()
        {
            { "Неизвестно", OrderStatus.Unknown},
            { "В процессе", OrderStatus.InProgress},
            { "Ожидает подтверждение фирмы", OrderStatus.AwaitsFirmConfirmation},
            { "Ожидает подтверждение поставщика", OrderStatus.AwaitsSupplierConfirmation },
            { "Выполнено", OrderStatus.Finished },
            { "Отказан поставщиком", OrderStatus.DeclinedBySupplier },
            { "Отозван фирмой", OrderStatus.RecalledByFirm },
            { "Ожидает принятие поставщиком", OrderStatus.AwaitsSupplierAcceptance },
        };

        public static string GetStringByOrderStatus(OrderStatus orderStatus)
        {
            return StringToOrderStatus.FirstOrDefault(x => x.Value == orderStatus).Key;
        }

        public static OrderStatus GetOrderStatusByString(string orderStatus)
        {
            return StringToOrderStatus[orderStatus];
        }

        public Order(OleDbDataReader reader)
        {
            order_id = (int)reader["order_id"];
            supplier_id = (int)reader["supplier_id"];
            product_article = (string)reader["product_article"];
            status = StringToOrderStatus[(string)reader["status"]];
            quantity = (int)reader["quantity"];
            cost = (decimal)reader["cost"];
            date_of_order = reader["date_of_order"] is DBNull ? DateTime.MinValue : (DateTime)reader["date_of_order"];
            date_of_finish = reader["date_of_finish"] is DBNull ? DateTime.MinValue : (DateTime)reader["date_of_finish"];
        }

        public Order(int supplier_id, string product_article, int quantity, decimal cost)
        {
            this.supplier_id = supplier_id;
            this.product_article = product_article;
            this.quantity = quantity;
            this.cost = cost;
        }

        public Order() { }
    }

    public enum OrderStatus
    {
        Unknown,
        InProgress,
        AwaitsSupplierAcceptance,
        RecalledByFirm,
        DeclinedBySupplier,
        AwaitsFirmConfirmation,
        AwaitsSupplierConfirmation,
        Finished
    }
}
