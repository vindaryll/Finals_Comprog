using System.Drawing.Text;
using pv = backbone.PublicVariables;

namespace backbone.AdminForms
{
    public partial class eUpdatePrice : Form
    {
        Functions func = new();
        public eUpdatePrice()
        {
            InitializeComponent();
            showdata();
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
        private void showdata()
        {
            func.getCurrentPrice(pv.adminItemIndex);
            lblPrice.Text = "PHP " + pv.currentPrice.ToString("N2");
            lblItemName.Text = pv.itemName[pv.adminItemIndex].ToString();
            lblItemId.Text = "ITEM ID: " + pv.itemID[pv.adminItemIndex].ToString();
            func.picture(pv.adminItemIndex, pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price;

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Enter a Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (double.TryParse(textBox1.Text, out price) && price >= 0)
            {
                func.updatePrice(price, pv.adminItemIndex);
                MessageBox.Show("Price Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                func.getItemInfo();
                showdata();
                textBox1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please Enter a valid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dItemForm form = new();
            form.Show();
            this.Close();
        }
    }
}
