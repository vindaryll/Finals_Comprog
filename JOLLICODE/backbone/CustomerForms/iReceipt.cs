using System.Drawing.Text;
using pv = backbone.PublicVariables;

namespace backbone.CustomerForms
{
    public partial class iReceipt : Form
    {
        Functions func = new();
        public iReceipt()
        {
            InitializeComponent();
            dataQueries();
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
                    c.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void showData()
        {
            int initialTop = 11;
            int textBoxHeight = 31;
            int verticalSpacing = 31;

            for (int i = 0; i < 22; i++)
            {
                if (pv.itemQuantity[i] > 0)
                {
                    // Create Label for Item Name
                    Label itemNameLabel = new Label
                    {
                        Text = $"{pv.itemName[i]}",
                        Location = new System.Drawing.Point(18, initialTop),
                        Size = new System.Drawing.Size(361, textBoxHeight),
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = System.Drawing.Color.FromArgb(255, 49, 49)
                    };
                    panel1.Controls.Add(itemNameLabel);

                    // Create Label for Quantity
                    Label quantityLabel = new Label
                    {
                        Text = $"{pv.itemQuantity[i]}",
                        Location = new System.Drawing.Point(406, initialTop),
                        Size = new System.Drawing.Size(111, textBoxHeight),
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = System.Drawing.Color.FromArgb(255, 49, 49)
                    };
                    panel1.Controls.Add(quantityLabel);

                    // Create Label for Sub price
                    Label subpriceLabel = new Label
                    {
                        Text = pv.mealTotal[i].ToString("N2"),
                        Location = new System.Drawing.Point(534, initialTop),
                        Size = new System.Drawing.Size(168, textBoxHeight),
                        TextAlign = ContentAlignment.MiddleCenter,
                        ForeColor = System.Drawing.Color.FromArgb(255, 49, 49)
                    };
                    panel1.Controls.Add(subpriceLabel);

                    // Adjust the initialTop for the next set of Labels
                    initialTop += verticalSpacing;
                }
            }

            lblOrderID.Text = pv.orderID.ToString();
            lblName.Text = pv.customerName.ToString();
            lblAddress.Text = pv.customerAddress.ToString();
            lblPhone.Text = pv.customerContact.ToString();
            lblDate.Text = pv.date;
            lblMop.Text = pv.paymentMethod;
            lblTotal.Text = "PHP " + pv.totalBill.ToString("N2");
            lblPayment.Text = "PHP " + pv.paymentAmount.ToString("N2");
            lblChange.Text = "PHP " + pv.changeAmount.ToString("N2");

        }

        private void dataQueries()
        {
            // Insert Customer
            func.getCustomerID(pv.customerName, pv.customerContact);
            if (pv.isNewCustomer)
            {
                func.InsertCustomers(pv.customerName, pv.customerContact, pv.customerAddress);
                func.refreshCustomer();
            }
            // Insert Order
            func.getOrderID();
            func.InsertOrders(pv.customerID, pv.paymentMethod);
            func.refreshOrders();
            // Insert Transaction
            func.InsertOrderTransaction(pv.orderID, pv.totalBill, pv.paymentAmount, pv.changeAmount);
            func.refreshOrderTransaction();
            //Insert OrderItem
            for (int i = 0; i < 22; i++)
            {
                if (pv.itemQuantity[i] > 0)
                {
                    func.InsertOrderItem(pv.orderID, pv.itemID[i], pv.itemQuantity[i], pv.mealTotal[i]);
                }

            }
            func.refreshOrderItem();
            // getting date
            func.getDate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            func.VarReset();
            MiscForms.OrderDone form = new();
            form.Show();
            this.Close();
        }
    }
}
