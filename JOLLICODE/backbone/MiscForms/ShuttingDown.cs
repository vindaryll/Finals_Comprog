using System.Drawing.Text;
using pv = backbone.PublicVariables;
namespace backbone.MiscForms
{
    public partial class ShuttingDown : Form
    {
        private int dotsCount = 1;

        public ShuttingDown()
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

            if (ShutdownComplete())
            {
                timer1.Stop();
                Application.Exit();
            }
            else
            {
                label1.Text = $"SHUTTING DOWN{dots}";
            }

            dotsCount++;
        }
        private bool ShutdownComplete()
        {
            return dotsCount == 4; // out of range
        }
    }
}
