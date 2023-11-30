using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GO_Game
{
    class Ketnoi
    {
        string conStr = @"Data Source=DESKTOP-DU2RDFE;Initial Catalog=Go_Game;Integrated Security=True";
        SqlConnection conn;
        public Ketnoi()
        {
            conn = new SqlConnection(conStr);
        }

        public DataSet LayDuLieu(string truyvan)
        {
            SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public bool ThucThi(string truyvan)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(truyvan, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return r > 0;
        }
    }
}
