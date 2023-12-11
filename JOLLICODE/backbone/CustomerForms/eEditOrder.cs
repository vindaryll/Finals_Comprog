using Org.BouncyCastle.Asn1.Pkcs;
using System.Drawing.Text;
using pv = backbone.PublicVariables;

namespace backbone.CustomerForms
{
    public partial class eEditOrder : Form
    {
        Functions func = new();
        public eEditOrder()
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
                lblItemName.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                lblPrice.Font = new Font(pfc.Families[0], 14, FontStyle.Regular);
                lblQuantity.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
                lblMealTotal.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void showData()
        {
            func.picture(pv.indexItem, pictureBox1);
            lblItemName.Text = pv.itemName[pv.indexItem].ToString();
            lblPrice.Text = pv.itemPrice[pv.indexItem].ToString("N2");
            lblQuantity.Text = pv.itemQuantity[pv.indexItem].ToString();
            lblMealTotal.Text = "PHP " + pv.mealTotal[pv.indexItem].ToString("N2");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pv.itemQuantity[pv.indexItem] > 0)
            {
                if (pv.itemQuantity[pv.indexItem] == 1)
                {
                    DialogResult option = MessageBox.Show($"Are you sure to remove item no.{pv.indexItem + 1}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (option == DialogResult.Yes)
                    {
                        // If the user clicks "Yes", the system will remove the item and will automatically get back to designated interface
                        minus();
                        getBack();
                    }
                    // If the user clicks "No", do nothing
                }
                else
                {
                    minus();
                }

            }
            else
            {
                // nothing to show
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getBack();
        }


        private void add()
        {
            pv.itemQuantity[pv.indexItem] += 1;
            pv.mealTotal[pv.indexItem] += pv.itemPrice[pv.indexItem];
            pv.totalBill += pv.itemPrice[pv.indexItem];
            pv.totalQuantity += 1;
            lblQuantity.Text = pv.itemQuantity[pv.indexItem].ToString();
            lblMealTotal.Text = "PHP " + pv.mealTotal[pv.indexItem].ToString("N2");
        }

        private void minus()
        {
            pv.itemQuantity[pv.indexItem] -= 1;
            pv.mealTotal[pv.indexItem] -= pv.itemPrice[pv.indexItem];
            pv.totalBill -= pv.itemPrice[pv.indexItem];
            pv.totalQuantity -= 1;
            lblQuantity.Text = pv.itemQuantity[pv.indexItem].ToString();
            lblMealTotal.Text = "PHP " + pv.mealTotal[pv.indexItem].ToString("N2");
        }

        private void getBack()
        {
            if (pv.totalQuantity > 0)
            {
                dViewOrder form = new();
                form.Show();
                this.Close();
            }
            else
            {
                bCustomerOrderInterface form = new();
                form.Show();
                this.Close();
            }
        }
    }
}
