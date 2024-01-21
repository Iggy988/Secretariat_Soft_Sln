using AnalogClock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Secretariat_Soft.CommForms;
public partial class LoginFrm : Form
{
    public LoginFrm()
    {
        InitializeComponent();
    }

    private void LoginFrm_Load(object sender, EventArgs e)
    {
        try
        {
            transparent_panel();
            //-------------------------
            appUsersTableAdapter1.Fill(letters1.AppUsers);
        }
        catch (Exception ex)
        {

            MessageBox.Show("Error! " + ex.Message);
        }
    }

    void transparent_panel()
    {
        panel2.BackColor = Color.FromArgb(70, Color.Black);

    }


    private void ok_button1_Click(object sender, EventArgs e)
    {
        //-----------------------------
        if (username_CB.SelectedIndex == -1)
        {
            MessageBox.Show("Please select the user first!");
            return;
        }
        //-----------------------------
        if (password_TB.Text != correct_pass_textBox1.Text)
        {
            MessageBox.Show("Please enter the correct password!");
            return;
        }
        //-----------------------------
        DialogResult = DialogResult.OK;
    }

    private void cancel_button2_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
    }

    private void settings_button1_Click(object sender, EventArgs e)
    {
        Secretariat_Soft.CommForms.SQL_Settings frm = new();
        frm.ShowDialog();
    }
}
