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

            txtBoxAge.MaxLength = 3;
            txtBoxPhoneNumber.MaxLength = 11;
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
            lblSpecify2.Enabled = false;
            txtBoxOther2.Enabled = false;
            lblSpecifyTravel.Enabled = false;
            txtBoxSpecifyTravel.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean isFill = true;
            if (txtBoxDate.Text == "")
            {
                isFill = false;
                txtBoxDate.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBoxDate.BackColor = Color.White;
            }
            if (txtBoxTime.Text == "")
            {
                isFill = false;
                txtBoxTime.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBoxTime.BackColor = Color.White;
            }
            if (txtBoxFirstName.Text == "")
            {
                isFill = false;
                txtBoxFirstName.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBoxFirstName.BackColor = Color.White;
            }
            if (txtBoxMiddleName.Text == "")
            {
                isFill = false;
                txtBoxMiddleName.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBoxMiddleName.BackColor = Color.White;
            }
            if (txtBoxLastName.Text == "")
            {
                isFill = false;
                txtBoxLastName.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBoxLastName.BackColor = Color.White;
            }
            if (txtBoxBirthdate.Text == "")
            {
                isFill = false;
                txtBoxBirthdate.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBoxBirthdate.BackColor = Color.White;
            }
            if (txtBoxAge.Text == "")
            {
                isFill = false;
                txtBoxAge.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBoxAge.BackColor = Color.White;
            }
            if (txtBoxSex.Text == "")
            {
                isFill = false;
                txtBoxSex.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBoxSex.BackColor = Color.White;
            }
            if (txtBoxAge.Text == "")
            {
                isFill = false;
                txtBoxAge.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBoxAge.BackColor = Color.White;
            }
            if (txtBoxPhoneNumber.Text == "")
            {
                isFill = false;
                txtBoxPhoneNumber.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBoxPhoneNumber.BackColor = Color.White;
            }
            if (txtBoxUBL.Text == "")
            {
                isFill = false;
                txtBoxUBL.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBoxUBL.BackColor = Color.White;
            }
            if (txtBoxStreet.Text == "")
            {
                isFill = false;
                txtBoxStreet.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBoxStreet.BackColor = Color.White;
            }
            if (txtBoxBarangay.Text == "")
            {
                isFill = false;
                txtBoxBarangay.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBoxBarangay.BackColor = Color.White;
            }
            if (txtBoxCity.Text == "")
            {
                isFill = false;
                txtBoxCity.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBoxCity.BackColor = Color.White;
            }
            if (txtBoxProvince.Text == "")
            {
                isFill = false;
                txtBoxProvince.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBoxProvince.BackColor = Color.White;
            }
            if (txtBoxEmailAddress.Text == "")
            {
                isFill = false;
                txtBoxEmailAddress.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBoxEmailAddress.BackColor = Color.White;
            }
            if (!isFill)
            {
                MessageBox.Show("Please fill in the blank spaces.");
            }
            else
            {
                processFile();
                MessageBox.Show("Information submitted. Thank you!");
                resetValues();
            }
        }

        private void processFile()
        {
            StreamWriter file = new StreamWriter(@"C:\Users\ivanc\Downloads\Contact-Tracing-Information.txt");
            file.WriteLine("");
            file.WriteLine("Date: " + txtBoxDate.Text);
            file.WriteLine("Time: " + txtBoxTime.Text);
            file.WriteLine("");
            file.WriteLine("PERSONAL INFORMATION");
            file.WriteLine("");
            file.WriteLine("Full Name: " + txtBoxFirstName.Text + " " + txtBoxMiddleName.Text
                           + " " + txtBoxLastName.Text + " " + txtBoxSuffix.Text);
            file.WriteLine("");
            file.WriteLine("Birth Date: " + txtBoxEmailAddress.Text);
            file.WriteLine("");
            file.WriteLine("Age: " + txtBoxBirthdate.Text);
            file.WriteLine("");
            file.WriteLine("Sex: " + txtBoxAge.Text);
            file.WriteLine("");
            file.WriteLine("Phone Number: " + txtBoxSex.Text);
            file.WriteLine("");
            file.WriteLine("Email Address: " + txtBoxProvince.Text);
            file.WriteLine("");
            file.WriteLine("Full Address: " + txtBoxPhoneNumber.Text + " " + txtBoxUBL.Text
                           + " " + txtBoxStreet.Text + " " + txtBoxBarangay.Text
                           + " " + txtBoxCity.Text);
            file.WriteLine("");
            file.WriteLine("HEALTH INFORMATION");
            file.WriteLine("");
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
                file.WriteLine("");
                if (chckBoxSymptomsYes.Checked == true)
                {
                    file.WriteLine("Experienced any COVID-19 symptoms recently: Yes");
                }
                if (chckBoxSymptomsNo.Checked == true)
                {
                    file.WriteLine("Experienced any COVID-19 symptoms recently: No");
                }
                if (chckBoxFever.Checked == true)
                {
                    file.WriteLine("Symptom #1: Fever");
                }
                if (chckBoxCough.Checked == true)
                {
                    file.WriteLine("Symptom #2: Cough");
                }
                if (chckBoxTiredness.Checked == true)
                {
                    file.WriteLine("Symptom #3: Tiredness");
                }
                if (chckBoxLoss.Checked == true)
                {
                    file.WriteLine("Symptom #4: Loss of Taste and/or Smell");
                }
                if (txtBoxOther2.Text != "")
                {
                    file.WriteLine("Description of Symptom/s: " + txtBoxOther2.Text);
                }
                file.WriteLine("");
                if (chckBoxTravelYes.Checked == true)
                {
                    file.WriteLine("Traveled Outside the Country in the Last 14 Days: Yes");
                }
                if (txtBoxSpecifyTravel.Text != "")
                {
                    file.WriteLine("Traveled from: " + txtBoxSpecifyTravel.Text);
                }
                if (chckBoxTravelNo.Checked == true)
                {
                    file.WriteLine("Traveled Outside the Country in the Last 14 Days: No");
                }
            }
            file.WriteLine("");
            file.Close();
        }

        private void resetValues()
        {
            txtBoxFirstName.Text = "";
            txtBoxMiddleName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxSuffix.Text = "";
            txtBoxEmailAddress.Text = "";
            txtBoxBirthdate.Text = "";
            txtBoxAge.Text = "";
            txtBoxSex.Text = "";
            txtBoxPhoneNumber.Text = "";
            txtBoxUBL.Text = "";
            txtBoxStreet.Text = "";
            txtBoxBarangay.Text = "";
            txtBoxCity.Text = "";
            txtBoxProvince.Text = "";
            chckBoxVaxYes.Checked = false;
            chckBoxVaxNo.Checked = false;
            chckBoxSpecifyVax.Checked = false;
            chckBoxSpecifyVax2.Checked = false;
            chckBoxSpecifyVax3.Checked = false;
            chckBoxSpecifyVax4.Checked = false;
            chckBoxSpecify.Checked = false;
            txtBoxOther.Text = "";
            chckBoxSymptomsYes.Checked = false;
            chckBoxSymptomsNo.Checked = false;
            chckBoxFever.Checked = false;
            chckBoxCough.Checked = false;
            chckBoxTiredness.Checked = false;
            chckBoxLoss.Checked = false;
            txtBoxOther2.Text = "";
            chckBoxTravelYes.Checked = false;
            chckBoxTravelNo.Checked = false;
            txtBoxSpecifyTravel.Text = "";
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
            lblSpecify2.Enabled = false;
            txtBoxOther2.Enabled = false;
            lblSpecifyTravel.Enabled = false;
            txtBoxSpecifyTravel.Enabled = false;
        }

        private void txtBoxAge_TextChanged(object sender, EventArgs e)
        {
            int boxInt = 0;
            Int32.TryParse(txtBoxAge.Text, out boxInt);
            if (boxInt < 1 && txtBoxAge.Text != "")
            {
                txtBoxAge.Text = "0";
                MessageBox.Show("Please enter a different age.");
            }
            else if (boxInt > 122 && txtBoxAge.Text != "")
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
                txtBoxOther.Enabled = true;
            }
            else if (chckBoxSpecify.Checked == false)
            {
                txtBoxOther.Enabled = false;
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
                lblSpecify2.Enabled = true;
                txtBoxOther2.Enabled = true;
            }
            else if (chckBoxSymptomsYes.Checked == false)
            {
                chckBoxFever.Checked = false;
                chckBoxCough.Checked = false;
                chckBoxTiredness.Checked = false;
                chckBoxLoss.Checked = false;
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
