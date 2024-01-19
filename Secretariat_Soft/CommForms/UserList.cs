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
        //---------------------------------
        object_perm_loader();
        //---------------------------------
        try
        {
            appUsersTableAdapter1.Fill(letters1.AppUsers);
        }
        catch (Exception ex)
        {

            MessageBox.Show("Error! " + ex.Message);
        }
    }

    void object_perm_loader()
    {
        Secretariat_Soft.MyClasses.ComClass MyClass = new();
        //--------load permissions by col name -------------------
        add_butt.Enabled = MyClass.get_permission_by_col_name("User_List_b1"); //add

        //--------------------------------------------------------
        if (Properties.Settings.Default.User_Id == Properties.Settings.Default.admin_user_id)
        {
            add_butt.Enabled = true;
        }
    }

    private void add_butt_Click(object sender, EventArgs e)
    {

        try
        {
            Secretariat_Soft.CommForms.Users_De frm = new();
            frm.id_label2.Text = id_label.Text;
            frm.ShowDialog();
            //---------------------------------
            appUsersTableAdapter1.Fill(letters1.AppUsers);

            //======Reload permission data======
            Secretariat_Soft.MyClasses.ComClass MyClass = new();
            MyClass.user_perm_loader_from_db();
            //==================================

        }
        catch (Exception ex)
        {

            MessageBox.Show("Error! " + ex.Message);
        }
    }

    private void UserList_KeyDown(object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.F2:
                if (add_butt.Enabled == true)
                {
                    add_butt_Click(sender, e);
                }
                //---------------
                break;
           

            default:
                break;
        }
    }
}
