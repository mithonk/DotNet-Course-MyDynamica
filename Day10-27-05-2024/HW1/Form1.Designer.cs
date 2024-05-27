namespace HW1
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
            fname = new TextBox();
            btn = new Button();
            male = new RadioButton();
            grade = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lname = new TextBox();
            female = new RadioButton();
            label5 = new Label();
            add = new TextBox();
            gender = new GroupBox();
            gender.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // fname
            // 
            fname.Location = new Point(133, 30);
            fname.Name = "fname";
            fname.Size = new Size(266, 27);
            fname.TabIndex = 0;
            // 
            // btn
            // 
            btn.BackColor = SystemColors.ActiveCaption;
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn.Location = new Point(305, 367);
            btn.Name = "btn";
            btn.Size = new Size(94, 44);
            btn.TabIndex = 7;
            btn.Text = "View";
            btn.UseVisualStyleBackColor = false;
            btn.Click += btn_Click;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            male.Location = new Point(20, 17);
            male.Name = "male";
            male.Size = new Size(77, 32);
            male.TabIndex = 3;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // grade
            // 
            grade.FormattingEnabled = true;
            grade.Items.AddRange(new object[] { "10A", "10B", "10C", "11A", "11B", "11C" });
            grade.Location = new Point(133, 181);
            grade.Name = "grade";
            grade.Size = new Size(266, 28);
            grade.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 0;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 0;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 177);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 0;
            label4.Text = "Grade";
            // 
            // lname
            // 
            lname.Location = new Point(133, 81);
            lname.Name = "lname";
            lname.Size = new Size(266, 27);
            lname.TabIndex = 1;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            female.Location = new Point(115, 17);
            female.Name = "female";
            female.Size = new Size(98, 32);
            female.TabIndex = 4;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 227);
            label5.Name = "label5";
            label5.Size = new Size(87, 28);
            label5.TabIndex = 0;
            label5.Text = "Address";
            // 
            // add
            // 
            add.Location = new Point(133, 231);
            add.Multiline = true;
            add.Name = "add";
            add.Size = new Size(266, 130);
            add.TabIndex = 6;
            // 
            // gender
            // 
            gender.Controls.Add(male);
            gender.Controls.Add(female);
            gender.Location = new Point(133, 122);
            gender.Name = "gender";
            gender.Size = new Size(266, 50);
            gender.TabIndex = 2;
            gender.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(416, 427);
            Controls.Add(gender);
            Controls.Add(grade);
            Controls.Add(btn);
            Controls.Add(add);
            Controls.Add(lname);
            Controls.Add(fname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            gender.ResumeLayout(false);
            gender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox fname;
        private Button btn;
        private RadioButton male;
        private ComboBox grade;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox lname;
        private RadioButton female;
        private Label label5;
        private TextBox add;
        private GroupBox gender;
    }
}
