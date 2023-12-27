using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretariat_Soft;
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void close_button_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void min_button_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        // -----------Load date-------------
        GetDateCal();
        // ---------------------------------
        tree_panel.Visible = false;
        main_treeView.ExpandAll();
        //----------------------------------
    }

    void GetDateCal()
    {
        year_num_lbl.Text = DateTime.Now.Year.ToString();
        int mn = DateTime.Now.Month;
        var monthName = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mn);
        month_name_lbl.Text = monthName.ToString();
        day_month_lbl.Text = DateTime.Now.Day.ToString();
        day_in_week_lbl.Text = DateTime.Now.DayOfWeek.ToString();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        analogClock1.Time = DateTime.Now;
    }

    private void data_entry_button_Click(object sender, EventArgs e)
    {
        tree_panel.Visible = !tree_panel.Visible;
    }

    private void expand_btn_Click(object sender, EventArgs e)
    {
        main_treeView.ExpandAll();
    }

    private void collapse_btn_Click(object sender, EventArgs e)
    {
        main_treeView.CollapseAll();
    }

    private void main_treeView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (main_treeView.SelectedNode is not null)
        {
            string node_name;
            node_name = main_treeView.SelectedNode.Name;
            //--------------------
            if (node_name == "Incoming_Letters")
            {
                Secretariat_Soft.S_Forms.In_Letters_List frm = new S_Forms.In_Letters_List();
                //MdiParent form je MainForm za In_Letters_List
                frm.MdiParent = this; //this == MainForm
                //-------------------------------
                frm.Show();
                //-------------------------------
                tree_panel.Visible = false;
            }
        }
        
    }
}
