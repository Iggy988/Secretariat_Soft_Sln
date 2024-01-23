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
public partial class SQL_Settings : Form
{
    public SQL_Settings()
    {
        InitializeComponent();
    }
    

    private void exit_button_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
    }

    private void save_button1_Click(object sender, EventArgs e)
    {

        //-----------save in app settings--------
        string cs, cs_enct;
        cs = con_generator();
        //----------------------
        cs_enct =NETCore.Encrypt.EncryptProvider.AESEncrypt(cs, MyClasses.ComClass.dfftrf);
        //----------------------
        Secretariat_Soft.Properties.Settings.Default.main_con_text = cs_enct;
        Secretariat_Soft.Properties.Settings.Default.is_sql_auth = sql_server_auth_radioButton1.Checked;
        Secretariat_Soft.Properties.Settings.Default.Save();
        //---------------------------------------
        DialogResult = DialogResult.OK;
    }

    string con_generator()
    {
        //Data Source=DESKTOP-8R3MVUS\SQLEXPRESS01;Initial Catalog=CsApps;Integrated Security=True;TrustServerCertificate=True
        //Data Source=DESKTOP-8R3MVUS\SQLEXPRESS01;Initial Catalog=CsApps;Persist Security Info=True;User ID=igo;Password=12345;TrustServerCertificate=True
        string MyCon = "";
        //Win authentication
        if (win_authentication_radioButton1.Checked == true)
        {
            MyCon = "Data Source=" + server_name_textBox1.Text +
                ";Initial Catalog=" + database_textBox1.Text +
                ";Integrated Security=True;TrustServerCertificate=True";
        }
        //SQL authentication
        else
        {
            MyCon = "Data Source=" + server_name_textBox1.Text +
               ";Initial Catalog=" + database_textBox1.Text +
               ";Persist Security Info=True;User ID=" +
               username_textBox1.Text +
               ";Password=" + password_textBox1.Text +
               ";TrustServerCertificate=True";
        }
        //---------
        return MyCon;

    }

    private void SQL_Settings_Load(object sender, EventArgs e)
    {
        //Data Source=DESKTOP-8R3MVUS\SQLEXPRESS01;Initial Catalog=CsApps;Integrated Security=True;TrustServerCertificate=True
        //Data Source=DESKTOP-8R3MVUS\SQLEXPRESS01;Initial Catalog=CsApps;Persist Security Info=True;User ID=igo;Password=12345;TrustServerCertificate=True

        authentication_panel1.Visible = false;
        //-----------------------------------
        bool is_sql_auth = false;
        is_sql_auth = Secretariat_Soft.Properties.Settings.Default.is_sql_auth;
        //------load connection string -------
        string MyCon = Secretariat_Soft.Properties.Settings.Default.main_con_text;
        //-------------------
        MyCon = NETCore.Encrypt.EncryptProvider.AESDecrypt(MyCon, MyClasses.ComClass.dfftrf);
        //-------------------
        string[] con_parts;
        string[] final_parts;
        string MyData;
        //---------------------------
        con_parts = MyCon.Split(";");
        //--------server name separator-------
        MyData = con_parts[0]; //Data Source=DESKTOP-8R3MVUS\SQLEXPRESS01
                               //------------------------------------

        final_parts = MyData.Split("=");
        server_name_textBox1.Text = final_parts[1];
        //------------------------------------

        //---------datbase name separator-----
        MyData = con_parts[1]; //Initial Catalog=CsApps
        final_parts = MyData.Split("=");
        database_textBox1.Text = final_parts[1];
        //------------------------------------
        if (is_sql_auth == true)
        {
            //---------user name separator-----
            MyData = con_parts[3]; //User ID=igo;
            //-----------------------------------
            final_parts = MyData.Split("=");
            username_textBox1.Text = final_parts[1];
            //------------------------------------
            //---------password separator-----
            MyData = con_parts[4]; //Password=12345
            final_parts = MyData.Split("=");
            password_textBox1.Text = final_parts[1];
            //------------------------------------
        }
        //--------------
        sql_server_auth_radioButton1.Checked = is_sql_auth;
        //-------------
    }

    private void sql_server_auth_radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        authentication_panel1.Visible = sql_server_auth_radioButton1.Checked;
    }

    private void test_connection_button1_Click(object sender, EventArgs e)
    {
        string MyCon = con_generator();
        //------------------
        //==========db exist checker================
        Secretariat_Soft.DataSet.LettersTableAdapters.AppUsersTableAdapter ta = new();
        Secretariat_Soft.DataSet.Letters ds = new();
        //-----------------
        prog_panel4.Visible = true;
        prog_panel4.Refresh();
        try
        {
            ta.Connection.ConnectionString = MyCon;
            ta.FillBy_db_exists_checker(ds.AppUsers);
            //---------------
            prog_panel4.Visible = false;
            prog_panel4.Refresh();
            
            MessageBox.Show("Test connection successfull.");
            //---------------
        }
        catch (Exception ex)
        {
            prog_panel4.Visible = false;
            prog_panel4.Refresh();
            MessageBox.Show("Error! Can't get access to your SQL database: " + ex.Message);
            return;
        }
        //==========================================
    }
}
