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
public partial class In_Letters_Form : Form
{
    public In_Letters_Form()
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
}
