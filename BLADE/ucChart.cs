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
    public partial class ucChart : UserControl
    {
        public ucChart()
        {
            InitializeComponent();
        }

        private void btnVN_Click(object sender, EventArgs e)
        {
            btnVN.BackColor = Color.FromArgb(0, 192, 192);
            btnUSUK.BackColor = Color.FromArgb(40, 40, 40);
            btnKorea.BackColor = Color.FromArgb(40, 40, 40);

            fpnlUSUK.Hide();
            fpnlKorea.Hide();
            fpnlVN.Show();
            fpnlVN.BringToFront();
        }

        private void btnUSUK_Click(object sender, EventArgs e)
        {
            btnUSUK.BackColor = Color.FromArgb(0, 192, 192);
            btnVN.BackColor = Color.FromArgb(40, 40, 40);
            btnKorea.BackColor = Color.FromArgb(40, 40, 40);

            fpnlVN.Hide();
            fpnlKorea.Hide();
            fpnlUSUK.Show();
            fpnlUSUK.BringToFront();
        }

        private void btnKorea_Click(object sender, EventArgs e)
        {
            btnKorea.BackColor = Color.FromArgb(0, 192, 192);
            btnUSUK.BackColor = Color.FromArgb(40, 40, 40);
            btnVN.BackColor = Color.FromArgb(40, 40, 40);

            fpnlUSUK.Hide();
            fpnlVN.Hide();
            fpnlKorea.Show();
            fpnlKorea.BringToFront();
        }
    }
}
