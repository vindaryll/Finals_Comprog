using System.Drawing.Text;
using pv = backbone.PublicVariables;

namespace backbone.CustomerForms
{
    public partial class hPaymentEPayment : Form
    {
        public hPaymentEPayment()
        {
            InitializeComponent();
            lblPayment.Text = "PHP " + pv.totalBill.ToString("N2");
            useCustomFont();
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
                lblPayment.Font = new Font(pfc.Families[0], 14, FontStyle.Regular);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fPayment form = new();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pv.paymentAmount = pv.totalBill;
            pv.changeAmount = 0;
            pv.paymentMethod = "E-PAYMENT";

            MiscForms.ReceiptLoading form = new();
            form.Show();
            this.Close();
        }
    }
}
