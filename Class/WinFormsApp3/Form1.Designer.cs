namespace WinFormsApp3
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
            viewFullName = new Label();
            fname = new TextBox();
            lname = new TextBox();
            button1 = new Button();
            label1 = new Label();
            fullname = new Label();
            label2 = new Label();
            viewtext = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // viewFullName
            // 
            viewFullName.Location = new Point(71, 34);
            viewFullName.Name = "viewFullName";
            viewFullName.Size = new Size(118, 27);
            viewFullName.TabIndex = 0;
            viewFullName.Text = "First Name";
            viewFullName.Click += label1_Click;
            // 
            // fname
            // 
            fname.Location = new Point(195, 34);
            fname.Name = "fname";
            fname.Size = new Size(392, 27);
            fname.TabIndex = 0;
            fname.TextChanged += textBox1_TextChanged;
            // 
            // lname
            // 
            lname.Location = new Point(195, 115);
            lname.Name = "lname";
            lname.Size = new Size(392, 27);
            lname.TabIndex = 2;
            lname.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(332, 191);
            button1.Name = "button1";
            button1.Size = new Size(94, 35);
            button1.TabIndex = 3;
            button1.Text = "View";
            button1.UseVisualStyleBackColor = true;
            button1.Click += view_Click;
            // 
            // label1
            // 
            label1.Location = new Point(71, 115);
            label1.Name = "label1";
            label1.Size = new Size(118, 27);
            label1.TabIndex = 0;
            label1.Text = "Last Name";
            label1.Click += label1_Click;
            // 
            // fullname
            // 
            fullname.BorderStyle = BorderStyle.FixedSingle;
            fullname.Location = new Point(195, 287);
            fullname.Name = "fullname";
            fullname.Size = new Size(392, 27);
            fullname.TabIndex = 0;
            fullname.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(71, 287);
            label2.Name = "label2";
            label2.Size = new Size(118, 27);
            label2.TabIndex = 0;
            label2.Text = "Full Name";
            label2.Click += label1_Click;
            // 
            // viewtext
            // 
            viewtext.Location = new Point(195, 343);
            viewtext.Name = "viewtext";
            viewtext.Size = new Size(392, 27);
            viewtext.TabIndex = 3;
            viewtext.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.Location = new Point(71, 346);
            label3.Name = "label3";
            label3.Size = new Size(118, 27);
            label3.TabIndex = 0;
            label3.Text = "Full Name";
            label3.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(viewtext);
            Controls.Add(lname);
            Controls.Add(fname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fullname);
            Controls.Add(viewFullName);
            Name = "Form1";
            Text = "Windows";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private Label viewFullName;
        private TextBox fname;
        private TextBox lname;
        private Button button1;
        private Label label1;
        private Label fullname;
        private Label label2;
        private TextBox viewtext;
        private Label label3;
    }
}
