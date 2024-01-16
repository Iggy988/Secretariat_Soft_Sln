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

namespace Secretariat_Soft.S_Forms;
public partial class In_Letters_List : Form
{
    public In_Letters_List()
    {

        InitializeComponent();
    }

    void recordPosition()
    {
        int currentPostion;
        currentPostion = in_letters_bindingSource1.Position;
        currentPostion += 1;
        position_tbox.Text = currentPostion.ToString();

        total_records_lbl.Text = " of " + in_letters_bindingSource1.Count.ToString();
    }

    private void In_Letters_Form_Load(object sender, EventArgs e)
    {
        //---------------------------
        //object_perm_loader();
        //---------------------------
        try
        {
            sa_In_LettersTableAdapter1.Fill(letters1.Sa_In_Letters);
            recordPosition();
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
        add_butt.Enabled = MyClass.get_permission_by_col_name("In_List_b1"); //add
        search_butt.Enabled = MyClass.get_permission_by_col_name("In_List_b2"); // search
        print_butt.Enabled = MyClass.get_permission_by_col_name("In_List_b3"); // print
        //--------------------------------------------------------
        if (Properties.Settings.Default.User_Id == Properties.Settings.Default.admin_user_id)
        {
            //usersToolStripMenuItem.Enabled = true;
        }
    }

    private void FirstButt_Click(object sender, EventArgs e)
    {
        in_letters_bindingSource1.MoveFirst();
        recordPosition();
    }

    private void SecondButt_Click(object sender, EventArgs e)
    {
        in_letters_bindingSource1.MovePrevious();
        recordPosition();
    }

    private void ThirdButt_Click(object sender, EventArgs e)
    {
        in_letters_bindingSource1.MoveNext();
        recordPosition();

    }

    private void FourthButt_Click(object sender, EventArgs e)
    {
        in_letters_bindingSource1.MoveLast();
        recordPosition();
    }


    private void search_butt_Click(object sender, EventArgs e)
    {
        search_pannel1.Visible = !search_pannel1.Visible;
        search_pannel2.Visible = !search_pannel2.Visible;
    }

    private void search_panel_butt_Click(object sender, EventArgs e)
    {
        try
        {
            long id;
            long.TryParse(search_textbox.Text, out id);

            sa_In_LettersTableAdapter1.FillBy_ID(letters1.Sa_In_Letters, id);
            recordPosition();
        }
        catch (Exception ex)
        {

            MessageBox.Show("Error! " + ex.Message);
        }
    }


    private void searc_subject_like_butt_Click(object sender, EventArgs e)
    {
        try
        {
            var searchString = "%" + search_subject_textbox.Text + "%";
            sa_In_LettersTableAdapter1.FillBy_subject_like(letters1.Sa_In_Letters, searchString);
            recordPosition();
        }
        catch (Exception ex)
        {

            MessageBox.Show("Error! " + ex.Message);
        }
    }



    private void search_date_butt_Click(object sender, EventArgs e)
    {
        try
        {
            string d1, d2;
            d1 = dateTimePicker1.Value.ToString();
            d2 = dateTimePicker2.Value.ToString();
            sa_In_LettersTableAdapter1.FillBy_regdate(letters1.Sa_In_Letters, d1, d2);
            recordPosition();
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
            Secretariat_Soft.S_Forms.In_Letters_De frm = new In_Letters_De();
            frm.id_label2.Text = id_label.Text;
            frm.ShowDialog();
            //---------------------------------
            sa_In_LettersTableAdapter1.Fill(letters1.Sa_In_Letters);
            //recordPosition();
        }
        catch (Exception ex)
        {

            MessageBox.Show("Error! " + ex.Message);
        }
    }

    private void print_butt_Click(object sender, EventArgs e)
    {
        string fn, xml_fn;
        //--------------------
        xml_fn = Application.StartupPath + "Data\\Reps\\help.mp3";
        letters1.WriteXml(xml_fn);
        //--------------------
        fn = Application.StartupPath + "MyRep.exe";
        System.Diagnostics.Process.Start(fn, "InputList.rpt");
    }
}
