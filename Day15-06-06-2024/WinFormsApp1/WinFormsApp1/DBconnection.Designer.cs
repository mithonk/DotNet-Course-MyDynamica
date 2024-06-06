namespace WinFormsApp1
{
    partial class DBconnection
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
            btnTest = new Button();
            insertData = new Button();
            viewData = new Button();
            dataGridView1 = new DataGridView();
            deleteData = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.Location = new Point(12, 12);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(142, 29);
            btnTest.TabIndex = 0;
            btnTest.Text = "Test Connection";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // insertData
            // 
            insertData.Location = new Point(160, 12);
            insertData.Name = "insertData";
            insertData.Size = new Size(142, 29);
            insertData.TabIndex = 0;
            insertData.Text = "Create Data";
            insertData.UseVisualStyleBackColor = true;
            insertData.Click += insertData_Click;
            // 
            // viewData
            // 
            viewData.Location = new Point(308, 12);
            viewData.Name = "viewData";
            viewData.Size = new Size(142, 29);
            viewData.TabIndex = 0;
            viewData.Text = "View Data";
            viewData.UseVisualStyleBackColor = true;
            viewData.Click += viewData_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(797, 370);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // deleteData
            // 
            deleteData.Location = new Point(456, 12);
            deleteData.Name = "deleteData";
            deleteData.Size = new Size(142, 29);
            deleteData.TabIndex = 0;
            deleteData.Text = "Delete Data";
            deleteData.UseVisualStyleBackColor = true;
            deleteData.Click += deleteData_Click;
            // 
            // DBconnection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 442);
            Controls.Add(dataGridView1);
            Controls.Add(deleteData);
            Controls.Add(viewData);
            Controls.Add(insertData);
            Controls.Add(btnTest);
            Name = "DBconnection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DBconnection";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTest;
        private Button insertData;
        private Button viewData;
        private DataGridView dataGridView1;
        private Button deleteData;
    }
}