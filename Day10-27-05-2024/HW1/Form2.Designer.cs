namespace HW1
{
    partial class Form2
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            viewFname = new Label();
            viewLname = new Label();
            viewGender = new Label();
            viewGrade = new Label();
            viewAddress = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(87, 28);
            label5.TabIndex = 1;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 139);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 2;
            label4.Text = "Grade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 3;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 5;
            label1.Text = "First Name";
            // 
            // viewFname
            // 
            viewFname.AutoSize = true;
            viewFname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewFname.Location = new Point(154, 9);
            viewFname.Name = "viewFname";
            viewFname.Size = new Size(0, 28);
            viewFname.TabIndex = 5;
            // 
            // viewLname
            // 
            viewLname.AutoSize = true;
            viewLname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewLname.Location = new Point(154, 53);
            viewLname.Name = "viewLname";
            viewLname.Size = new Size(0, 28);
            viewLname.TabIndex = 5;
            // 
            // viewGender
            // 
            viewGender.AutoSize = true;
            viewGender.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewGender.Location = new Point(154, 93);
            viewGender.Name = "viewGender";
            viewGender.Size = new Size(0, 28);
            viewGender.TabIndex = 5;
            // 
            // viewGrade
            // 
            viewGrade.AutoSize = true;
            viewGrade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewGrade.Location = new Point(154, 139);
            viewGrade.Name = "viewGrade";
            viewGrade.Size = new Size(0, 28);
            viewGrade.TabIndex = 5;
            // 
            // viewAddress
            // 
            viewAddress.AutoSize = true;
            viewAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewAddress.Location = new Point(154, 185);
            viewAddress.Name = "viewAddress";
            viewAddress.Size = new Size(0, 28);
            viewAddress.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(381, 300);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(viewAddress);
            Controls.Add(viewGrade);
            Controls.Add(viewGender);
            Controls.Add(viewLname);
            Controls.Add(viewFname);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label viewFname;
        private Label viewLname;
        private Label viewGender;
        private Label viewGrade;
        private Label viewAddress;
    }
}