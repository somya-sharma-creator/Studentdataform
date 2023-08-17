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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void fnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rolltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fattxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mottxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void classtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void phonetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                string inputText = (sender as System.Windows.Forms.TextBox).Text + e.KeyChar.ToString();
                if (inputText.Count(Char.IsDigit) > 10)
                {
                    e.Handled = true;
                }
            }
        }
        private void sectxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsLetter(e.KeyChar) || sectxt.Text.Length >= 1)
            {
                e.Handled = true;
            }
        }

        private void addtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }




        private bool Validated()
        {
            bool validated = true;
            if (rolltxt.Text == "")
            {
                errorProvider1.SetError(rolltxt, "Please fill mandatory field");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(rolltxt, "");
            }

            if (fnametxt.Text == "")
            {
                errorProvider1.SetError(fnametxt, "Please fill mandatory field");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(rolltxt, "");
            }
            if (lnametxt.Text == "")
            {
                errorProvider1.SetError(lnametxt, "Please fill mandatory field");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(lnametxt, "");
            }

            if (fattxt.Text == "")
            {
                errorProvider1.SetError(fattxt, "Please fill mandatory field");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(fattxt, "");
            }



            if (mottxt.Text == "")
            {
                errorProvider1.SetError(mottxt, "Please fill mandatory field");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(mottxt, "");
            }



            if (classtxt.Text == "")
            {
                errorProvider1.SetError(classtxt, "Please fill mandatory field");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(classtxt, "");
            }



            if (sectxt.Text == "")
            {
                errorProvider1.SetError(sectxt, "Please fill mandatory field");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(sectxt, "");
            }





            if (phonetxt.Text == "")
            {
                errorProvider1.SetError(phonetxt, "Please fill mandatory field");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(phonetxt, "");
            }

            if (phonetxt.Text.Length < 10)
            {
                errorProvider1.SetError(phonetxt, "Please enter valid number");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(phonetxt, "");
            }

            if (addtxt.Text == "")
            {
                errorProvider1.SetError(addtxt, "Please fill mandatory field");
                validated = false;
            }
            else
            {
                errorProvider1.SetError(addtxt, "");
            }

            return validated;
        }

        private void browsetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void image_Click(object sender, EventArgs e)
        {

        }






        //private void savebtn_Click_1(object sender, EventArgs e)
        //{
        //    string roll_no, fname, lname, father_name, mother_name, class, section, phone, address;

        //    roll_no = rolltxt.Text;
        //    fname = fnametxt.Text;
        //    lname = lnametxt.Text;
        //    fatname = fattxt.Text;
        //    motname = mottxt.Text;
        //    class = classtxt.Text;


        //    phone = phonetxt.text;

        //    if (validated())
        //    {
        //     using (sqlconnection conn = new sqlconnection())
        //        {
        //            conn.connectionstring = "data source=desktop-ardalus\\mssqlserver01;initial catalog=studentdb; integrated security=true;";
        //            conn.open();
        //            sqlcommand command = new sqlcommand("insertdemoinfo", conn);
        //                    {
        //                      command.parameters.addwithvalue("@roll_no",roll_no);
        //                        command.parameters.addwithvalue("@fname", fname);
        //                        command.parameters.addwithvalue("@lname", lname);
        //                         command.parameters.addwithvalue("@fatname", fatname);
        //                          command.parameters.addwithvalue("@motname", motname);
        //                           command.parameters.addwithvalue("@class", class);
        //                              command.parameters.addwithvalue("@sec", sec);
        //                        command.parameters.addwithvalue("@phone", phone);
        //                      command.parameters.addwithvalue("@add", add);
        //                    }
        //                       command.commandtype = commandtype.storedprocedure;

        //                    command.executenonquery();
        //                    conn.close();

        //                 messagebox.show("information saved.");
        //
        //
        //
        // }
    }
}
    
            




