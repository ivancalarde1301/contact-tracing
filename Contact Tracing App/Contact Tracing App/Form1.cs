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
using AForge.Video;
using AForge.Video.DirectShow;

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
            if (txtBoxSuffix.Text == "")
            {
                txtBoxSuffix.BackColor = Color.White;
            }
            else
            {
                txtBoxSuffix.BackColor = Color.White;
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
            if (chckBoxVaxYes.Checked == false && chckBoxVaxNo.Checked == false)
            {
                isFill = false;
                chckBoxVaxYes.ForeColor = Color.Red;
                chckBoxVaxNo.ForeColor = Color.Red;
            }
            else
            {
                chckBoxVaxYes.ForeColor = Color.Black;
                chckBoxVaxNo.ForeColor = Color.Black;
            }
            if (chckBoxVaxYes.Checked == true)
            {
                if (chckBoxSpecifyVax.Checked == false && chckBoxSpecifyVax2.Checked == false
                    && chckBoxSpecifyVax3.Checked == false && chckBoxSpecifyVax4.Checked == false
                    && chckBoxSpecify.Checked == false)
                {
                    chckBoxSpecifyVax.ForeColor = Color.Red;
                    chckBoxSpecifyVax2.ForeColor = Color.Red;
                    chckBoxSpecifyVax3.ForeColor = Color.Red;
                    chckBoxSpecifyVax4.ForeColor = Color.Red;
                    chckBoxSpecify.ForeColor = Color.Red;
                }
                else
                {
                    chckBoxSpecifyVax.ForeColor = Color.Black;
                    chckBoxSpecifyVax2.ForeColor = Color.Black;
                    chckBoxSpecifyVax3.ForeColor = Color.Black;
                    chckBoxSpecifyVax4.ForeColor = Color.Black;
                    chckBoxSpecify.ForeColor = Color.Black;
                }
            }
            if (chckBoxSymptomsYes.Checked == false && chckBoxSymptomsNo.Checked == false)
            {
                isFill = false;
                chckBoxSymptomsYes.ForeColor = Color.Red;
                chckBoxSymptomsNo.ForeColor = Color.Red;
            }
            else
            {
                chckBoxSymptomsYes.ForeColor = Color.Black;
                chckBoxSymptomsNo.ForeColor = Color.Black;
            }
            if (chckBoxSymptomsYes.Checked == true)
            {
                if (chckBoxFever.Checked == false && chckBoxCough.Checked == false
                    && chckBoxTiredness.Checked == false && chckBoxLoss.Checked == false)
                {
                    chckBoxFever.ForeColor = Color.Red;
                    chckBoxCough.ForeColor = Color.Red;
                    chckBoxTiredness.ForeColor = Color.Red;
                    chckBoxLoss.ForeColor = Color.Red;
                }
            }
            else
            {
                chckBoxFever.ForeColor = Color.Black;
                chckBoxCough.ForeColor = Color.Black;
                chckBoxTiredness.ForeColor = Color.Black;
                chckBoxLoss.ForeColor = Color.Black;
            }
            if (chckBoxTravelYes.Checked == false && chckBoxTravelNo.Checked == false)
            {
                chckBoxTravelYes.ForeColor = Color.Red;
                chckBoxTravelNo.ForeColor = Color.Red;
            }
            else
            {
                chckBoxTravelYes.ForeColor = Color.Black;
                chckBoxTravelNo.ForeColor = Color.Black;
            }
            if (chckBoxTravelYes.Checked == true && txtBoxSpecifyTravel.Text.Length == 0)
            {
                isFill = false;
                txtBoxSpecifyTravel.BackColor = Color.PaleVioletRed;
            }
            else
            {
                txtBoxSpecifyTravel.BackColor = Color.White;
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
            StreamWriter file = new StreamWriter(@"C:\Users\ivanc\Downloads\Contact-Tracing-Information.txt", true);
            file.WriteLine("Date: " + txtBoxDate.Text);
            file.WriteLine("Time: " + txtBoxTime.Text);
            file.WriteLine("");
            file.WriteLine("PERSONAL INFORMATION");
            file.WriteLine("");
            file.WriteLine("Full Name: " + txtBoxFirstName.Text + " " + txtBoxMiddleName.Text
                           + " " + txtBoxLastName.Text + " " + txtBoxSuffix.Text);
            file.WriteLine("");
            file.WriteLine("Birth Date: " + txtBoxBirthdate.Text);
            file.WriteLine("");
            file.WriteLine("Age: " + txtBoxAge.Text);
            file.WriteLine("");
            file.WriteLine("Sex: " + txtBoxSex.Text);
            file.WriteLine("");
            file.WriteLine("Phone Number: " + txtBoxPhoneNumber.Text);
            file.WriteLine("");
            file.WriteLine("Email Address: " + txtBoxEmailAddress.Text);
            file.WriteLine("");
            file.WriteLine("Full Address: " + txtBoxUBL.Text + " " + txtBoxStreet.Text
                           + " " + txtBoxBarangay.Text + " " + txtBoxCity.Text
                           + " " + txtBoxProvince.Text);
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
            file.WriteLine("-------------------------");
            file.Close();
        }

        private void resetValues()
        {
            txtBoxDate.Text = "";
            txtBoxTime.Text = "";
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

        private void btnClearEntries_Click(object sender, EventArgs e)
        {
            txtBoxDate.Text = "";
            txtBoxTime.Text = "";
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

        private void btnAllRecords_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\ivanc\Downloads\Contact-Tracing-Information.txt");
            String all = reader.ReadToEnd();
            MessageBox.Show(all);
        }

        private void btnReviewSubmission_Click(object sender, EventArgs e)
        {
            string date = txtBoxEnterDate.Text;
            string textFile = @"C:\Users\ivanc\Downloads\Contact-Tracing-Information.txt";
            string text = File.ReadAllText(textFile);

            string[] recSeparator = { "-------------------------" };
            string[] records = text.Split(recSeparator, StringSplitOptions.RemoveEmptyEntries);
            if (txtBoxEnterDate.Text == "")
            {
                txtBoxEnterDate.BackColor = Color.PaleVioletRed;
                MessageBox.Show("Please Enter a Valid Date");
            }
            else
            {
                txtBoxEnterDate.BackColor = Color.White;
                foreach (string record in records)
                {
                    if (record.Contains(date))
                    {
                        MessageBox.Show(record);
                        txtBoxEnterDate.Text = "";
                    }
                }
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.FormClosed += F2_FormClosed;
            f2.Show();
        }

        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtBoxFirstName.Text = Form2.passLine1;
            txtBoxMiddleName.Text = Form2.passLine2;
            txtBoxLastName.Text = Form2.passLine3;
            txtBoxSuffix.Text = Form2.passLine4;
            txtBoxBirthdate.Text = Form2.passLine5;
            txtBoxAge.Text = Form2.passLine6;
            txtBoxSex.Text = Form2.passLine7;
            txtBoxPhoneNumber.Text = Form2.passLine8;
            txtBoxUBL.Text = Form2.passLine9;
            txtBoxStreet.Text = Form2.passLine10;
            txtBoxBarangay.Text = Form2.passLine11;
            txtBoxCity.Text = Form2.passLine12;
            txtBoxProvince.Text = Form2.passLine13;
            txtBoxEmailAddress.Text = Form2.passLine14;
            txtBoxFirstName.BackColor = Color.LightYellow;
            txtBoxMiddleName.BackColor = Color.LightYellow;
            txtBoxLastName.BackColor = Color.LightYellow;
            txtBoxBirthdate.BackColor = Color.LightYellow;
            txtBoxAge.BackColor = Color.LightYellow;
            txtBoxSex.BackColor = Color.LightYellow;
            txtBoxPhoneNumber.BackColor = Color.LightYellow;
            txtBoxUBL.BackColor = Color.LightYellow;
            txtBoxStreet.BackColor = Color.LightYellow;
            txtBoxBarangay.BackColor = Color.LightYellow;
            txtBoxCity.BackColor = Color.LightYellow;
            txtBoxProvince.BackColor = Color.LightYellow;
            txtBoxEmailAddress.BackColor = Color.LightYellow;
            if (txtBoxSuffix.Text.Length == 0)
            {
                txtBoxSuffix.BackColor = Color.White;
            }
            else
            {
                txtBoxSuffix.BackColor = Color.LightYellow;
            }
        }


    }
}
