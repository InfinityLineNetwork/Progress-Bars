using System;
using System.Windows.Forms;

namespace ProgressBarQuicky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            progressBar2.Increment(1);
            progressBar3.Increment(1);
            progressBar4.Increment(1);
            progressBar5.Increment(1);
        }
    }
}
