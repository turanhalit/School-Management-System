using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ICR1VHI\SQLEXPRESS;Initial Catalog=Dbschool;Integrated Security=True");
    }
}
