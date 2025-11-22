using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Aplikasi_Manajemen_Studio
{
    internal class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source = GFORCE\\SQLEXPRESS01 ; initial catalog = db_sarpras_sekolah; integrated security = true";
            return Conn;
        }

    }
}
