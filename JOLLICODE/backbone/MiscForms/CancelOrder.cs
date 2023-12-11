using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backbone.MiscForms
{
    public partial class CancelOrder : Form
    {
        private int seconds = 0;
        public CancelOrder()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (done())
            {
                timer1.Stop();
                WelcomeInterface1 form = new();
                form.Show();
                this.Close();
            }
            seconds++;
        }
        private bool done()
        {
            return seconds == 3;
        }
    }
}
