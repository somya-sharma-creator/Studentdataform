using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passtxt.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void ClearInputFields()
        {
            usertxt.Text = ""; 
            passtxt.Text = ""; 
        }

        private bool Validated()
        {
            bool validated = true;
            if (usertxt.Text == "")
            {
                errorProvider1.SetError(usertxt, "Please fill mandatory field");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(usertxt, "");
            }

            if (passtxt.Text == "" && !checkBox1.Checked) // Only validate password if checkbox is not checked
            {
                errorProvider1.SetError(passtxt, "Please fill mandatory field");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(passtxt, "");
            }

            return validated;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = usertxt.Text;
            pass = passtxt.Text;
            if (Validated())
            {
                if (user == "abc" && pass == "123")
                {
                    MessageBox.Show("Login successful");
                    this.Hide(); 
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error");
                    ClearInputFields();

                }
            }
        }
    }
}
