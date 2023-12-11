namespace backbone.AdminForms
{
    partial class eUpdatePrice
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
            pictureBox1 = new PictureBox();
            lblPrice = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            lblItemName = new Label();
            lblItemId = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(87, 383);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 197);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblPrice
            // 
            lblPrice.BackColor = Color.FromArgb(242, 242, 242);
            lblPrice.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrice.ForeColor = Color.Black;
            lblPrice.ImageAlign = ContentAlignment.TopLeft;
            lblPrice.Location = new Point(134, 626);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(566, 36);
            lblPrice.TabIndex = 3;
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(242, 242, 242);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(134, 735);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(566, 29);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.savebtn;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(627, 986);
            button1.Name = "button1";
            button1.Size = new Size(186, 37);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.redreturnonorangebtn;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(25, 986);
            button2.Name = "button2";
            button2.Size = new Size(185, 37);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblItemName
            // 
            lblItemName.BackColor = Color.FromArgb(242, 242, 242);
            lblItemName.FlatStyle = FlatStyle.Flat;
            lblItemName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemName.ForeColor = Color.FromArgb(254, 100, 4);
            lblItemName.ImageAlign = ContentAlignment.TopLeft;
            lblItemName.Location = new Point(353, 433);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(387, 36);
            lblItemName.TabIndex = 7;
            lblItemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblItemId
            // 
            lblItemId.BackColor = Color.FromArgb(242, 242, 242);
            lblItemId.FlatStyle = FlatStyle.Flat;
            lblItemId.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblItemId.ForeColor = Color.Black;
            lblItemId.ImageAlign = ContentAlignment.TopLeft;
            lblItemId.Location = new Point(353, 480);
            lblItemId.Name = "lblItemId";
            lblItemId.Size = new Size(387, 36);
            lblItemId.TabIndex = 8;
            lblItemId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // eUpdatePrice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Admin_Update_Price_Interface__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(839, 1041);
            Controls.Add(lblItemId);
            Controls.Add(lblItemName);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(lblPrice);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "eUpdatePrice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "eUpdateForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblPrice;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label lblItemName;
        private Label lblItemId;
    }
}