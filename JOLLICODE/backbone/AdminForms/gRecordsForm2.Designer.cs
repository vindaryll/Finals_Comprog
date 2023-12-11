namespace backbone.AdminForms
{
    partial class gRecordsForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            lblPayment = new Label();
            lblChange = new Label();
            lblTotal = new Label();
            lblName = new Label();
            lblAddress = new Label();
            lblCustomerID = new Label();
            lblContact = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.doneonyellowbtn;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(627, 985);
            button1.Name = "button1";
            button1.Size = new Size(185, 40);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblPayment
            // 
            lblPayment.BackColor = Color.Transparent;
            lblPayment.FlatStyle = FlatStyle.Popup;
            lblPayment.ForeColor = Color.FromArgb(254, 100, 4);
            lblPayment.Location = new Point(282, 873);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(167, 25);
            lblPayment.TabIndex = 5;
            lblPayment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblChange
            // 
            lblChange.BackColor = Color.Transparent;
            lblChange.FlatStyle = FlatStyle.Popup;
            lblChange.ForeColor = Color.FromArgb(254, 100, 4);
            lblChange.Location = new Point(627, 873);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(167, 25);
            lblChange.TabIndex = 6;
            lblChange.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.Transparent;
            lblTotal.FlatStyle = FlatStyle.Popup;
            lblTotal.ForeColor = Color.FromArgb(254, 100, 4);
            lblTotal.Location = new Point(282, 918);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(167, 25);
            lblTotal.TabIndex = 7;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.BackColor = Color.Transparent;
            lblName.FlatStyle = FlatStyle.Popup;
            lblName.ForeColor = Color.FromArgb(254, 100, 4);
            lblName.Location = new Point(325, 269);
            lblName.Name = "lblName";
            lblName.Size = new Size(461, 26);
            lblName.TabIndex = 11;
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            lblAddress.BackColor = Color.Transparent;
            lblAddress.FlatStyle = FlatStyle.Popup;
            lblAddress.ForeColor = Color.FromArgb(254, 100, 4);
            lblAddress.Location = new Point(325, 314);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(461, 26);
            lblAddress.TabIndex = 17;
            lblAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCustomerID
            // 
            lblCustomerID.BackColor = Color.Transparent;
            lblCustomerID.FlatStyle = FlatStyle.Popup;
            lblCustomerID.ForeColor = Color.FromArgb(254, 100, 4);
            lblCustomerID.Location = new Point(325, 407);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(132, 26);
            lblCustomerID.TabIndex = 18;
            lblCustomerID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblContact
            // 
            lblContact.BackColor = Color.Transparent;
            lblContact.FlatStyle = FlatStyle.Popup;
            lblContact.ForeColor = Color.FromArgb(254, 100, 4);
            lblContact.Location = new Point(325, 361);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(461, 26);
            lblContact.TabIndex = 19;
            lblContact.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Location = new Point(63, 529);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 313);
            panel1.TabIndex = 20;
            // 
            // gRecordsForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Admin_Customer_Records_Interface;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(839, 1041);
            Controls.Add(panel1);
            Controls.Add(lblContact);
            Controls.Add(lblCustomerID);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Controls.Add(lblTotal);
            Controls.Add(lblChange);
            Controls.Add(lblPayment);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "gRecordsForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "gRecordsForm2";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label lblPayment;
        private Label lblChange;
        private Label lblTotal;
        private Label lblName;
        private Label lblAddress;
        private Label lblCustomerID;
        private Label lblContact;
        private Panel panel1;
    }
}