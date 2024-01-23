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
public partial class BackupForm : Form
{
    public BackupForm()
    {
        InitializeComponent();
    }

    private void browse_button1_Click(object sender, EventArgs e)
    {
        DialogResult dr = folderBrowserDialog1.ShowDialog();
        if (dr == DialogResult.OK)
        {
            string d = DateTime.Now.ToString("dd-MM-yyyy-HH-mm");
            string fn = folderBrowserDialog1.SelectedPath + "\\" + d + ".s24";
            //-----------------------
            filename_textBox1.Text = fn;
        }
    }

    private void exit_button2_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void backup_button1_Click(object sender, EventArgs e)
    {
        if (filename_textBox1.Text == "")
        {
            MessageBox.Show("File name is not valid!");
            return;
        }
        //--------------------------
        prog_panel4.Show();
        prog_panel4.Refresh();
        //--------------------------
        backup_button1.Enabled = false;
        backup_button1.Refresh();
        //--------------------------
        string con_string = Secretariat_Soft.MyClasses.ComClass.MyConn_String;//"Data Source=DESKTOP-8R3MVUS\\SQLEXPRESS01;Initial Catalog=CsApps;Persist Security Info=True;User ID=igo;Password=12345;TrustServerCertificate=True";
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
            string fcomment = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm");
            //-------------------
            string backup_query_text = "BACKUP DATABASE [CsApps] " +
                "TO  DISK = N'" + filename_textBox1.Text +"' " +
                "WITH NOFORMAT, INIT, " +
                "NAME = N'My_Backup_"+fcomment+"', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            //-------------------
            sqlCommand.CommandText = backup_query_text;
            sqlCommand.ExecuteNonQuery();
            //-------------------
            conn.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error! " + ex.Message);
        }
        //-----------file size checker--------------
        long fs, fs_kb;
        string err_msg = "";
        try
        {
            System.IO.FileInfo fi = new(filename_textBox1.Text);
            fs = fi.Length;
            
        }
        catch (Exception ex)
        {
            fs = -1;
            err_msg = ex.Message;
        }
        //-------------------------------------------
        //--------------------------
        prog_panel4.Hide();
        prog_panel4.Refresh();
        //--------------------------
        backup_button1.Enabled = true;
        backup_button1.Refresh();
        //--------------------------

        if (fs <= 0) //Backup failed
        {
            MessageBox.Show("Error! Backup failed! " + err_msg);
        }
        else //Backup is done
        {
            fs_kb = fs / 1024;
            MessageBox.Show("Backup is done! File size: " + fs_kb.ToString()+ " KB.");
            Close();
        }
        //-------------------------------------------
    }
}
