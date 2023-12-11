using System.Drawing.Text;
using pv = backbone.PublicVariables;

namespace backbone.CustomerForms
{
    public partial class gPaymentCash : Form
    {
        public gPaymentCash()
        {
            InitializeComponent();
            lblTotal.Text = "PHP " + pv.totalBill.ToString("N2");
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
                lblTotal.Font = new Font(pfc.Families[0], 14, FontStyle.Regular);
                textBox1.Font = new Font(pfc.Families[0], 14, FontStyle.Regular);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = false;

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (double.TryParse(textBox1.Text, out pv.paymentAmount))
                {

                    if (pv.paymentAmount >= pv.totalBill)
                    {
                        pv.changeAmount = pv.paymentAmount - pv.totalBill;
                        pv.paymentMethod = "CASH";
                        valid = true;
                    }
                    else
                    {
                        MessageBox.Show("PLEASE ENTER SUFFICIENT AMOUNT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("INVALID AMOUNT. PLEASE ENTER A NUMERIC VALUE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("PLEASE ENTER AN AMOUNT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (valid)
            {
                MiscForms.ReceiptLoading form = new();
                form.Show();
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fPayment form = new();
            form.Show();
            this.Close();
        }
    }
}
