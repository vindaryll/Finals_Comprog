using System.Drawing.Text;
using pv = backbone.PublicVariables;

namespace backbone.AdminForms
{
    public partial class fRecordsForm1 : Form
    {
        Functions func = new();
        public fRecordsForm1()
        {
            InitializeComponent();
            refresh();
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
                textBox1.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            cAdmin1 form = new();
            form.Show();
        }

        private void refresh_click(object sender, EventArgs e)
        {
            refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT o.OrderID, c.CustomerName, o.OrderTime AS Date, o.PaymentMethod\r\nFROM Customer AS c\r\nJOIN Orders AS o ON c.CustomerID = o.CustomerID\r\nJOIN OrderItem AS oi ON o.OrderID = oi.OrderID\r\nJOIN OrderTransaction as ot ON ot.OrderID = o.OrderID\r\nWHERE c.CustomerName LIKE '%{textBox1.Text}%'\r\nGROUP BY o.OrderID, c.customerName\r\nORDER BY Date";
            func.Displaydata(dataGridView1, query);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string? orderIDString = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (int.TryParse(orderIDString, out int orderID))
                {

                    pv.orderID = orderID;
                }
                else
                {
                    pv.orderID = 0;
                }
            }
            catch
            {
                refresh();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pv.orderID == 0)
            {
                // nothing to show
            }
            else
            {
                gRecordsForm2 form = new();
                form.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pv.orderID == 0)
            {
                // nothing to show
            }
            else
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete Order no. {pv.orderID}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // User confirmed deletion
                    func.deleteRecords();
                    func.deleteCustomer(); // Delete customer if no records in orders
                    func.refreshCustomer();
                    func.refreshOrderItem();
                    func.refreshOrderTransaction();
                    func.refreshOrders();
                    MessageBox.Show($"Order no. {pv.orderID} has been deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();

                }
                // If the user clicks "No", do nothing

            }
        }

        private void refresh()
        {
            string query = "SELECT o.OrderID, c.CustomerName, o.OrderTime AS Date, o.PaymentMethod\r\nFROM Customer AS c\r\nJOIN Orders AS o ON c.CustomerID = o.CustomerID\r\nJOIN OrderItem AS oi ON o.OrderID = oi.OrderID\r\nJOIN OrderTransaction as ot ON ot.OrderID = o.OrderID\r\nGROUP BY o.OrderID, c.customerName\r\nORDER BY Date";
            func.Displaydata(dataGridView1, query);
            textBox1.Text = string.Empty;
            pv.orderID = 0;
            dataGridView1.ClearSelection();
        }
    }
}
