using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace QuanLyKhoMayTinh
{
    public partial class frmBaoCaoKhachHang : Form
    {
        public frmBaoCaoKhachHang()
        {
            InitializeComponent();
        }
        
        private void frmBaoCaoKhachHang_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM KHACHHANG";
            SqlConnection sqlConn = new SqlConnection(@"server = HP-91149BFA9401\SQLEXPRESS;uid = admin;pwd=admin");
            SqlDataAdapter sqlDa = new SqlDataAdapter(sql,sqlConn);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            rptKhachHang cr = new rptKhachHang();
            cr.SetDataSource(dt);
            rptKhachHang.ReportSource = cr;
            
        }

        
    }
}
