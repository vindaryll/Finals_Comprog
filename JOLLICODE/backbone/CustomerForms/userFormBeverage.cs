using System.Drawing.Text;
using pv = backbone.PublicVariables;

namespace backbone.CustomerForms
{
    public partial class userFormBeverage : UserControl
    {
        Functions func = new();
        public userFormBeverage()
        {
            InitializeComponent();
            getBtnInfo();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void getBtnInfo()
        {
            // names
            for (int i = 15; i <= 21; i++)
            {
                var button = this.Controls.Find($"button{i - 14}", true).FirstOrDefault() as Button;

                if (button != null && i < pv.itemName.Length)
                {
                    button.Text = pv.itemName[i];
                }
            }

            // image
            Button[] buttons = { button1, button2, button3, button4, button5, button6, button7 };
            func.beveragesBtns(buttons);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pv.indexItem = 15;
            isAvailable(pv.indexItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pv.indexItem = 16;
            isAvailable(pv.indexItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pv.indexItem = 17;
            isAvailable(pv.indexItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pv.indexItem = 18;
            isAvailable(pv.indexItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pv.indexItem = 19;
            isAvailable(pv.indexItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pv.indexItem = 20;
            isAvailable(pv.indexItem);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pv.indexItem = 21;
            isAvailable(pv.indexItem);
        }
        private void isAvailable(int index)
        {
            if (pv.itemAvailability[index])
            {
                order();
                CloseOrderInterface();
            }
            else
            {
                MessageBox.Show("Sorry, the Item is Unavailable", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void order()
        {
            cOrderItem form = new();
            form.Show();
        }

        private void CloseOrderInterface()
        {
            if (ParentForm is bCustomerOrderInterface parent)
            {
                parent.Close();
            }
        }
    }
}
