using System.Drawing.Text;
using pv = backbone.PublicVariables;

namespace backbone.CustomerForms
{
    public partial class cOrderItem : Form
    {

        Functions func = new();
        public cOrderItem()
        {
            InitializeComponent();
            showData();
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
                    c.Font = new Font(pfc.Families[0], 9, FontStyle.Regular);
                }
                lbl1.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                lbl2.Font = new Font(pfc.Families[0], 14, FontStyle.Regular);
                lbl3.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
                lbl4.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                lbl5.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void showData()
        {
            func.picture(pv.indexItem, pictureBox1);
            lbl1.Text = pv.itemName[pv.indexItem].ToString();
            lbl2.Text = "PHP " + pv.itemPrice[pv.indexItem].ToString("N2");
            lbl3.Text = pv.itemDescription[pv.indexItem].ToString();
            lbl4.Text = pv.itemQuantity[pv.indexItem].ToString();
            lbl5.Text = "PHP " + pv.mealTotal[pv.indexItem].ToString("N2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pv.itemQuantity[pv.indexItem] += 1;
            pv.mealTotal[pv.indexItem] += pv.itemPrice[pv.indexItem];
            pv.totalBill += pv.itemPrice[pv.indexItem];
            pv.totalQuantity += 1;
            lbl4.Text = pv.itemQuantity[pv.indexItem].ToString();
            lbl5.Text = "PHP " + pv.mealTotal[pv.indexItem].ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pv.itemQuantity[pv.indexItem] > 0)
            {
                pv.itemQuantity[pv.indexItem] -= 1;
                pv.mealTotal[pv.indexItem] -= pv.itemPrice[pv.indexItem];
                pv.totalBill -= pv.itemPrice[pv.indexItem];
                pv.totalQuantity -= 1;
                lbl4.Text = pv.itemQuantity[pv.indexItem].ToString();
                lbl5.Text = "PHP " + pv.mealTotal[pv.indexItem].ToString("N2");
            }
            else
            {
                // nothing to show
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pv.itemQuantity[pv.indexItem] > 0)
            {
                MessageBox.Show("Order Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bCustomerOrderInterface form = new();
            form.Show();
            this.Close();
        }
    }
}
