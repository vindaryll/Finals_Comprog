using System.Drawing.Text;
using pv = backbone.PublicVariables;

namespace backbone.CustomerForms
{
    public partial class aCustomerInformation : Form
    {
        Functions func = new();
        public aCustomerInformation()
        {
            InitializeComponent();
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
                    c.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox3.Text.Length == 11)
                {
                    pv.customerName = textBox1.Text.ToUpper();
                    pv.customerAddress = textBox2.Text.ToUpper();
                    pv.customerContact = textBox3.Text.ToUpper();

                    bCustomerOrderInterface form = new();
                    this.Close();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Please enter a valid phone number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox3.Text = string.Empty;
                }

            }
            else
            {
                MessageBox.Show("Please fill out everything", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WelcomeInterface2 form = new WelcomeInterface2();
            this.Close();
            form.Show();
        }
    }
}
