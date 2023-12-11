using System.Drawing.Text;
using pv = backbone.PublicVariables;
namespace backbone.AdminForms
{
    public partial class eUpdateAvailability : Form
    {
        Functions func = new();
        bool avail; // variable for availability
        public eUpdateAvailability()
        {
            InitializeComponent();
            showData();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }
        private void showData()
        {
            func.getItemInfo();
            func.picsUpdate(pv.adminItemIndex, button1, button2);
            func.picture(pv.adminItemIndex, pictureBox1);
            label1.Text = pv.itemName[pv.adminItemIndex].ToString();
            label2.Text = $"ITEM ID: {pv.itemID[pv.adminItemIndex]}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dItemForm form = new();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!pv.itemAvailability[pv.adminItemIndex])
            {
                DialogResult result = MessageBox.Show($"Do you want to set Item no.{pv.itemID[pv.adminItemIndex]} into available?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    avail = true;
                    func.updateAvailability(pv.adminItemIndex, avail);
                    MessageBox.Show("Availability Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                }

            }
            else
            {
                // nothing to show
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pv.itemAvailability[pv.adminItemIndex])
            {
                DialogResult result = MessageBox.Show($"Do you want to set Item no.{pv.itemID[pv.adminItemIndex]} into unavailable?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    avail = false;
                    func.updateAvailability(pv.adminItemIndex, avail);
                    MessageBox.Show("Availability Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showData();
                }

            }
            else
            {
                // nothing to show
            }
        }
    }
}
