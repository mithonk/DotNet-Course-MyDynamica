namespace Simple_Calculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtResult = new TextBox();
            groupBox1 = new GroupBox();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMulti = new Button();
            btnDivi = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe Fluent Icons", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 34);
            label1.TabIndex = 0;
            label1.Text = "Number Calculator";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(11, 69);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 1;
            label2.Text = "Number1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(11, 116);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 1;
            label3.Text = "Number2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(11, 163);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 1;
            label4.Text = "Results";
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Segoe UI", 12F);
            txtNum1.Location = new Point(116, 58);
            txtNum1.Margin = new Padding(3, 4, 3, 4);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(178, 34);
            txtNum1.TabIndex = 0;
            txtNum1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Segoe UI", 12F);
            txtNum2.Location = new Point(116, 105);
            txtNum2.Margin = new Padding(3, 4, 3, 4);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(178, 34);
            txtNum2.TabIndex = 1;
            txtNum2.TextAlign = HorizontalAlignment.Right;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 12F);
            txtResult.Location = new Point(116, 152);
            txtResult.Margin = new Padding(3, 4, 3, 4);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(178, 34);
            txtResult.TabIndex = 2;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(0, 193);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 8);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(96, 207);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(45, 45);
            btnPlus.TabIndex = 3;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(147, 207);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(45, 45);
            btnMinus.TabIndex = 4;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMulti.Location = new Point(198, 207);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(45, 45);
            btnMulti.TabIndex = 5;
            btnMulti.Text = "x";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDivi
            // 
            btnDivi.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivi.Location = new Point(249, 207);
            btnDivi.Name = "btnDivi";
            btnDivi.Size = new Size(45, 45);
            btnDivi.TabIndex = 6;
            btnDivi.Text = "%";
            btnDivi.UseVisualStyleBackColor = true;
            btnDivi.Click += btnDivi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 260);
            Controls.Add(btnDivi);
            Controls.Add(btnMulti);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(groupBox1);
            Controls.Add(txtResult);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Simple Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtResult;
        private GroupBox groupBox1;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMulti;
        private Button btnDivi;
    }
}
