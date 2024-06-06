using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;



namespace WinFormsApp1
{
    public partial class DBconnection : Form
    {
        int id;

        public DBconnection()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string connetionString = null;


            connetionString = "Server=MITHONK\\SQLEXPRESS;Database=CsarpDb;Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }

        private void insertData_Click(object sender, EventArgs e)
        {
            /*
            string connetionString = null;
            string sql = null;

            connetionString = "Server=MITHONK\\SQLEXPRESS;Database=CsarpDb;Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlCommand command;

            sql = "INSERT INTO students (first_name, last_name, gender, grade, address) VALUES ('Mithursan', 'Kalanantharasan', 'Male', '10A', 'Jaffna')";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                MessageBox.Show("Save Sucessfully");
                cnn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
            */

            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void viewData_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string sql = null;

            connetionString = "Server=MITHONK\\SQLEXPRESS;Database=CsarpDb;Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlCommand command;

            sql = "SELECT * FROM students";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                /*
                while (sqlReader.Read())
                {
                    MessageBox.Show(sqlReader.GetValue(0) + " - " + sqlReader.GetValue(1) + " - " + sqlReader.GetValue(2));
                }
                */

                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                dataGridView1.DataSource = dt;
                sqlReader.Close();
                command.Dispose();
                cnn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void deleteData_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string sql = null;

            connetionString = "Server=MITHONK\\SQLEXPRESS;Database=CsarpDb;Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlCommand command;

            try
            {

                if (id != 0)
                {
                    command = new SqlCommand("DELETE FROM students WHERE id=@id", cnn);
                    cnn.Open();
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Record Deleted Successfully!");
                   
                }
                else
                {
                    MessageBox.Show("Please Select the Record to DELETE");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}
