using System;
using System.Data.OleDb;

namespace PISKursovaya
{
    public class Product
    {
        public string product_article { get; set; }
        public string product_name { get; set; }
        public int supplier_id { get; set; }
        public decimal cost { get; set; }
        public bool is_on_sale { get; set; }

        public Product(OleDbDataReader reader)
        {
            product_article = (string)reader["product_article"];
            product_name = (string)reader["product_name"];
            supplier_id = (int)reader["supplier_id"];
            cost = Convert.ToDecimal(reader["cost"]);
            is_on_sale = (string)reader["is_on_sale"] == "True" ? true : false;
        }

        public Product() { }
    }
}
