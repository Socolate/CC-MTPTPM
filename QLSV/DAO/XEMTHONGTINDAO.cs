using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.DTO;

namespace QLSV.DAO
{
    class XEMTHONGTINDAO:DataProvide
    {
       
        public DataTable getTTSV()
        {   
            DataTable dt=new DataTable();
            SqlCommand cmd = new SqlCommand("sp_getTTSV",conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}
