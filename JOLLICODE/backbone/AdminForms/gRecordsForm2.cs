using System.Drawing.Text;
using System.Windows.Forms;
using pv = backbone.PublicVariables;

namespace backbone.AdminForms
{
    public partial class gRecordsForm2 : Form
    {
        Functions func = new();
        public gRecordsForm2()
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
                    c.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
                }
                lblName.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                lblAddress.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                lblContact.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                lblCustomerID.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                lblPayment.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                lblChange.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                lblTotal.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pv.orderID = 0; // to reset the orderID when clicking return
            this.Close();
            fRecordsForm1 form = new();
            form.Show();

        }
        private void showData()
        {
            func.getRecordsInfo();

            int initialTop = 6;
            int textBoxHeight = 31;
            int verticalSpacing = 31;

            for (int i = 0; i < pv.record_itemID.Length; i++)
            {
                // Create Label for Item ID
                Label itemIDLabel = new Label
                {
                    Text = pv.record_itemID[i].ToString(),
                    Location = new System.Drawing.Point(0, initialTop),
                    Size = new System.Drawing.Size(176, textBoxHeight),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                panel1.Controls.Add(itemIDLabel);

                // Create Label for Item Name
                Label itemNameLabel = new Label
                {
                    Text = pv.record_itemName[i].ToString(),
                    Location = new System.Drawing.Point(174, initialTop),
                    Size = new System.Drawing.Size(252, textBoxHeight),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                panel1.Controls.Add(itemNameLabel);

                // Create Label for Quantity
                Label quantityLabel = new Label
                {
                    Text = pv.record_quantity[i].ToString(),
                    Location = new System.Drawing.Point(422, initialTop),
                    Size = new System.Drawing.Size(131, textBoxHeight),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                panel1.Controls.Add(quantityLabel);

                // Create Label for Meal Total
                Label mealTotalLabel = new Label
                {
                    Text = pv.record_mealtotal[i].ToString("N2"),
                    Location = new System.Drawing.Point(522, initialTop),
                    Size = new System.Drawing.Size(159, textBoxHeight),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                panel1.Controls.Add(mealTotalLabel);

                initialTop += verticalSpacing;
            }

            lblTotal.Text = "PHP " + pv.totalBill.ToString("N2");
            lblPayment.Text = "PHP " + pv.paymentAmount.ToString("N2");
            lblChange.Text = "PHP " + pv.changeAmount.ToString("N2");
            lblCustomerID.Text = pv.customerID.ToString();
            lblName.Text = pv.customerName.ToString();
            lblContact.Text = pv.customerContact.ToString();
            lblAddress.Text = pv.customerAddress.ToString();
        }
    }
}
