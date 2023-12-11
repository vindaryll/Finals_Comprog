using System.Drawing.Text;
using pv = backbone.PublicVariables;
namespace backbone.AdminForms
{
    public partial class dItemForm : Form
    {
        public dItemForm()
        {
            InitializeComponent();

            userFormItem1 form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
            useCustomFont();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cAdmin1 form = new();
            form.Show();
            panel1.Controls.Clear();
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            userFormItem1 form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            userFormItem2 form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            userFormItem3 form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }
    }
}
