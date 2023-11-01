using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 f = new Form1(args);
            // Application.Run(f);
            
            //f.Visible = true;

            Process proc = new Process();
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = false;

            if (System.IO.File.Exists("extract.bat"))
            {
                
                proc.StartInfo.FileName = "extract.bat";
                proc.Start();

                int id = proc.Id;
                Process tempProc = Process.GetProcessById(id);
                tempProc.WaitForExit();
            } 
            else
            {
                proc.StartInfo.FileName = "lcf2xml.exe";
                proc.StartInfo.Arguments = ".\\RPG_RT.ldb";
                proc.Start();

                int id = proc.Id;
                Process tempProc = Process.GetProcessById(id);
                tempProc.WaitForExit();

                proc.StartInfo.FileName = "Parser.exe";
                proc.StartInfo.Arguments = "-subfolder";
                proc.Start();

                id = proc.Id;
                tempProc = Process.GetProcessById(id);
                tempProc.WaitForExit();
            }
            //

            String s = "";
            for (int i = 0; i < args.Length; i++)
            {
                s += args[i] + " ";
            }

            if (System.IO.File.Exists("Game.exe")) {
                proc = Process.Start("Game.exe", s);
                f.Visible = false;

                proc.WaitForExit();
                f.Close();
                f.Visible = true;
            }
            
        }
    }
}
