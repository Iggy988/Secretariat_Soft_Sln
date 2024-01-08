using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            //========load permission data======
            Secretariat_Soft.MyClasses.ComClass MyClass = new();
            MyClass.user_perm_loader_from_db();
            //==================================
            //==assign permission to controls===
            //MessageBox.Show(MyClass.get_permission_by_col_name("main_butt1").ToString());
            object_perm_loader();
            //==================================
        }
        else
        {
            //---wrong password
            MessageBox.Show("Exiting Application!");
            Application.Exit();
        }

    }

    void object_perm_loader()
    {
        Secretariat_Soft.MyClasses.ComClass MyClass = new();
        //--------load permissions by col name -------------------
        data_entry_button.Enabled = MyClass.get_permission_by_col_name("main_butt1"); //data entry
        //--------------------------------------------------------
        report_button.Enabled = MyClass.get_permission_by_col_name("main_butt2"); // reports
        in_toolStripMenuItem2.Enabled = MyClass.get_permission_by_col_name("main_butt2_m1"); // incoming letters
        out_toolStripMenuItem3.Enabled = MyClass.get_permission_by_col_name("main_butt2_m2"); // outcoming letters
        //--------------------------------------------------------
        tools_button.Enabled = MyClass.get_permission_by_col_name("main_butt3"); // tools
        usersToolStripMenuItem.Enabled = MyClass.get_permission_by_col_name("main_butt3_m1"); // users
        backupDataToolStripMenuItem.Enabled = MyClass.get_permission_by_col_name("main_butt3_m2"); // backup data
        restoreDataToolStripMenuItem.Enabled = MyClass.get_permission_by_col_name("main_butt3_m3"); // restore data
        //--------------------------------------------------------
        help_button.Enabled = MyClass.get_permission_by_col_name("main_butt4"); // help
        help_toolStripMenuItem1.Enabled = MyClass.get_permission_by_col_name("main_butt4_m1"); // help
        about_toolStripMenuItem2.Enabled = MyClass.get_permission_by_col_name("main_butt4_m2"); // about
        //--------------------------------------------------------
        if (Properties.Settings.Default.User_Id == Properties.Settings.Default.admin_user_id)
        {
            usersToolStripMenuItem.Enabled = true;
            tools_button.Enabled = true;
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
                Secretariat_Soft.S_Forms.Out_Letters_List frm = new();
                //MdiParent form je MainForm za In_Letters_List
                frm.MdiParent = this; //this == MainForm
                //-------------------------------
                frm.Show();
                //-------------------------------
                tree_panel.Visible = false;
            }
        }

    }

    private void tools_button_Click(object sender, EventArgs e)
    {
        int x, y;
        x = side_panel.Width + tools_button.Location.X; // X in screen
        y = tools_button.Location.Y + tools_button.Height; // Y in screen
        //-------------------------
        toold_cm.Show(new Point(x, y));
    }

    private void usersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Secretariat_Soft.CommForms.UserList frm = new();
        //frm.MdiParent = this;
        frm.ShowDialog();
        //----------------------
        object_perm_loader();
        //----------------------
    }

    private void report_button_Click(object sender, EventArgs e)
    {
        int x, y;
        x = side_panel.Width + report_button.Location.X; // X in screen
        y = report_button.Location.Y + report_button.Height; // Y in screen
        //-------------------------
        reports_cm.Show(new Point(x, y));
    }

    private void help_button_Click(object sender, EventArgs e)
    {
        int x, y;
        x = side_panel.Width + help_button.Location.X; // X in screen
        y = help_button.Location.Y + help_button.Height; // Y in screen
        //-------------------------
        help_cm.Show(new Point(x, y));
    }

    private void backupDataToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Secretariat_Soft.CommForms.BackupForm frm = new();
        frm.ShowDialog();
        //----------------------
    }

    private void restoreDataToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Secretariat_Soft.CommForms.RestoreForm frm = new();
        frm.ShowDialog();
        //----------------------
    }

    private void background_button_Click(object sender, EventArgs e)
    {
        bg_selector_panel2.Visible = !bg_selector_panel2.Visible;
        try
        {
            string thumb_fn = Application.StartupPath + "Data\\Pics\\Bg\\0_thumb.jpg";
            string fn = Application.StartupPath + "Data\\Pics\\Bg\\0.jpg";
            //------------------------
            if (System.IO.File.Exists(thumb_fn) == false)
            {
                //creating img from a FileStream if there is no existing thumbnail
                FileStream fs = new(fn, FileMode.Open);
                //-----------------------
                Image img = Image.FromStream(fs);
                fs.Close();
                fs.Dispose();
                //-----------------------
                //creating thumbnail
                img.GetThumbnailImage(100, 65, null, nint.Zero).Save(thumb_fn, ImageFormat.Jpeg);
            }
            //-----------------------
            //loading thumbnail
            FileStream fn_thumb = new FileStream(thumb_fn, FileMode.Open);
            bg3_radioButton4.BackgroundImage = Image.FromStream(fn_thumb);
            //-----------------------
            fn_thumb.Close();
            fn_thumb.Dispose();
            //-----------------------
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error! " + ex.Message);
        }
    }

  
}
