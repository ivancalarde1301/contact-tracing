using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtBoxSex.MaxLength = 6;
            txtBoxPhoneNumber.MaxLength = 11;
            txtBoxZipCode.MaxLength = 4;
            chckBoxSpecifyVax.Enabled = false;
            chckBoxSpecifyVax2.Enabled = false;
            chckBoxSpecifyVax3.Enabled = false;
            chckBoxSpecifyVax4.Enabled = false;
            chckBoxOther.Enabled = false;
            lblSpecify.Enabled = false;
            txtBoxOther.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\ivanc\Downloads\test.txt");
            file.WriteLine("PERSONAL INFORMATION");
            file.WriteLine("FULL NAME");
            file.WriteLine("First Name: " + txtBoxFirstName.Text);
            file.WriteLine("Middle Name: " + txtBoxMiddleName.Text);
            file.WriteLine("Last Name: " + txtBoxLastName.Text);
            {
                if (txtBoxSuffix.Text != "")
                {
                    file.WriteLine("Suffix: " + txtBoxSuffix.Text);
                }
                else if (txtBoxSuffix.Text != null)
                {
                    file.WriteLine("Suffix: N/A");
                }
            }
            file.WriteLine("Birth Date: " + mskdTxtBoxBirthDate.Text);
            file.WriteLine("Age: " + txtBoxAge.Text);
            file.WriteLine("Sex: " + txtBoxSex.Text);
            file.WriteLine("Phone Number: " + txtBoxPhoneNumber.Text);
            file.WriteLine("FULL ADDRESS");
            file.WriteLine("Unit / Block / Lot: " + txtBoxUBL.Text);
            file.WriteLine("Street: " + txtBoxStreet.Text);
            file.WriteLine("Village / Subdivision: " + txtBoxVillageSubdivision.Text);
            file.WriteLine("City: " + txtBoxCity.Text);
            file.WriteLine("Zip Code: " + txtBoxZipCode.Text);
            {
                if (chckBoxVaxYes.Checked == true)
                {
                    file.WriteLine("Vaccinated: Yes");
                }
                if (chckBoxVaxNo.Checked == true)
                {
                    file.WriteLine("Vaccinated: No");
                }
            }
            file.Close();
        }

        private void txtBoxAge_TextChanged(object sender, EventArgs e)
        {
            int box_int = 0;
            Int32.TryParse(txtBoxAge.Text, out box_int);
            if (box_int < 1 && txtBoxAge.Text != "")
            {
                txtBoxAge.Text = "0";
                MessageBox.Show("Please enter a different age.");
            }
            else if (box_int > 122 && txtBoxAge.Text != "")
            {
                txtBoxAge.Text = "0";
                MessageBox.Show("Please enter a different age.");
            }
        }

        private void chckBoxVaxYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxVaxYes.Checked == true)
            {
                chckBoxVaxNo.Enabled = false;
                chckBoxSpecifyVax.Enabled = true;
                chckBoxSpecifyVax2.Enabled = true;
                chckBoxSpecifyVax3.Enabled = true;
                chckBoxSpecifyVax4.Enabled = true;
                chckBoxOther.Enabled = true;
                lblSpecify.Enabled = true;
                txtBoxOther.Enabled = true;
            }
            else if (chckBoxVaxYes.Checked == false)
            {
                chckBoxVaxNo.Enabled = true;
                chckBoxSpecifyVax.Enabled = false;
                chckBoxSpecifyVax2.Enabled = false;
                chckBoxSpecifyVax3.Enabled = false;
                chckBoxSpecifyVax4.Enabled = false;
                chckBoxOther.Enabled = false;
                lblSpecify.Enabled = false;
                txtBoxOther.Enabled = false;
            }
        }

        private void chckBoxVaxNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxVaxNo.Checked == true)
            {
                chckBoxVaxYes.Enabled = false;
                chckBoxSpecifyVax.Enabled = false;
                chckBoxSpecifyVax2.Enabled = false;
                chckBoxSpecifyVax3.Enabled = false;
                chckBoxSpecifyVax4.Enabled = false;
                chckBoxOther.Enabled = false;
                lblSpecify.Enabled = false;
                txtBoxOther.Enabled = false;
            }
            else if (chckBoxVaxNo.Checked == false)
            {
                chckBoxVaxYes.Enabled = true;
            }
        }

        private void chckBoxSpecifyVax_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxSpecifyVax.Checked == true)
            {
                chckBoxSpecifyVax2.Enabled = false;
                chckBoxSpecifyVax3.Enabled = false;
                chckBoxSpecifyVax4.Enabled = false;
                chckBoxOther.Enabled = false;
                lblSpecify.Enabled = false;
                txtBoxOther.Enabled = false;
            }
            else if (chckBoxSpecifyVax.Checked == false)
            {
                chckBoxSpecifyVax2.Enabled = true;
                chckBoxSpecifyVax3.Enabled = true;
                chckBoxSpecifyVax4.Enabled = true;
                chckBoxOther.Enabled = true;
                lblSpecify.Enabled = true;
                txtBoxOther.Enabled = true;
            }
        }

        private void chckBoxSpecifyVax2_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxSpecifyVax2.Checked == true)
            {
                chckBoxSpecifyVax.Enabled = false;
                chckBoxSpecifyVax3.Enabled = false;
                chckBoxSpecifyVax4.Enabled = false;
                chckBoxOther.Enabled = false;
                lblSpecify.Enabled = false;
                txtBoxOther.Enabled = false;
            }
            else if (chckBoxSpecifyVax2.Checked == false)
            {
                chckBoxSpecifyVax.Enabled = true;
                chckBoxSpecifyVax3.Enabled = true;
                chckBoxSpecifyVax4.Enabled = true;
                chckBoxOther.Enabled = true;
                lblSpecify.Enabled = true;
                txtBoxOther.Enabled = true;
            }
        }

        private void chckBoxSpecifyVax3_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxSpecifyVax3.Checked == true)
            {
                chckBoxSpecifyVax.Enabled = false;
                chckBoxSpecifyVax2.Enabled = false;
                chckBoxSpecifyVax4.Enabled = false;
                chckBoxOther.Enabled = false;
                lblSpecify.Enabled = false;
                txtBoxOther.Enabled = false;
            }
            else if (chckBoxSpecifyVax3.Checked == false)
            {
                chckBoxSpecifyVax.Enabled = true;
                chckBoxSpecifyVax2.Enabled = true;
                chckBoxSpecifyVax4.Enabled = true;
                chckBoxOther.Enabled = true;
                lblSpecify.Enabled = true;
                txtBoxOther.Enabled = true;
            }
        }

        private void chckBoxSpecifyVax4_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxSpecifyVax4.Checked == true)
            {
                chckBoxSpecifyVax.Enabled = false;
                chckBoxSpecifyVax2.Enabled = false;
                chckBoxSpecifyVax3.Enabled = false;
                chckBoxOther.Enabled = false;
                lblSpecify.Enabled = false;
                txtBoxOther.Enabled = false;
            }
            else if (chckBoxSpecifyVax4.Checked == false)
            {
                chckBoxSpecifyVax.Enabled = true;
                chckBoxSpecifyVax2.Enabled = true;
                chckBoxSpecifyVax3.Enabled = true;
                chckBoxOther.Enabled = true;
                lblSpecify.Enabled = true;
                txtBoxOther.Enabled = true;
            }
        }

        private void chckBoxOther_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxOther.Checked == true)
            {
                chckBoxSpecifyVax.Enabled = false;
                chckBoxSpecifyVax2.Enabled = false;
                chckBoxSpecifyVax3.Enabled = false;
                chckBoxSpecifyVax4.Enabled = false;
            }
            else if (chckBoxOther.Checked == false)
            {
                chckBoxSpecifyVax.Enabled = true;
                chckBoxSpecifyVax2.Enabled = true;
                chckBoxSpecifyVax3.Enabled = true;
                chckBoxSpecifyVax4.Enabled = true;
            }
        }
    }
}
