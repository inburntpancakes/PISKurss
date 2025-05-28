using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISKursovaya.Model
{
    public class User
    {
        public int user_id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public Role role { get; set; }

        public bool need_change_password;

        public User(OleDbDataReader reader)
        {
            user_id = (int)reader["user_id"];
            login = (string)reader["login"];
            password = (string)reader["password"];
            role = (Role)Enum.Parse(typeof(Role), (string)reader["role"]);
            need_change_password = (string)reader["need_change_password"] == "True" ? true : false;
        }

        public User() { }
    }
}

public enum Role
{
    Unknown,
    Firm,
    Supplier
}