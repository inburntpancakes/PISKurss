using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISKursovaya.Model
{
    public class Supplier
    {
        public int user_id { get; set; }
        public string supplier_name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }

        public Supplier(OleDbDataReader reader)
        {
            user_id = (int)reader["user_id"];
            supplier_name = (string)reader["supplier_name"];
            address = (string)reader["address"];
            phone = (string)reader["phone"];
        }

        public Supplier() { }
    }
}
