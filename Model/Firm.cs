using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISKursovaya.Model
{
    public class Firm
    {
        public int user_id { get; set; }
        public string firm_name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }

        public Firm(OleDbDataReader reader)
        {
            user_id = (int)reader["user_id"];
            firm_name = (string)reader["firm_name"];
            address = (string)reader["address"];
            phone = (string)reader["phone"];
        }

        public Firm() { }
    }
}
