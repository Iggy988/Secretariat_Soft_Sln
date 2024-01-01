using Secretariat_Soft.DataSet.LettersTableAdapters;
using Secretariat_Soft.S_Forms;
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
public partial class UserList : Form
{
    public UserList()
    {
        InitializeComponent();
    }

    private void UserList_Load(object sender, EventArgs e)
    {
        try
        {
            appUsersTableAdapter1.Fill(letters1.AppUsers);
        }
        catch (Exception ex)
        {

            MessageBox.Show("Error! " + ex.Message);
        }
    }

    private void add_butt_Click(object sender, EventArgs e)
    {

        try
        {
            Secretariat_Soft.CommForms.Users_De frm = new ();
            frm.id_label2.Text = id_label.Text;
            frm.ShowDialog();
            //---------------------------------
            appUsersTableAdapter1.Fill(letters1.AppUsers);
        }
        catch (Exception ex)
        {

            MessageBox.Show("Error! " + ex.Message);
        }
    }
}
