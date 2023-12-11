using System.Drawing.Text;
using pv = backbone.PublicVariables;

namespace backbone.AdminForms
{
    public partial class userFormItem3 : UserControl
    {
        Functions func = new();
        public userFormItem3()
        {
            InitializeComponent();
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7 };
            func.beverages(pictureBoxes);
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
            for (int i = 15; i <= 21; i++)
            {
                var label = this.Controls.Find($"name{i - 14}", true).FirstOrDefault() as Label;

                if (label != null && i < pv.itemName.Length)
                {
                    label.Text = pv.itemName[i];
                }
            }
        }

        private void btnUpdatePrice1_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 15;
            proceedPrice();
        }

        private void btnAvailability1_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 15;
            proceedAvailability();
        }

        private void btnUpdatePrice2_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 16;
            proceedPrice();
        }

        private void btnAvailability2_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 16;
            proceedAvailability();
        }

        private void btnUpdatePrice3_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 17;
            proceedPrice();
        }

        private void btnAvailability3_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 17;
            proceedAvailability();
        }

        private void btnUpdatePrice4_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 18;
            proceedPrice();
        }

        private void btnAvailability4_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 18;
            proceedAvailability();
        }

        private void btnUpdatePrice5_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 19;
            proceedPrice();
        }

        private void btnAvailability5_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 19;
            proceedAvailability();
        }

        private void btnUpdatePrice6_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 20;
            proceedPrice();
        }

        private void btnAvailability6_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 20;
            proceedAvailability();
        }

        private void btnUpdatePrice7_Click(object sender, EventArgs e)
        {
            CloseItemForm();
            pv.adminItemIndex = 21;
            proceedPrice();
        }
        private void btnAvailability7_Click(object sender, EventArgs e)
        {
            pv.adminItemIndex = 21;
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

        private void CloseItemForm()
        {
            if (ParentForm is dItemForm parent)
            {
                parent.Close();
            }
        }
    }
}
