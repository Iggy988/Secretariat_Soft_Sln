﻿using MyRep.DataSet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRep
{
    public partial class RepPreview : Form
    {
        public RepPreview()
        {
            InitializeComponent();
        }

        private void RepPreview_Load(object sender, EventArgs e)
        {
            string rep_fn, rpt_name, xml_fn; 
            MyRep.DataSet.Letters letters_ds = new MyRep.DataSet.Letters();
            //----------------------------
            rpt_name = Environment.GetCommandLineArgs()[1]; // 0 -> file name, 1 -> first param
            rep_fn = Application.StartupPath + "\\Data\\Reps\\" + rpt_name;
            //-----------------------------
          
            xml_fn = Application.StartupPath + "\\Data\\Reps\\help.mp3";
            //-----------------------------
            if (System.IO.File.Exists(xml_fn))
            {
                letters_ds.ReadXml(xml_fn);
            }
            
           // dataGridView1.DataSource = letters_ds;
            //dataGridView1.DataMember = "Sa_In_Letters";
            //--------------------
            reportDocument1.Load(rep_fn);
            reportDocument1.SetDataSource(letters_ds);
            //-----------------------------
            crystalReportViewer1.ReportSource = reportDocument1;
            crystalReportViewer1.RefreshReport();
            //-----------------------------
        }
    }
}
