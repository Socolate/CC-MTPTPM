using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DAO
{
    class LOPDAO:DataProvide
    {
        public DataTable getlop()
        {
            DataTable dt=new DataTable();
            SqlCommand cmd = new SqlCommand("sp_getlop",conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;

        }
    }
}
