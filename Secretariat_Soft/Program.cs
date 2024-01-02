namespace Secretariat_Soft;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-US");
        ci.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";
        //ci.DateTimeFormat.ShortDatePattern = "HH:mm:ss";
        //ci.NumberFormat.CurrencySymbol = "€";
        //----------------------------------------------
        System.Threading.Thread.CurrentThread.CurrentCulture = ci;
        System.Threading.Thread.CurrentThread.CurrentUICulture = ci;

        ApplicationConfiguration.Initialize();
        //Application.Run(new Secretariat_Soft.S_Forms.Out_Letters_List());
        Application.Run(new Secretariat_Soft.CommForms.UserList());
        //Application.Run(new MainForm());
    }
}