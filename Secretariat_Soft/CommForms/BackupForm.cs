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
public partial class BackupForm : Form
{
    public BackupForm()
    {
        InitializeComponent();
    }

    private void browse_button1_Click(object sender, EventArgs e)
    {
        DialogResult dr = folderBrowserDialog1.ShowDialog();
        if (dr == DialogResult.OK)
        {
            string d = DateTime.Now.ToString("dd-MM-yyyy-HH-mm");
            string fn = folderBrowserDialog1.SelectedPath + "\\" + d + ".s24";
            //-----------------------
            filename_textBox1.Text = fn;
        }
    }

    private void exit_button2_Click(object sender, EventArgs e)
    {
        Close();
    }
}
