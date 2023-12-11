namespace backbone
{
    public partial class WelcomeInterface2 : Form
    {

        public WelcomeInterface2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerForms.aCustomerInformation form = new();
            this.Close();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForms.aLoginForm form = new();
            form.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WelcomeInterface1 form1 = new();
            form1.Show();
            this.Close();
        }
    }
}
