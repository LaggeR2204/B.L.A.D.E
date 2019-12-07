using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BLADE
{
    public partial class ucChart : UserControl
    {
        private CrawlChart chart = new CrawlChart();
        public bool isCompletedChart = false;
        public bool isInternet = true;

        public ucChart()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            InitChart();
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

        public void ShowChartVN(List<ucSongChartDetail> src)
        {
            foreach (var item in src)
            {
                fpnlVN.Controls.Add(item);
            }
        }

        public void ShowChartUSUK(List<ucSongChartDetail> src)
        {
            foreach (var item in src)
            {
                fpnlUSUK.Controls.Add(item);
            }
        }

        public void ShowChartKorea(List<ucSongChartDetail> src)
        {
            foreach (var item in src)
            {
                fpnlKorea.Controls.Add(item);
            }
        }

        private void InitChart()
        {
            if (IsConnectedToInternet())
            {
                Thread thrd = new Thread(RefreshChart);
                thrd.IsBackground = true;
                thrd.Start();
            }
            else
            {
                isInternet = false;
            }
        }

        private void RefreshChart()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    ShowChartVN(chart.CrawlChartFromCSN("vietnam"));
                    ShowChartUSUK(chart.CrawlChartFromCSN("us-uk"));
                    ShowChartKorea(chart.CrawlChartFromCSN("korea"));
                    isCompletedChart = true;
                });
            }
            else
            {
                ShowChartVN(chart.CrawlChartFromCSN("vietnam"));
                ShowChartUSUK(chart.CrawlChartFromCSN("us-uk"));
                ShowChartKorea(chart.CrawlChartFromCSN("korea"));
                isCompletedChart = true;
            }
            
        }

        public bool IsConnectedToInternet()
        {
            try
            {
                System.Net.IPHostEntry i = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
