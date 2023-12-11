using System.Drawing.Text;
using pv = backbone.PublicVariables;

namespace backbone.CustomerForms
{
    public partial class dViewOrder : Form
    {
        Functions func = new();
        public dViewOrder()
        {
            InitializeComponent();
            showData();
            lblTotalBill.Text = "PHP " + pv.totalBill.ToString("N2");
            lblTotalQuantity.Text = pv.totalQuantity.ToString();
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
                lblTotalQuantity.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                lblTotalBill.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void showData()
        {
            dataGridView1.Rows.Clear();
            func.showItemOnDT(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bCustomerOrderInterface form = new();
            this.Close();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fPayment form = new();
            this.Close();
            form.Show();
        }

        private void dataGridView1_mouseclick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string? itemIDString = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (int.TryParse(itemIDString, out int itemID))
                {
                    if (itemID > 0)
                    {
                        pv.indexItem = itemID - 1;
                        eEditOrder form = new();
                        form.Show();
                        this.Close();
                    }
                    else
                    {
                        // nothing to show
                    }
                }
            }
            catch
            {
                // nothing to show
            }

        }
    }
}
