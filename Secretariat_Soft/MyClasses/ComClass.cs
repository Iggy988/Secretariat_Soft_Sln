using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretariat_Soft.MyClasses;
public class ComClass
{
    static Secretariat_Soft.DataSet.Letters.AppUsersDataTable user_perm_dt = new();

    public void user_perm_loader_from_db()
    {
        try
        {
            //---------------------------------------
            Secretariat_Soft.DataSet.LettersTableAdapters.AppUsersTableAdapter ta = new();
            //---------------------------------------
            long uid = Secretariat_Soft.Properties.Settings.Default.User_Id;
            ta.FillBy_login_user_id(user_perm_dt, uid);
            //---------------------------------------
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error! " + ex.Message);
        }
        
    }
}
