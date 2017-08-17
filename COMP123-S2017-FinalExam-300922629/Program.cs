using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Shakil Hosin
 * Date: August 17th, 2017
 * StudentID: 300922629
 * Description:
 * Version: 0.1
 */

namespace COMP123_S2017_FinalExam_300922629
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static PickHighestCardForm highestcardform;
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            highestcardform = new PickHighestCardForm();
            Application.Run(new SplashForm());
            Application.Run(new PickHighestCardForm());
        }
    }
}
