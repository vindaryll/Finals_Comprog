namespace backbone.CustomerForms
{
    public partial class fPayment : Form
    {
        public fPayment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gPaymentCash form = new();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dViewOrder form = new();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hPaymentEPayment form = new();
            form.Show();
            this.Close();
        }
    }
}
