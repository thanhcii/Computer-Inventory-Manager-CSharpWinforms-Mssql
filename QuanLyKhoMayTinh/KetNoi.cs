using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhoMayTinh
{
    class KetNoi
    {
        //Download source code tại Sharecode.vn
        public SqlConnection taoketnoi()
        {
            return new SqlConnection(@"server = HP-91149BFA9401\SQLEXPRESS;uid = admin;pwd=admin");
        }
        public DataTable hienthi(string sql)
        {
            SqlConnection sqlConn = taoketnoi();
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDa = new SqlDataAdapter(sql, sqlConn);
            sqlDa.Fill(dt);
            return dt;
        }
        public void capnhat(string sql)
        {
            SqlConnection sqlConn = taoketnoi();
            sqlConn.Open();
            SqlCommand sqlComm = new SqlCommand(sql, sqlConn);
            sqlComm.ExecuteNonQuery();
            sqlComm.Dispose();
            sqlConn.Close();
        }
     
        
        
        
    }
}
