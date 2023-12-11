using System.Drawing.Text;
using pv = backbone.PublicVariables;
namespace backbone.MiscForms
{
    public partial class ReceiptLoading : Form
    {
        private int dotsCount = 1;
        public ReceiptLoading()
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

            if (printed())
            {
                timer1.Stop();
                CustomerForms.iReceipt form = new();
                form.Show();
                this.Close();
            }
            else
            {
                label1.Text = $"PRINTING RECEIPT{dots}";
            }

            dotsCount++;
        }
        private bool printed()
        {
            return dotsCount == 4; // out of range
        }
    }
}
