using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bank_Management_System
{
    class Connect
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public string locate = "Data Source=KINGGRAPHICSPC\\SQLEXPRESS;Initial Catalog=dblogin;Integrated Security=True";
    }
}
