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

namespace Secretariat_Soft.S_Forms;
public partial class Out_Letters_De : Form
{
    public Out_Letters_De()
    {
        InitializeComponent();
    }
    bool is_del_clicked = false;
    private void Out_Letters_De_Load(object sender, EventArgs e)
    {
        is_del_clicked = false;
        //-------------------------
        enable_add_edit_del_butt();
        //-------------------------
        //sa_In_LettersTableAdapter1.FillBy_id_desc(letters1.Sa_In_Letters);
        //-------------------------
        //TO DO: Uncomment before publish
        object_perm_loader();
        //-------------------------
        try
        {
            long id;
            long.TryParse(id_label7.Text, out id);
            //------------------------
            sa_Out_LettersTableAdapter1.Connection.ConnectionString = MyClasses.ComClass.MyConn_String;
            //------------------------
            sa_Out_LettersTableAdapter1.FillBy_ID(letters1.Sa_Out_Letters, id);

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
        de_add_butt.Enabled = MyClass.get_permission_by_col_name("Out_De_b1"); //add
        de_edit_butt.Enabled = MyClass.get_permission_by_col_name("Out_De_b2"); // edit
        de_delete_butt.Enabled = MyClass.get_permission_by_col_name("Out_De_b3"); // delete
        de_print_butt.Enabled = MyClass.get_permission_by_col_name("Out_De_b4"); // print
        //--------------------------------------------------------
        if (Properties.Settings.Default.User_Id == Properties.Settings.Default.admin_user_id)
        {
            //usersToolStripMenuItem.Enabled = true;
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
        //----------------------------
        //TO DO: Uncomment before publish
        object_perm_loader();
        //----------------------------
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
        out_letters_bindingSource1.AddNew();
        sysDateTime();
        //-------------------------
        sent_time_masked_TB.Text = System.DateTime.Now.ToLongTimeString();
        priority_CB.SelectedIndex = 1;
        page_count_NC.Value = 2;
        //-------------------------
        //reg_date_masked_TB.Text = System.DateTime.Now.ToShortDateString();
        //reg_date_masked_TB.Text = new System.DateTime(2023, 12, 24, 12, 23, 12).ToShortTimeString();
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
        out_letters_bindingSource1.RemoveCurrent();
        //--------------------------
        is_del_clicked = true;
    }

    private void de_cancel_butt_Click(object sender, EventArgs e)
    {
        enable_add_edit_del_butt();
        //--------------------------
        out_letters_bindingSource1.CancelEdit();
        letters1.Sa_Out_Letters.RejectChanges();
        //--------------------------
    }

    private void de_save_butt_Click(object sender, EventArgs e)
    {
        try
        {
            if (is_del_clicked == false)
            {
                //==================================================
                //-------Validator---------
                DateTime rr;
                bool b;
                b = DateTime.TryParse(reg_date_masked_TB.Text, out rr);
                if (b == false)
                {
                    MessageBox.Show("Reg date is not valid!");
                    return;
                }
                //==========================
                if (sent_date_masked_TB.Text != "__-__-____")
                {
                    b = DateTime.TryParse(sent_date_masked_TB.Text, out rr);
                    if (b == false)
                    {
                        MessageBox.Show("Res date is not valid!");
                        return;
                    }
                }

                //==========================

                //==================================================
            }

            //-------------------
            //-------------------
            out_letters_bindingSource1.EndEdit();
            //-------------------
            int r; //Update je int
            //------------------------
            sa_Out_LettersTableAdapter1.Connection.ConnectionString = MyClasses.ComClass.MyConn_String;
            //------------------------
            r = sa_Out_LettersTableAdapter1.Update(letters1.Sa_Out_Letters);
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

    private void today_regDate_Btn_Click(object sender, EventArgs e)
    {
        reg_date_masked_TB.Text = DateTime.Now.ToShortDateString();
    }

    private void today_resDate_btn_Click(object sender, EventArgs e)
    {
        sent_date_masked_TB.Text = DateTime.Now.ToShortDateString();
    }

    private void de_print_butt_Click(object sender, EventArgs e)
    {
        string fn, xml_fn;
        //--------------------
        xml_fn = Application.StartupPath + "Data\\Reps\\help.mp3";
        letters1.WriteXml(xml_fn);
        //--------------------
        fn = Application.StartupPath + "MyRep.exe";
        System.Diagnostics.Process.Start(fn, "OutSingle.rpt");
    }

    private void Out_Letters_De_KeyDown(object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case Keys.F2:
                if (de_add_butt.Enabled == true)
                {
                    de_add_butt_Click(sender, e);
                }
                //---------------
                break;
            case Keys.F3:
                if (de_edit_butt.Enabled == true)
                {
                    de_edit_butt_Click(sender, e);
                }
                break;
            case Keys.F4:
                if (de_delete_butt.Enabled == true)
                {
                    de_delete_butt_Click(sender, e);
                }
                break;
            case Keys.F5:
                if (de_save_butt.Enabled == true)
                {
                    de_save_butt_Click(sender, e);
                }
                break;
            case Keys.F6:
                if (de_cancel_butt.Enabled == true)
                {
                    de_cancel_butt_Click(sender, e);
                }
                break;
            case Keys.F9:
                if (de_print_butt.Enabled == true)
                {
                    de_print_butt_Click(sender, e);
                }
                break;
            default:
                break;


        }
    }
}
