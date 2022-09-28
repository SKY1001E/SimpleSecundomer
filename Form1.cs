using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        DateTime date;
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                date = DateTime.Now;
                
                timer.Interval = 10;
                timer.Tick += new EventHandler(TickTimer);
                timer.Start();
        }
        private void TickTimer(object sender, EventArgs e)
        {
            long tick = DateTime.Now.Ticks - date.Ticks;
            DateTime stopWatch = new DateTime();

            stopWatch = stopWatch.AddTicks(tick);
            label1.Text = String.Format("{00:HH:mm:ss:ff}", stopWatch);
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            timer.Stop();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = String.Format("00:00:00:00");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
