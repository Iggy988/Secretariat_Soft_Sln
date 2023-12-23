using Secretariat_Soft.DataSet;
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
public partial class In_Letters_De : Form
{
    public In_Letters_De()
    {
        InitializeComponent();
    }

    private void In_Letters_De_Load(object sender, EventArgs e)
    {
        enable_add_edit_del_butt();
        //-------------------------
        sa_In_LettersTableAdapter1.FillBy_id_desc(letters1.Sa_In_Letters);

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
        sysDateTime();
    }

    private void de_edit_butt_Click(object sender, EventArgs e)
    {
        disable_add_edit_del_butt();
        //-------------------------
        sysDateTime();
    }

    private void de_delete_butt_Click(object sender, EventArgs e)
    {
        disable_add_edit_del_butt();
    }

    private void de_cancel_butt_Click(object sender, EventArgs e)
    {
        enable_add_edit_del_butt();
    }

    void sysDateTime()
    {
        system_time_lbl.Text = DateTime.Now.ToString("HH:mm:ss");
        system_date_lbl.Text = DateTime.Now.ToString("dd/MM/yyyy");
        //-------------------------------
        user_name_lbl.Text = Secretariat_Soft.Properties.Settings.Default.User_name;
        user_id_lbl.Text = Secretariat_Soft.Properties.Settings.Default.User_Id.ToString();
    }

}
