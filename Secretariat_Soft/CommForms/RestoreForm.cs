using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretariat_Soft.CommForms;
public partial class RestoreForm : Form
{
    public RestoreForm()
    {
        InitializeComponent();
    }

    private void exit_button2_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void browse_button1_Click(object sender, EventArgs e)
    {
        OpenFileDialog dlg = new OpenFileDialog();
        //-----------------------
        DialogResult dr;
        //---filter--------------
        dlg.Filter = "Backup Files|*.s24";
        //-----------------------
        dr = dlg.ShowDialog();
        //-----------------------
        if (dr == DialogResult.OK)
        {
            string fn = dlg.FileName;
            //-----------------
            restore_textBox1.Text = fn;

        }
    }

    private void restore_button1_Click(object sender, EventArgs e)
    {
        if (restore_textBox1.Text == "")
        {
            MessageBox.Show("File name is not valid!");
            return;
        }
        //==========================================
        //-----------file size checker--------------
        long fs;
        string err_msg = "";
        try
        {
            System.IO.FileInfo fi = new(restore_textBox1.Text);
            fs = fi.Length;

        }
        catch (Exception ex)
        {
            fs = -1;
            err_msg = ex.Message;
        }
        //-------------------------------------------
        

        if (fs <= 0) // ivalid Backup file
        {
            MessageBox.Show("Error! Invalid Backup File! " + err_msg);
            return;
        }

        //-------------------------------------------
        //==========db exist checker================
        Secretariat_Soft.DataSet.LettersTableAdapters.AppUsersTableAdapter ta = new();
        Secretariat_Soft.DataSet.Letters ds = new();
        //-----------------
        try
        {
            ta.FillBy_db_exists_checker(ds.AppUsers);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error! " +  ex.Message);
            return;
        }
        //==========================================
        //--------------------------
        prog_panel4.Show();
        prog_panel4.Refresh();
        //--------------------------
        restore_button1.Enabled = false;
        restore_button1.Refresh();
        //--------------------------
        string con_string = "Data Source=DESKTOP-8R3MVUS\\SQLEXPRESS01;Initial Catalog=CsApps;Persist Security Info=True;User ID=igo;Password=12345;TrustServerCertificate=True";
        System.Data.SqlClient.SqlConnection conn = new(con_string);
        //==========================
        System.Data.SqlClient.SqlCommand sqlCommand = new();
        sqlCommand.Connection = conn;
        //==========================
        try
        {
            sqlCommand.CommandTimeout = 20;
            conn.Open();
            //-------------------
            string restore_query_text = "USE [master] " +
                " ALTER DATABASE [CsApps] SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                " RESTORE DATABASE [CsApps] " +
                " FROM  DISK = N'"+restore_textBox1.Text+"' " +
                " WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 5 " +
                " ALTER DATABASE [CsApps] SET MULTI_USER";
            //-------------------
            sqlCommand.CommandText = restore_query_text;
            sqlCommand.ExecuteNonQuery();
            //-------------------
            conn.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error! " + ex.Message);
        }

        //--------------------------
        prog_panel4.Hide();
        prog_panel4.Refresh();
        //--------------------------
        restore_button1.Enabled = true;
        restore_button1.Refresh();
        //--------------------------
        //File Restored Successfully!
        MessageBox.Show("File Restored Successfully!" );

    }
}
