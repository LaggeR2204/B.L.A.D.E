using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLADE
{
    public partial class ucInfo : UserControl
    {
        public ucInfo()
        {
            InitializeComponent();
        }

        private void btnVTB_MouseHover(object sender, EventArgs e)
        {
            btnVTB.Font = new Font(btnVTB.Font.Name, btnVTB.Font.SizeInPoints, FontStyle.Underline);
        }

        private void btnTHMD_MouseHover(object sender, EventArgs e)
        {
            btnTHMD.Font = new Font(btnVTB.Font.Name, btnVTB.Font.SizeInPoints, FontStyle.Underline);
        }

        private void btnPQA_MouseHover(object sender, EventArgs e)
        {
            btnPQA.Font = new Font(btnVTB.Font.Name, btnVTB.Font.SizeInPoints, FontStyle.Underline);
        }

        private void btnBHL_MouseHover(object sender, EventArgs e)
        {
            btnBHL.Font = new Font(btnVTB.Font.Name, btnVTB.Font.SizeInPoints, FontStyle.Underline);
        }

        private void btnVTB_MouseLeave(object sender, EventArgs e)
        {
            btnVTB.Font = new Font(btnVTB.Font.Name, btnVTB.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btnTHMD_MouseLeave(object sender, EventArgs e)
        {
            btnTHMD.Font = new Font(btnVTB.Font.Name, btnVTB.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btnPQA_MouseLeave(object sender, EventArgs e)
        {
            btnPQA.Font = new Font(btnVTB.Font.Name, btnVTB.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btnBHL_MouseLeave(object sender, EventArgs e)
        {
            btnBHL.Font = new Font(btnVTB.Font.Name, btnVTB.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btnVTB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/22lagger");
        }

        private void btnTHMD_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100004523919872");
        }

        private void btnPQA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/anomg0210");
        }

        private void btnBHL_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/suou.ryuuji");
        }
    }
}
