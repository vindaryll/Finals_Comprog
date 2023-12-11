namespace backbone.AdminForms
{
    partial class dItemForm
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
            panel1 = new Panel();
            button4 = new Button();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(217, 278);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 640);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.redreturnonyellowbtn;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(25, 986);
            button4.Name = "button4";
            button4.Size = new Size(185, 37);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.FromArgb(255, 49, 49);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.BowlFood;
            iconButton1.IconColor = Color.FromArgb(255, 49, 49);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 85;
            iconButton1.ImageAlign = ContentAlignment.TopCenter;
            iconButton1.Location = new Point(0, 416);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(148, 105);
            iconButton1.TabIndex = 5;
            iconButton1.Text = "MAIN DISH";
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Transparent;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.FromArgb(255, 49, 49);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Hotdog;
            iconButton2.IconColor = Color.FromArgb(255, 49, 49);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 85;
            iconButton2.ImageAlign = ContentAlignment.TopCenter;
            iconButton2.Location = new Point(0, 570);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(148, 105);
            iconButton2.TabIndex = 6;
            iconButton2.Text = "SIDES";
            iconButton2.TextAlign = ContentAlignment.BottomCenter;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Transparent;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.ForeColor = Color.FromArgb(255, 49, 49);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.GlassWater;
            iconButton3.IconColor = Color.FromArgb(255, 49, 49);
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 85;
            iconButton3.ImageAlign = ContentAlignment.TopCenter;
            iconButton3.Location = new Point(0, 724);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(148, 105);
            iconButton3.TabIndex = 7;
            iconButton3.Text = "BEVERAGES";
            iconButton3.TextAlign = ContentAlignment.BottomCenter;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // dItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Admin_Item_Interface__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(839, 1041);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(button4);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "dItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dItemForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}