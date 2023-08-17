using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data source=DESKTOP-ARDALUS\\MSSQLSERVER01;Initial Catalog=studentdb; Integrated Security=true;";
                conn.Open();
                string query = "Getstudentinfo";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = command.ExecuteReader();//execute the query and returns the value
                DataTable table = new DataTable();//creating a datatable in dgv
                table.Load(reader);// it will load the value of reader into the data table
                dataGridView1.DataSource = table;//now table will work as the source for the dgv
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToAddRows = false; // Remove the extra row for adding new rows
                dataGridView1.RowHeadersVisible = false;// to strech the column size according to the window size
                //dataGridView1.Columns["password"].Visible = false;// to hide passwrd
                conn.Close();
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
