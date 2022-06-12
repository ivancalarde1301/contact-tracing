﻿using System;
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
            chckBoxSpecify.Enabled = false;
            txtBoxOther.Enabled = false;
            chckBoxFever.Enabled = false;
            chckBoxCough.Enabled = false;
            chckBoxTiredness.Enabled = false;
            chckBoxLoss.Enabled = false;
            chckBoxAll.Enabled = false;
            lblSpecify2.Enabled = false;
            txtBoxOther2.Enabled = false;
            lblSpecifyTravel.Enabled = false;
            txtBoxSpecifyTravel.Enabled = false;
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
            file.WriteLine("HEALTH INFORMATION");
            {
                if (chckBoxVaxYes.Checked == true)
                {
                    file.WriteLine("Vaccinated: Yes");
                }
                if (chckBoxSpecifyVax.Checked == true)
                {
                    file.WriteLine("Vaccine: Pfizer-BioNTech");
                }
                 if (chckBoxSpecifyVax2.Checked == true)
                {
                    file.WriteLine("Vaccine: Moderna");
                }
                if (chckBoxSpecifyVax3.Checked == true)
                {
                    file.WriteLine("Vaccine: AstraZeneca");
                }
                if (chckBoxSpecifyVax4.Checked == true)
                {
                    file.WriteLine("Vaccine: Sinovac");
                }
                if (chckBoxSpecify.Checked == true)
                {
                    file.WriteLine("Vaccine: " + txtBoxOther.Text);
                }
                if (chckBoxVaxNo.Checked == true)
                {
                    file.WriteLine("Vaccinated: No");
                }
                if (chckBoxSymptomsYes.Checked == true)
                {
                    file.WriteLine("Experienced any COVID-19 symptoms recently: Yes");
                }
                if (chckBoxFever.Checked == true)
                {
                    file.WriteLine("Symptoms: Fever");
                }
                if (chckBoxCough.Checked == true)
                {
                    file.WriteLine("Symptom: Cough");
                }
                if (chckBoxTiredness.Checked == true)
                {
                    file.WriteLine("Symptom: Tiredness");
                }
                if (chckBoxLoss.Checked == true)
                {
                    file.WriteLine("Symptom: Loss of Taste and/or Smell");
                }
                if (txtBoxOther2.Text != "")
                {
                    file.WriteLine("Description of Symptom/s: " + txtBoxOther2.Text);
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
                chckBoxVaxNo.Checked = false;
                chckBoxSpecifyVax.Enabled = true;
                chckBoxSpecifyVax2.Enabled = true;
                chckBoxSpecifyVax3.Enabled = true;
                chckBoxSpecifyVax4.Enabled = true;
                chckBoxSpecify.Enabled = true;
                txtBoxOther.Enabled = true;
            }
            else if (chckBoxVaxYes.Checked == false)
            {
                chckBoxVaxNo.Enabled = true;
                chckBoxSpecifyVax.Checked = false;
                chckBoxSpecifyVax2.Checked = false;
                chckBoxSpecifyVax3.Checked = false;
                chckBoxSpecifyVax4.Checked = false;
                chckBoxSpecify.Checked = false;
                txtBoxOther.Text = "";
                chckBoxSpecifyVax.Enabled = false;
                chckBoxSpecifyVax2.Enabled = false;
                chckBoxSpecifyVax3.Enabled = false;
                chckBoxSpecifyVax4.Enabled = false;
                chckBoxSpecify.Enabled = false;
                txtBoxOther.Enabled = false;
            }
        }

        private void chckBoxVaxNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxVaxNo.Checked == true)
            {
                chckBoxVaxYes.Checked = false;
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
                chckBoxSpecifyVax2.Checked = false;
                chckBoxSpecifyVax3.Checked = false;
                chckBoxSpecifyVax4.Checked = false;
                chckBoxSpecify.Checked = false;
                txtBoxOther.Text = "";
            }
        }

        private void chckBoxSpecifyVax2_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxSpecifyVax2.Checked == true)
            {
                chckBoxSpecifyVax.Checked = false;
                chckBoxSpecifyVax3.Checked = false;
                chckBoxSpecifyVax4.Checked = false;
                chckBoxSpecify.Checked = false;
                txtBoxOther.Text = "";
            }
        }

        private void chckBoxSpecifyVax3_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxSpecifyVax3.Checked == true)
            {
                chckBoxSpecifyVax.Checked = false;
                chckBoxSpecifyVax2.Checked = false;
                chckBoxSpecifyVax4.Checked = false;
                chckBoxSpecify.Checked = false;
                txtBoxOther.Text = "";
            }
        }

        private void chckBoxSpecifyVax4_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxSpecifyVax4.Checked == true)
            {
                chckBoxSpecifyVax.Checked = false;
                chckBoxSpecifyVax2.Checked = false;
                chckBoxSpecifyVax3.Checked = false;
                chckBoxSpecify.Checked = false;
                txtBoxOther.Text = "";
            }
        }

        private void chckBoxSpecify_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxSpecify.Checked == true)
            {
                chckBoxSpecifyVax.Checked = false;
                chckBoxSpecifyVax2.Checked = false;
                chckBoxSpecifyVax3.Checked = false;
                chckBoxSpecifyVax4.Checked = false;
            }
        }

        private void chckBoxSymptomsYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxSymptomsYes.Checked == true)
            {
                chckBoxSymptomsNo.Checked = false;
                chckBoxFever.Enabled = true;
                chckBoxCough.Enabled = true;
                chckBoxTiredness.Enabled = true;
                chckBoxLoss.Enabled = true;
                chckBoxAll.Enabled = true;
                lblSpecify2.Enabled = true;
                txtBoxOther2.Enabled = true;
            }
            else if (chckBoxSymptomsYes.Checked == false)
            {
                chckBoxFever.Checked = false;
                chckBoxCough.Checked = false;
                chckBoxTiredness.Checked = false;
                chckBoxLoss.Checked = false;
                chckBoxAll.Checked = false;
                lblSpecify2.Enabled = false;
                txtBoxOther2.Text = "";
                chckBoxFever.Enabled = false;
                chckBoxCough.Enabled = false;
                chckBoxTiredness.Enabled = false;
                chckBoxLoss.Enabled = false;
                lblSpecify2.Enabled = false;
                txtBoxOther2.Enabled = false;
            }
        }

        private void chckBoxSymptomsNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxSymptomsNo.Checked == true)
            {
                chckBoxSymptomsYes.Checked = false;
            }
        }

        private void chckBoxFever_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxFever.Checked == false)
            {
                chckBoxCough.Enabled = true;
                chckBoxTiredness.Enabled = true;
                chckBoxLoss.Enabled = true;
                lblSpecify2.Enabled = true;
                txtBoxOther2.Enabled = true;
                txtBoxOther2.Text = "";
            }
        }

        private void chckBoxCough_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxCough.Checked == false)
            {
                chckBoxFever.Enabled = true;
                chckBoxTiredness.Enabled = true;
                chckBoxLoss.Enabled = true;
                lblSpecify2.Enabled = true;
                txtBoxOther2.Enabled = true;
                txtBoxOther2.Text = "";
            }
        }

        private void chckBoxTiredness_CheckedChanged(object sender, EventArgs e)
        {
           if (chckBoxCough.Checked == false)
            {
                chckBoxFever.Enabled = true;
                chckBoxCough.Enabled = true;
                chckBoxLoss.Enabled = true;
                lblSpecify2.Enabled = true;
                txtBoxOther2.Enabled = true;
                txtBoxOther2.Text = "";
            }
        }

        private void chckBoxLoss_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxCough.Checked == false)
            {
                chckBoxFever.Enabled = true;
                chckBoxCough.Enabled = true;
                chckBoxTiredness.Enabled = true;
                lblSpecify2.Enabled = true;
                txtBoxOther2.Enabled = true;
                txtBoxOther2.Text = "";
            }
        }

        private void chckBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxAll.Checked == true)
            {
                chckBoxFever.Checked = true;
                chckBoxCough.Checked = true;
                chckBoxTiredness.Checked = true;
                chckBoxLoss.Checked = true;
            }
            else if(chckBoxAll.Checked == false)
            {
                chckBoxFever.Checked = false;
                chckBoxCough.Checked = false;
                chckBoxTiredness.Checked = false;
                chckBoxLoss.Checked = false;
            }
        }

        private void chckBoxTravelYes_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxTravelYes.Checked == true)
            {
                chckBoxTravelYes.Checked = true;
                chckBoxTravelNo.Checked = false;
                lblSpecifyTravel.Enabled = true;
                txtBoxSpecifyTravel.Enabled = true;
            }
            else if (chckBoxTravelYes.Checked == false)
            {
                lblSpecifyTravel.Enabled = false;
                txtBoxSpecifyTravel.Enabled = false;
                txtBoxSpecifyTravel.Text = "";
            }
        }

        private void chckBoxTravelNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxTravelNo.Checked == true)
            {
                chckBoxTravelYes.Checked = false;
            }
        }
    }
}
