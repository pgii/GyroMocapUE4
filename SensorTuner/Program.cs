using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.ThreadException += HandleError;
        AppDomain.CurrentDomain.UnhandledException += UnhandledException;

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
    }

    static void HandleError(object sender, ThreadExceptionEventArgs e)
    {
        StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Error.log", true);
        sw.WriteLine(DateTime.Now + " | " + e.Exception.StackTrace + " | " + e.Exception);
        sw.Close();
    }

    static void UnhandledException(object sender, UnhandledExceptionEventArgs args)
    {
        StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Error.log", true);
        sw.WriteLine(DateTime.Now + " | " + args.ExceptionObject + " | " + args.IsTerminating);
        sw.Close();
    }

    public static void ExceptionLog(Exception ex)
    {
        StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Error.log", true);
        sw.WriteLine(DateTime.Now + " | " + ex.Message + " | " + ex.StackTrace);
        sw.Close();
    }
}

