namespace backbone
{
    public partial class WelcomeInterface1 : Form
    {

        Functions func = new();

        public WelcomeInterface1()
        {
            InitializeComponent();
            func.refreshCustomer();
            func.refreshOrders();
            func.refreshOrderTransaction();
            func.refreshOrderItem();
            func.VarReset();
            func.getItemInfo();
        }

        private void Form1_click(object sender, EventArgs e)
        {
            WelcomeInterface2 form = new();
            form.Show();
            this.Close();
        }
    }
}