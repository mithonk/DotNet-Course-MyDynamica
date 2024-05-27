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
            btn = new Button();
            label1 = new Label();
            fname = new TextBox();
            SuspendLayout();
            // 
            // btn
            // 
            btn.BackColor = Color.Fuchsia;
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn.ForeColor = Color.FromArgb(64, 0, 64);
            btn.Location = new Point(238, 79);
            btn.Name = "btn";
            btn.Size = new Size(94, 50);
            btn.TabIndex = 0;
            btn.Text = "Open";
            btn.UseVisualStyleBackColor = false;
            btn.Click += btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // fname
            // 
            fname.Location = new Point(147, 46);
            fname.Name = "fname";
            fname.Size = new Size(185, 27);
            fname.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 159);
            Controls.Add(fname);
            Controls.Add(label1);
            Controls.Add(btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn;
        private Label label1;
        private TextBox fname;
    }
}
