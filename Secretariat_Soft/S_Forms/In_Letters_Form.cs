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

    

    void recordPosition()
    {
        int currentPostion;
        currentPostion = in_letters_bindingSource1.Position;
        currentPostion += 1;
        position_tbox.Text = currentPostion.ToString();

        total_records_lbl.Text = " of " + in_letters_bindingSource1.Count.ToString();
    }
}
