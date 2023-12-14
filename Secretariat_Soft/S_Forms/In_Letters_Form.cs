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
        }
        catch (Exception ex)
        {

            MessageBox.Show("Error! " + ex.Message);
        }
    }
}
