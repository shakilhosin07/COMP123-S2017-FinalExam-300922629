using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Shakil Hosin
 * Date: August 17th, 2017
 * Description: This is SplashForm.cs
 * Version: 0.1 - Created a public property 
 */
namespace COMP123_S2017_FinalExam_300922629
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        //
        public PickHighestCardForm PickHighestCardForm1
        {
            get
            {
                return Program.highestcardform;
            }
        }
        /// <summary>
        /// Showing the PickhighestCard Form then hiding the splash screen after 3 seconds.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.PickHighestCardForm1.Show();
            this.Hide();
            SplashTimer.Enabled = false;
        }
    }
}
