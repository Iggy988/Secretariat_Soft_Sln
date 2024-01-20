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
public partial class About_Us : Form
{
    public About_Us()
    {
        InitializeComponent();
    }

    private void About_Us_Load(object sender, EventArgs e)
    {
        company_name_label1.Text = Application.CompanyName;
        product_name_label.Text = Application.ProductName;
        version_label1.Text = Application.ProductVersion;
        copy_right_version.Text = copyRightReader();
    }

    private string? copyRightReader()
    {
        string? fn = "";
        try
        {

            //get starting assembly
          System.Reflection.Assembly? asm =  System.Reflection.Assembly.GetEntryAssembly();
            //--------------
            if (asm != null)
            {
                fn = asm.Location;
            }
            //--------------
            var verInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(fn);    
            //--------------
            return verInfo.LegalCopyright;
        }
        catch (Exception)
        {
            return "Unknown";
        }
    }
}
