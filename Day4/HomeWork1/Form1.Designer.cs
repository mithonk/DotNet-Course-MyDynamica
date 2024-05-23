namespace HomeWork1
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
            no1 = new TextBox();
            addBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            no2 = new TextBox();
            viewResults = new TextBox();
            subBtn = new Button();
            mulBtn = new Button();
            divBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 31);
            label1.Name = "label1";
            label1.Size = new Size(101, 26);
            label1.TabIndex = 0;
            label1.Text = "Number 1";
            // 
            // no1
            // 
            no1.Location = new Point(320, 31);
            no1.Name = "no1";
            no1.Size = new Size(316, 27);
            no1.TabIndex = 0;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("MS Reference Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(150, 262);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(94, 54);
            addBtn.TabIndex = 2;
            addBtn.Text = "+";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(150, 80);
            label2.Name = "label2";
            label2.Size = new Size(104, 26);
            label2.TabIndex = 0;
            label2.Text = "Number 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(150, 161);
            label3.Name = "label3";
            label3.Size = new Size(79, 26);
            label3.TabIndex = 0;
            label3.Text = "Results";
            // 
            // no2
            // 
            no2.Location = new Point(320, 80);
            no2.Name = "no2";
            no2.Size = new Size(316, 27);
            no2.TabIndex = 1;
            // 
            // viewResults
            // 
            viewResults.Location = new Point(320, 160);
            viewResults.Name = "viewResults";
            viewResults.Size = new Size(316, 27);
            viewResults.TabIndex = 2;
            // 
            // subBtn
            // 
            subBtn.Font = new Font("MS Reference Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subBtn.Location = new Point(280, 262);
            subBtn.Name = "subBtn";
            subBtn.Size = new Size(94, 54);
            subBtn.TabIndex = 2;
            subBtn.Text = "-";
            subBtn.UseVisualStyleBackColor = true;
            subBtn.Click += subBtn_Click;
            // 
            // mulBtn
            // 
            mulBtn.Font = new Font("MS Reference Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mulBtn.Location = new Point(406, 262);
            mulBtn.Name = "mulBtn";
            mulBtn.Size = new Size(94, 54);
            mulBtn.TabIndex = 2;
            mulBtn.Text = "*";
            mulBtn.UseVisualStyleBackColor = true;
            mulBtn.Click += mulBtn_Click;
            // 
            // divBtn
            // 
            divBtn.Font = new Font("MS Reference Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            divBtn.Location = new Point(542, 262);
            divBtn.Name = "divBtn";
            divBtn.Size = new Size(94, 54);
            divBtn.TabIndex = 2;
            divBtn.Text = "/";
            divBtn.UseVisualStyleBackColor = true;
            divBtn.Click += divBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(793, 404);
            Controls.Add(divBtn);
            Controls.Add(mulBtn);
            Controls.Add(subBtn);
            Controls.Add(addBtn);
            Controls.Add(viewResults);
            Controls.Add(no2);
            Controls.Add(no1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "SImple Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox no1;
        private Button addBtn;
        private Label label2;
        private Label label3;
        private TextBox no2;
        private TextBox viewResults;
        private Button subBtn;
        private Button mulBtn;
        private Button divBtn;
    }
}
