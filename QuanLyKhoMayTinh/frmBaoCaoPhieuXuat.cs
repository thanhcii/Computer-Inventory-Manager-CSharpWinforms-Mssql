﻿using System;
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
    public partial class frmBaoCaoPhieuXuat : Form
    {
        public frmBaoCaoPhieuXuat()
        {
            InitializeComponent();
        }

        private void frmBaoCaoPhieuXuat_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"server = HP-91149BFA9401\SQLEXPRESS;uid = admin;pwd=admin");
            string sql = "SELECT *FROM PHIEUXUAT";
            SqlDataAdapter sqlDa = new SqlDataAdapter(sql, sqlConn);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            rptPhieuXuat cr = new rptPhieuXuat();
            cr.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
