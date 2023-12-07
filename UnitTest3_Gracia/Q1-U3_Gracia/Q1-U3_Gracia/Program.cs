using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1_U3_Gracia
{
    internal static class Program
    {
        /// Author: Geoff Gracia
        /// Purpose: The purpose of this area of the program is to run the code for the form 
        /// Restrictions: Trying to replicate the Presidents App
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run((Form)new Form1());
        }
    }
}
