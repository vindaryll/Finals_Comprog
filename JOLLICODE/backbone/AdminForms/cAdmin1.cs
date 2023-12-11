
namespace backbone.AdminForms
{
    public partial class cAdmin1 : Form
    {
        public cAdmin1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dItemForm form = new dItemForm();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MiscForms.LoggingOut form = new();
                form.Show();
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to shut the system down?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MiscForms.ShuttingDown form = new();
                form.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            fRecordsForm1 form = new();
            form.Show();
        }
    }
}
