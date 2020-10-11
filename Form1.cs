using System;
using System.Windows.Forms;

namespace DClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Status.Text = DateTime.Now.ToString("T");
        }
        private void Form1_Load(object sender, EventArgs e)
        {           
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {

                Status.Text = DateTime.Now.ToString("T");
            }));
        }
    }
}
