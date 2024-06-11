namespace WinFormsApp10
{
    partial class FormMine
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
            Label_Ore = new Label();
            Button_Ore_Sell = new Button();
            textBox1 = new TextBox();
            Label_Worker = new Label();
            Button_Worker_Buy = new Button();
            SuspendLayout();
            // 
            // Label_Ore
            // 
            Label_Ore.AutoSize = true;
            Label_Ore.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Ore.Location = new Point(12, 9);
            Label_Ore.Name = "Label_Ore";
            Label_Ore.Size = new Size(105, 36);
            Label_Ore.TabIndex = 0;
            Label_Ore.Text = "ORE: 0";
            // 
            // Button_Ore_Sell
            // 
            Button_Ore_Sell.Cursor = Cursors.Cross;
            Button_Ore_Sell.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Ore_Sell.Location = new Point(187, 57);
            Button_Ore_Sell.Name = "Button_Ore_Sell";
            Button_Ore_Sell.Size = new Size(108, 50);
            Button_Ore_Sell.TabIndex = 1;
            Button_Ore_Sell.Text = "SELL";
            Button_Ore_Sell.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F);
            textBox1.Location = new Point(12, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 50);
            textBox1.TabIndex = 2;
            // 
            // Label_Worker
            // 
            Label_Worker.AutoSize = true;
            Label_Worker.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_Worker.Location = new Point(12, 123);
            Label_Worker.Name = "Label_Worker";
            Label_Worker.Size = new Size(220, 36);
            Label_Worker.TabIndex = 0;
            Label_Worker.Text = "worker: 300$";
            // 
            // Button_Worker_Buy
            // 
            Button_Worker_Buy.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button_Worker_Buy.Location = new Point(64, 162);
            Button_Worker_Buy.Name = "Button_Worker_Buy";
            Button_Worker_Buy.Size = new Size(108, 50);
            Button_Worker_Buy.TabIndex = 1;
            Button_Worker_Buy.Text = "buy";
            Button_Worker_Buy.UseVisualStyleBackColor = true;
            // 
            // FormMine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 247);
            Controls.Add(textBox1);
            Controls.Add(Button_Worker_Buy);
            Controls.Add(Button_Ore_Sell);
            Controls.Add(Label_Worker);
            Controls.Add(Label_Ore);
            Name = "FormMine";
            Text = " ";
            Load += FormMine_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Ore;
        private Button Button_Ore_Sell;
        private TextBox textBox1;
        private Label Label_Worker;
        private Button Button_Worker_Buy;
    }
}