using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using pv = backbone.PublicVariables;
namespace backbone.MiscForms
{
    public partial class LoggingOut : Form
    {
        private int dotsCount = 1;
        public LoggingOut()
        {
            InitializeComponent();
            useCustomFont();
            timer1.Start();  
        }

        private void useCustomFont()
        {
            try
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                pfc.AddFontFile(pv.font);
                foreach (Control c in this.Controls)
                {
                    c.Font = new Font(pfc.Families[0], 14, FontStyle.Regular);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string dots = new string('.', dotsCount);

            if (LogoutComplete())
            {
                label1.Text = "LOGGED OUT!";
                timer1.Stop();
                this.Close();
                WelcomeInterface1 form = new();
                form.Show();
            }
            else
            {
                label1.Text = $"LOGGING OUT{dots}";
            }

            dotsCount++;
        }

        private bool LogoutComplete()
        {
            return dotsCount == 4; // out of range
        }
    }
}
