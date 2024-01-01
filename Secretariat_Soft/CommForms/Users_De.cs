using Secretariat_Soft.DataSet.LettersTableAdapters;
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
public partial class Users_De : Form
{
    public Users_De()
    {
        InitializeComponent();
    }
    bool is_del_clicked = false;
    private void Users_De_Load(object sender, EventArgs e)
    {
        is_del_clicked = false;
        //-------------------------
        enable_add_edit_del_butt();

        //-------------------------
        try
        {
            long id;
            long.TryParse(id_label2.Text, out id);

            appUsersTableAdapter1.FillBy_id(letters1.AppUsers, id);

        }
        catch (Exception ex)
        {

            MessageBox.Show("Error! " + ex.Message);
        }
    }

    void sysDateTime()
    {
        system_time_lbl.Text = DateTime.Now.ToString("HH:mm:ss");
        system_date_lbl.Text = DateTime.Now.ToString("dd/MM/yyyy");
        //-------------------------------
        user_name_lbl.Text = Secretariat_Soft.Properties.Settings.Default.User_name;
        user_id_lbl.Text = Secretariat_Soft.Properties.Settings.Default.User_Id.ToString();
    }
    void enable_add_edit_del_butt()
    {
        // disabling groupbox from editing data
        main_gbox.Enabled = false;
        //----------------------------
        de_cancel_butt.Enabled = false;
        de_save_butt.Enabled = false;
        //----------------------------
        de_add_butt.Enabled = true;
        de_edit_butt.Enabled = true;
        de_delete_butt.Enabled = true;
    }
    void disable_add_edit_del_butt()
    {
        // disabling groupbox from editing data
        main_gbox.Enabled = true;
        //----------------------------
        de_cancel_butt.Enabled = true;
        de_save_butt.Enabled = true;
        //----------------------------
        de_add_butt.Enabled = false;
        de_edit_butt.Enabled = false;
        de_delete_butt.Enabled = false;
    }
    void disable_del_butt()
    {
        // disabling groupbox from editing data
        main_gbox.Enabled = false;
        //----------------------------
        de_cancel_butt.Enabled = true;
        de_save_butt.Enabled = true;
        //----------------------------
        de_add_butt.Enabled = false;
        de_edit_butt.Enabled = false;
        de_delete_butt.Enabled = false;
    }

    private void de_add_butt_Click(object sender, EventArgs e)
    {
        disable_add_edit_del_butt();
        //-------------------------
        appusers_bindingSource1.AddNew();
        sysDateTime();
        //-------------------------
        is_del_clicked = false;
    }

    private void de_edit_butt_Click(object sender, EventArgs e)
    {
        disable_add_edit_del_butt();
        //-------------------------
        sysDateTime();
        //-------------------------
        is_del_clicked = false;
    }

    private void de_delete_butt_Click(object sender, EventArgs e)
    {
        disable_del_butt();
        //--------------------------
        appusers_bindingSource1.RemoveCurrent();
        //--------------------------
        is_del_clicked = true;
    }

    private void de_save_butt_Click(object sender, EventArgs e)
    {
        try
        {
            if (is_del_clicked == false)
            {
                //==================================================
                //-------Validator---------




                //==================================================
            }

            //-------------------
            //-------------------
            appusers_bindingSource1.EndEdit();
            //-------------------
            int r; //Update je int
            r = appUsersTableAdapter1.Update(letters1.AppUsers);
            //-------------------
            if (r > 0)
            {
                MessageBox.Show("Saved! Count: " + r.ToString());
                if (is_del_clicked == true)
                {
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Not Saved! ");
            }
            //-------------------
        }
        catch (Exception ex)
        {

            MessageBox.Show("Error! " + ex.Message);
        }

        enable_add_edit_del_butt();
    }

    private void de_cancel_butt_Click(object sender, EventArgs e)
    {
        enable_add_edit_del_butt();
        //--------------------------
        appusers_bindingSource1.CancelEdit();
        letters1.AppUsers.RejectChanges();
        //--------------------------
    }

    private void browse_button1_Click(object sender, EventArgs e)
    {
        OpenFileDialog dlg = new OpenFileDialog();
        //-----------------------
        DialogResult dr;
        //---filter--------------
        dlg.Filter = "Jpg Files|*.jpg|Png Files|*.png";
        //-----------------------
        dr = dlg.ShowDialog();
        //-----------------------
        if (dr == DialogResult.OK)
        {
            string fn = dlg.FileName;
            //-----------------
            user_pictureBox1.LoadAsync(fn);
            
        }
    }
}
