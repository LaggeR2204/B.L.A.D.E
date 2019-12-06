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
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
            btnNowPlaying.PerformClick();
        }

        private void btnNowPlaying_Click(object sender, EventArgs e)
        {
            pnlSelectedTab.Left = btnNowPlaying.Left;
            btnNowPlaying.Font = new Font(btnNowPlaying.Font.Name, btnNowPlaying.Font.Size, FontStyle.Bold);
            btnNowPlaying.ForeColor = Color.White;
            btnChart.Font = new Font(btnChart.Font.Name, btnChart.Font.Size, FontStyle.Regular);
            btnChart.ForeColor = Color.Gainsboro;

            uc_Chart.Hide();
            uc_NowPlaying.Show();
            uc_NowPlaying.BringToFront();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            if (uc_Chart.isCompletedChart)
            {
                pnlSelectedTab.Left = btnChart.Left;
                btnChart.Font = new Font(btnChart.Font.Name, btnChart.Font.Size, FontStyle.Bold);
                btnChart.ForeColor = Color.White;
                btnNowPlaying.Font = new Font(btnNowPlaying.Font.Name, btnNowPlaying.Font.Size, FontStyle.Regular);
                btnNowPlaying.ForeColor = Color.Gainsboro;

                uc_NowPlaying.Hide();
                uc_Chart.Show();
                uc_Chart.BringToFront();
            }
            else
            {
                MessageBox.Show("Vui lòng chờ đợi crawl bxh cái disme");
            }
        }
    }
}
