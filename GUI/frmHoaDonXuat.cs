﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BAL;
namespace GUI
{
    public partial class frmHoaDonXuat : Form
    {
        HoaDonBAL HoaDonBAL;
        public frmHoaDonXuat(string conn)
        {
            HoaDonBAL = new HoaDonBAL(conn);
            InitializeComponent();



            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            //sqlDataSource1.Fill();
        }

        private void frmHoaDonXuat_Load(object sender, EventArgs e)
        {
           // LoadData();
        }
        void LoadData()
        {
            gridHoaDonXuat.DataSource = HoaDonBAL.LayHoaDonXuat();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
