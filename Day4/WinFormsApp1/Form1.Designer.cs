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
            fname = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            lname = new TextBox();
            label3 = new Label();
            fullNameView = new Label();
            label4 = new Label();
            fullNameViewText = new TextBox();
            SuspendLayout();
            // 
            // fname
            // 
            fname.Location = new Point(298, 48);
            fname.Name = "fname";
            fname.Size = new Size(315, 27);
            fname.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 51);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(489, 169);
            button1.Name = "button1";
            button1.Size = new Size(124, 43);
            button1.TabIndex = 2;
            button1.Text = "Click Me";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(115, 116);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // lname
            // 
            lname.Location = new Point(298, 113);
            lname.Name = "lname";
            lname.Size = new Size(315, 27);
            lname.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(115, 251);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 1;
            label3.Text = "Full Name";
            // 
            // fullNameView
            // 
            fullNameView.AutoSize = true;
            fullNameView.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullNameView.Location = new Point(298, 251);
            fullNameView.Name = "fullNameView";
            fullNameView.Size = new Size(0, 20);
            fullNameView.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(115, 315);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 1;
            label4.Text = "Full Name";
            // 
            // fullNameViewText
            // 
            fullNameViewText.Location = new Point(298, 312);
            fullNameViewText.Name = "fullNameViewText";
            fullNameViewText.Size = new Size(315, 27);
            fullNameViewText.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(768, 365);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(fullNameView);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lname);
            Controls.Add(fullNameViewText);
            Controls.Add(fname);
            Name = "Form1";
            Text = "First App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fname;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox lname;
        private Label label3;
        private Label fullNameView;
        private Label label4;
        private TextBox fullNameViewText;
    }
}
