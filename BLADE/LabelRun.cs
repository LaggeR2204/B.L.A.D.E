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
    public partial class LabelRun : UserControl
    {
        public LabelRun()
        {
            InitializeComponent();
            time = new Timer();
            time.Interval = 100;
            time.Tick += Time_Tick;
            time.Start();
            this.SizeChanged += UserControl1_SizeChanged;
            lbText.Location = new Point(lbText.Location.X, this.Height / 2 - lbText.Height / 2);
        }
        private void UserControl1_SizeChanged(object sender, EventArgs e)
        {
            lbText.Location = new Point(lbText.Location.X, this.Height / 2 - lbText.Height / 2);
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            if (lbText.Location.X >= -lbText.Width)
                lbText.Location = new Point(lbText.Location.X - 5, lbText.Location.Y);
            else
                lbText.Location = new Point(this.Width, lbText.Location.Y);
        }
        private Timer time;
        public void ResetLabelLocation()
        {
            lbText.Location = new Point(50, lbText.Location.Y);
        }
    }
}
