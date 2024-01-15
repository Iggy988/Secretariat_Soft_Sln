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
            string rep_fn;
            MyRep.DataSet.Letters letters_ds = new MyRep.DataSet.Letters();
            rep_fn = Application.StartupPath + "\\Data\\Reps\\InputList.rpt";
            //-----------------------------
            reportDocument1.Load(rep_fn);
            //reportDocument1.SetDataSource(letters_ds);
            //-----------------------------
            crystalReportViewer1.ReportSource = reportDocument1;
            crystalReportViewer1.RefreshReport();
            //-----------------------------
        }
    }
}
