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
        transparent_panel();
        background_image_changer_all();
        //---------------------------
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
                //frm.MdiParent = this; //this == MainForm
                //-------------------------------
                frm.ShowDialog();
                //-------------------------------
                tree_panel.Visible = false;
            }
            //-------------------------
            if (node_name == "Outgoing_Letters")
            {
                Secretariat_Soft.S_Forms.Out_Letters_List frm = new();
                //MdiParent form je MainForm za In_Letters_List
                //frm.MdiParent = this; //this == MainForm
                //-------------------------------
                frm.ShowDialog();
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
        //----------------------------
        selected_radiobutton_loaded();
        //----------------------------
        if (bg_selector_panel2.Visible == false)
        {
            thumb_image_loader("0.jpg", "0_thumb.jpg", bg1_radioButton);
            thumb_image_loader("1.jpg", "1_thumb.jpg", bg2_radioButton);
            thumb_image_loader("2.jpg", "2_thumb.jpg", bg3_radioButton);
            thumb_image_loader("3.jpg", "3_thumb.jpg", bg4_radioButton);
            thumb_image_loader("4.jpg", "4_thumb.jpg", bg5_radioButton);
            thumb_image_loader("5.jpg", "5_thumb.jpg", bg6_radioButton);
        }
        //----------------------------
        bg_selector_panel2.Visible = !bg_selector_panel2.Visible;
    }

    void selected_radiobutton_loaded()
    {
        //----------------------------
        string sel_bg;
        sel_bg = Properties.Settings.Default.selected_bg_name;
        //----------------------------
        if (sel_bg == "0.jpg") // first radio button
        {
            bg1_radioButton.Checked = true;
        }
        //----------------------------
        if (sel_bg == "1.jpg") // second radio button
        {
            bg2_radioButton.Checked = true;
        }
        //----------------------------
        if (sel_bg == "2.jpg") // third radio button
        {
            bg3_radioButton.Checked = true;
        }
        //----------------------------
        if (sel_bg == "3.jpg") // forth radio button
        {
            bg4_radioButton.Checked = true;
        }
        //----------------------------
        if (sel_bg == "4.jpg") // fifth radio button
        {
            bg5_radioButton.Checked = true;
        }
        //----------------------------
        if (sel_bg == "5.jpg") // sixth radio button
        {
            bg6_radioButton.Checked = true;
        }
        //----------------------------
    }

    void thumb_image_loader(string org_file_name, string thumb_file_name, System.Windows.Forms.RadioButton image_rb_name)
    {
        try
        {
            string thumb_fn = Application.StartupPath + "Data\\Pics\\Bg\\" + thumb_file_name;
            string fn = Application.StartupPath + "Data\\Pics\\Bg\\" + org_file_name;
            //------------------------
            // check if thumbnail file exists
            if (System.IO.File.Exists(thumb_fn) == false)
            {
                //loading original image in filestream
                FileStream fs = new(fn, FileMode.Open);
                //-----------------------
                Image img = Image.FromStream(fs);
                fs.Close();
                fs.Dispose();
                //-----------------------
                //creating thumbnail and save it
                img.GetThumbnailImage(100, 65, null, nint.Zero).Save(thumb_fn, ImageFormat.Jpeg);
            }
            //-----------------------
            //loading thumbnail
            FileStream fn_thumb = new FileStream(thumb_fn, FileMode.Open);
            image_rb_name.BackgroundImage = Image.FromStream(fn_thumb);
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

    void bg_image_loader(string org_file_name)
    {
        try
        {
            string fn = Application.StartupPath + "Data\\Pics\\Bg\\" + org_file_name;
            string fn_resized = Application.StartupPath + "Data\\Pics\\Bg\\tmp\\r_full_img.jpg";
            //------------------------
            // check if image file exists
            if (System.IO.File.Exists(fn) == true)
            {
                //loading image in filestream
                Image img = image_loader_from_file(fn);
                //Resize img to screen size
                Bitmap r_img = new(img, new Size(Width, Height));
                r_img.Save(fn_resized, System.Drawing.Imaging.ImageFormat.Jpeg);
                //=============================================
                //FileStream fs = new(fn, FileMode.Open);
                ////-----------------------
                //Image img = Image.FromStream(fs);
                //fs.Close();
                //fs.Dispose();
                //-----------------------
                //BackgroundImage = img;
                //-----------------------

                //=============================================
                Image im;
                //------------crop side panel img
                im = CropImage(r_img, side_panel.Location, side_panel.Size);
                fn = Application.StartupPath + "Data\\Pics\\Bg\\tmp\\r_side.jpg";
                //-------
                im.Save(fn, ImageFormat.Jpeg);
                //-------
                side_panel.BackgroundImage = im;


                //------------crop top panel img
                im = CropImage(r_img, top_panel.Location, top_panel.Size);
                fn = Application.StartupPath + "Data\\Pics\\Bg\\tmp\\r_top.jpg";
                //-------
                im.Save(fn, ImageFormat.Jpeg);
                //-------
                top_panel.BackgroundImage = im;

                //------------crop bottom panel img
                im = CropImage(r_img, bottom_panel.Location, bottom_panel.Size);
                fn = Application.StartupPath + "Data\\Pics\\Bg\\tmp\\r_bott.jpg";
                //-------
                im.Save(fn, ImageFormat.Jpeg);
                //-------
                bottom_panel.BackgroundImage = im;

                //------------crop center panel img
                Point main_point = new(top_panel.Location.X, top_panel.Location.Y + top_panel.Height);
                Size main_size = new(top_panel.Width, this.Height - top_panel.Height - bottom_panel.Height);
                im = CropImage(r_img, main_point, main_size);
                fn = Application.StartupPath + "Data\\Pics\\Bg\\tmp\\r_center.jpg";
                //-------
                im.Save(fn, ImageFormat.Jpeg);
                //-------
                BackgroundImage = im;


                //=============================================
            }
            //-----------------------
            Secretariat_Soft.Properties.Settings.Default.selected_bg_name = org_file_name;
            Secretariat_Soft.Properties.Settings.Default.Save();
            //-----------------------
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error! " + ex.Message);
        }
    }

    void transparent_panel()
    {
        overlay_side_panel2.BackColor = Color.FromArgb(40, Color.Black);
        overlay_top_panel2.BackColor = Color.FromArgb(40, Color.Black);
        overlay_bott_panel2.BackColor = Color.FromArgb(40, Color.Black);
        //-----------
        side_panel.BackColor = Color.FromArgb(40, Color.Black);
        analogClock1.BackColor = Color.FromArgb(40, Color.Black);
        panel1.BackColor = Color.FromArgb(40, Color.Black);
        //-----------
        data_entry_button.BackColor = Color.FromArgb(150, Color.WhiteSmoke);
        report_button.BackColor = Color.FromArgb(150, Color.WhiteSmoke);
        tools_button.BackColor = Color.FromArgb(150, Color.WhiteSmoke);
        help_button.BackColor = Color.FromArgb(150, Color.WhiteSmoke);
        //------------
        user_name_lbl.BackColor = Color.FromArgb(150, Color.WhiteSmoke);
    }

    void background_image_changer_all()
    {
        string fn;
        Image img;
        //--------------
        //---sidebar bg loader
        fn = Application.StartupPath + "Data\\Pics\\Bg\\tmp\\r_side.jpg";
        if (File.Exists(fn) == true)
        {
            img = image_loader_from_file(fn);
            side_panel.BackgroundImage = img;
        }
        //--------------
        //---top panel bg loader
        fn = Application.StartupPath + "Data\\Pics\\Bg\\tmp\\r_top.jpg";
        if (File.Exists(fn) == true)
        {
            img = image_loader_from_file(fn);
            top_panel.BackgroundImage = img;
        }
        //--------------
        //---bottom panel bg loader
        fn = Application.StartupPath + "Data\\Pics\\Bg\\tmp\\r_bott.jpg";
        if (File.Exists(fn) == true)
        {
            img = image_loader_from_file(fn);
            bottom_panel.BackgroundImage = img;
        }
        //--------------
        //---center panel bg loader
        fn = Application.StartupPath + "Data\\Pics\\Bg\\tmp\\r_center.jpg";
        if (File.Exists(fn) == true)
        {
            img = image_loader_from_file(fn);
            this.BackgroundImage = img;
        }
    }


    Image image_loader_from_file(string image_file_name)
    {
        FileStream fs = new(image_file_name, FileMode.Open);
        Image img = Image.FromStream(fs);
        //----------------
        fs.Close();
        fs.Dispose();
        //----------------
        return img;
    }

    public Image CropImage(Image srcBmp, Point startPoint, Size cropSize)
    {
        Bitmap destBmp = new(cropSize.Width, cropSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
        Graphics g = Graphics.FromImage(destBmp);
        Rectangle srcRect = new(startPoint, cropSize);
        Rectangle destRect = new(new Point(0, 0), cropSize);
        g.DrawImage(srcBmp, destRect, srcRect, GraphicsUnit.Pixel);
        return destBmp;
    }

    private void bg1_radioButton_Click(object sender, EventArgs e)
    {
        if (select_radioButton1.Checked == true)
        {
            bg_image_loader("0.jpg");
        }
        else
        {
            custom_image_chooser("0.jpg", "0_thumb.jpg", bg1_radioButton);
        }
    }

    private void bg2_radioButton_Click(object sender, EventArgs e)
    {
        if (select_radioButton1.Checked == true)
        {
            bg_image_loader("1.jpg");
        }
        else
        {
            custom_image_chooser("1.jpg", "1_thumb.jpg", bg2_radioButton);
        }
    }

    private void bg3_radioButton_Click(object sender, EventArgs e)
    {
        if (select_radioButton1.Checked == true)
        {
            bg_image_loader("2.jpg");
        }
        else
        {
            custom_image_chooser("2.jpg", "3_thumb.jpg", bg3_radioButton);
        }
    }

    private void bg4_radioButton_Click(object sender, EventArgs e)
    {
        if (select_radioButton1.Checked == true)
        {
            bg_image_loader("3.jpg");
        }
        else
        {
            custom_image_chooser("3.jpg", "3_thumb.jpg", bg4_radioButton);
        }
    }

    private void bg5_radioButton_Click(object sender, EventArgs e)
    {
        if (select_radioButton1.Checked == true)
        {
            bg_image_loader("4.jpg");
        }
        else
        {
            custom_image_chooser("4.jpg", "5_thumb.jpg", bg5_radioButton);
        }
    }

    private void bg6_radioButton_Click(object sender, EventArgs e)
    {
        if (select_radioButton1.Checked == true)
        {
            bg_image_loader("5.jpg");
        }
        else
        {
            custom_image_chooser("5.jpg", "6_thumb.jpg", bg6_radioButton);
        }
    }

    void custom_image_chooser(string org_img_file_name, string thumb_img_file_name, RadioButton r_button)
    {
        OpenFileDialog dlg = new OpenFileDialog();
        DialogResult dr;
        dlg.Filter = "Jpg Files|*.jpg";
        dr = dlg.ShowDialog();
        if (dr == DialogResult.OK)
        {
            string sfn, dfn, thumb_name;
            sfn = dlg.FileName;
            //--------Copy custom imnage to app folder---------------
            dfn = Application.StartupPath + "Data\\Pics\\Bg\\" + org_img_file_name;
            File.Copy(sfn, dfn, true);
            //-----------------
            bg_image_loader(org_img_file_name);
            //--------load thumbnail----------
            thumb_name = "Data\\Pics\\Bg\\" + thumb_img_file_name;
            File.Delete(thumb_name);
            //-----------------
            thumb_image_loader(org_img_file_name, thumb_img_file_name, r_button);
        }
    }

    private void in_toolStripMenuItem2_Click(object sender, EventArgs e)
    {
        Secretariat_Soft.S_Forms.In_Letters_List frm = new();
        //frm.MdiParent = this;
        //-------------------
        frm.add_butt.Visible = false;
        //-------------------
        frm.ShowDialog();
    }

    private void out_toolStripMenuItem3_Click(object sender, EventArgs e)
    {
        Secretariat_Soft.S_Forms.Out_Letters_List frm = new();
        //frm.MdiParent = this;
        //-------------------
        frm.add_butt.Visible = false;
        //-------------------
        frm.ShowDialog();
    }

    private void MainForm_KeyDown(object sender, KeyEventArgs e)
    {

        //-----------------------
        //if (this.ActivateMdiChild != null)
        //{
            
        //    return;
        //}
        //-----------------------
        switch (e.KeyCode)
        {
            case Keys.F2:
                if (data_entry_button.Enabled == true)
                {
                    data_entry_button_Click(sender, e);
                }
                //---------------
                break;
            case Keys.F3:
                if (report_button.Enabled == true)
                {
                    report_button_Click(sender, e);
                }
                break;
            case Keys.F4:
                if (tools_button.Enabled == true)
                {
                    tools_button_Click(sender, e);
                }
                break;
            case Keys.F5:
                if (help_button.Enabled == true)
                {
                    help_button_Click(sender, e);
                }
                break;
            default:
                break;


        }
    }
}
