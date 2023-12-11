namespace backbone.AdminForms
{
    partial class eUpdateAvailability
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(308, 295);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 195);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(153, 651);
            button1.Name = "button1";
            button1.Size = new Size(226, 218);
            button1.TabIndex = 42;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(463, 651);
            button2.Name = "button2";
            button2.Size = new Size(228, 218);
            button2.TabIndex = 43;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(242, 242, 242);
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = Color.FromArgb(254, 100, 4);
            label1.Location = new Point(209, 537);
            label1.Name = "label1";
            label1.Size = new Size(428, 37);
            label1.TabIndex = 44;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(242, 242, 242);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(209, 580);
            label2.Name = "label2";
            label2.Size = new Size(428, 37);
            label2.TabIndex = 45;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.redreturnonyellowbtn;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(25, 986);
            button3.Name = "button3";
            button3.Size = new Size(185, 37);
            button3.TabIndex = 46;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // eUpdateAvailability
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Admin_Update_Availability_Interface__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(839, 1041);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "eUpdateAvailability";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "eAvailability";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button3;
    }
}