using System.Drawing.Text;
using pv = backbone.PublicVariables;

namespace backbone.AdminForms
{
    public partial class userFormItem1 : UserControl
    {
        Functions func = new Functions();
        public userFormItem1()
        {
            InitializeComponent();
            PictureBox[] pictureBoxArray = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10 };
            func.mainDish(pictureBoxArray);
            getNames();
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
                    c.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                }
                label1.Font = new Font(pfc.Families[0], 14, FontStyle.Regular);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void getNames()
        {
            for (int i = 0; i < 10; i++)
            {
                var label = this.Controls.Find($"name{i + 1}", true).FirstOrDefault() as Label;

                if (label != null && i < pv.itemName.Length)
                {
                    label.Text = pv.itemName[i];
                }
            }
        }

        private void btnUpdatePrice1_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 0;
            proceedPrice();

        }
        private void btnAvailability1_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 0;
            proceedAvailability();
        }
        private void btnUpdatePrice2_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 1;
            proceedPrice();
        }
        private void btnAvailability2_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 1;
            proceedAvailability();
        }
        private void btnUpdatePrice3_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 2;
            proceedPrice();
        }
        private void btnAvailability3_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 2;
            proceedAvailability();
        }
        private void btnUpdatePrice4_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 3;
            proceedPrice();
        }
        private void btnAvailability4_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 3;
            proceedAvailability();
        }
        private void btnUpdatePrice5_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 4;
            proceedPrice();
        }
        private void btnAvailability5_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 4;
            proceedAvailability();
        }
        private void btnUpdatePrice6_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 5;
            proceedPrice();
        }
        private void btnAvailability6_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 5;
            proceedAvailability();
        }
        private void btnUpdatePrice7_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 6;
            proceedPrice();
        }
        private void btnAvailability7_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 6;
            proceedAvailability();
        }
        private void btnUpdatePrice8_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 7;
            proceedPrice();
        }
        private void btnAvailability8_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 7;
            proceedAvailability();
        }
        private void btnUpdatePrice9_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 8;
            proceedPrice();
        }
        private void btnAvailability9_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 8;
            proceedAvailability();
        }
        private void btnUpdatePrice10_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 9;
            proceedPrice();
        }
        private void btnAvailability10_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 9;
            proceedAvailability();
        }

        private void proceedPrice()
        {
            CloseItemForm();
            eUpdatePrice form = new eUpdatePrice();
            form.Show();
        }

        private void proceedAvailability()
        {
            CloseItemForm();
            eUpdateAvailability form = new();
            form.Show();
        }

        // to close parent form
        private void CloseItemForm()
        {
            if (ParentForm is dItemForm parent)
            {
                parent.Close();
            }
        }
    }
}
