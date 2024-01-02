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
        Secretariat_Soft.CommForms.LoginFrm frm = new();
        DialogResult dr = frm.ShowDialog();
        if (dr == DialogResult.OK)
        {
            user_image.Image = frm.user_pictureBox1.Image;
            user_name_lbl.Text = frm.username_CB.Text;
            //--------------------------
            Secretariat_Soft.Properties.Settings.Default.User_name = frm.username_CB.Text;
            //--------------------------
            long id;
            long.TryParse(frm.sys_id_LBL.Text, out id);
            Secretariat_Soft.Properties.Settings.Default.User_Id = id;
            //--------------------------
            Properties.Settings.Default.Save();
            //--------------------------
            //==================================
            // -----------Load date-------------
            GetDateCal();
            // ----------Tree View _------------
            tree_panel.Visible = false;
            main_treeView.ExpandAll();
            //----------------------------------
            //==================================
        }
        else
        {
            //---wrong password
            MessageBox.Show("Exiting Application!");
            Application.Exit();
        }
        
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
            //-------------------------
            if (node_name == "Outgoing_Letters")
            {
                Secretariat_Soft.S_Forms.Out_Letters_List frm = new ();
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
