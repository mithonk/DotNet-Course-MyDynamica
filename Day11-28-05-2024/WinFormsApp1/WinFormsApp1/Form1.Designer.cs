namespace WinFormsApp1
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
            form1Fname = new TextBox();
            viewForm2 = new Button();
            label2 = new Label();
            lname = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // form1Fname
            // 
            form1Fname.Location = new Point(115, 12);
            form1Fname.Name = "form1Fname";
            form1Fname.Size = new Size(276, 27);
            form1Fname.TabIndex = 0;
            // 
            // viewForm2
            // 
            viewForm2.Location = new Point(278, 104);
            viewForm2.Name = "viewForm2";
            viewForm2.Size = new Size(113, 29);
            viewForm2.TabIndex = 3;
            viewForm2.Text = "View Form2";
            viewForm2.UseVisualStyleBackColor = true;
            viewForm2.Click += viewForm2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 0;
            label2.Text = "Last Name";
            // 
            // lname
            // 
            lname.Location = new Point(115, 59);
            lname.Name = "lname";
            lname.Size = new Size(276, 27);
            lname.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 154);
            Controls.Add(viewForm2);
            Controls.Add(lname);
            Controls.Add(form1Fname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button viewForm2;
        private Label label2;
        private TextBox lname;
        public TextBox form1Fname;
    }
}
