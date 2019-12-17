using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLADE.xDialog;

namespace BLADE
{
    public partial class ucNewHome : UserControl
    {
        public ucNewHome()
        {
            InitializeComponent();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            if (uc_Chart.isInternet)
            {
                if (uc_Chart.isCompletedChart)
                {
                    this.Controls.Add(uc_Chart);
                    uc_Chart.Show();
                    uc_Chart.BringToFront();
                }
                else
                {
                    MsgBox.Show("Please wait while the application is updating the data", "SORRY", MsgBox.Buttons.OK, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);
                }
            }
            else
            {
                MsgBox.Show("Check your Internet connection and try again", "ERROR", MsgBox.Buttons.OK, MsgBox.Icon.Error, MsgBox.AnimateStyle.FadeIn);
            }
        }
    }
}
