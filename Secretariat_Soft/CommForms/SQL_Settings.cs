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
        //Data Source=DESKTOP-8R3MVUS\SQLEXPRESS01;Initial Catalog=CsApps;Integrated Security=True;TrustServerCertificate=True
        //Data Source=DESKTOP-8R3MVUS\SQLEXPRESS01;Initial Catalog=CsApps;Persist Security Info=True;User ID=igo;Password=12345;TrustServerCertificate=True
        string MyCon = "";
        //Win authentication
        if (win_authentication_radioButton1.Checked == true)
        {
            MyCon = "Data Source=" + server_name_textBox1.Text + 
                ";Initial Catalog=" + database_textBox1.Text+
                ";Integrated Security=True;TrustServerCertificate=True";
        }
        //SQL authentication
        else
        {
            MyCon = "Data Source=" + server_name_textBox1.Text +
               ";Initial Catalog=" + database_textBox1.Text +
               ";Persist Security Info=True;User ID=" +
               username_textBox1.Text +
               ";Password="+password_textBox1.Text +
               ";TrustServerCertificate=True";
        }
        //-----------save in app settings--------
        Secretariat_Soft.Properties.Settings.Default.main_con_text =MyCon;
        Secretariat_Soft.Properties.Settings.Default.Save();
        //---------------------------------------
    }

    private void SQL_Settings_Load(object sender, EventArgs e)
    {
        authentication_panel1.Visible = false;
    }

    private void sql_server_auth_radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        authentication_panel1.Visible = sql_server_auth_radioButton1.Checked;
    }
}
