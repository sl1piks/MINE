namespace WinFormsApp10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Picture_Box_Mine = new PictureBox();
            Label_Balance = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Picture_Box_Mine).BeginInit();
            SuspendLayout();
            // 
            // Picture_Box_Mine
            // 
            Picture_Box_Mine.Image = Resource1.ironMine;
            Picture_Box_Mine.Location = new Point(23, 134);
            Picture_Box_Mine.Name = "Picture_Box_Mine";
            Picture_Box_Mine.Size = new Size(238, 217);
            Picture_Box_Mine.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture_Box_Mine.TabIndex = 0;
            Picture_Box_Mine.TabStop = false;
            Picture_Box_Mine.Click += pictureBox1_Click;
            // 
            // Label_Balance
            // 
            Label_Balance.AutoSize = true;
            Label_Balance.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Balance.Location = new Point(33, 95);
            Label_Balance.Name = "Label_Balance";
            Label_Balance.Size = new Size(212, 36);
            Label_Balance.TabIndex = 1;
            Label_Balance.Text = "Balance: 100$";
            Label_Balance.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(Label_Balance);
            Controls.Add(Picture_Box_Mine);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Picture_Box_Mine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Picture_Box_Mine;
        private Label Label_Balance;
        private System.Windows.Forms.Timer timer1;
    }
}
