using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLADE
{
    class stopTimer : Timer
    {
        int sec;
        public stopTimer(int sec)
        {
            this.sec = sec;
            this.Interval = 1000;
            this.Tick += new EventHandler(TimerOnTick);
            this.Start();
        }
        private void TimerOnTick(object sender, EventArgs e)
        {
            sec--;
        }
        public int Second
        {
            get { return sec; }
            set { sec = value; }
        }
    }
}
