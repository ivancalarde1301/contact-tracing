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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\ivanc\Downloads\test.txt");
            file.WriteLine("FULL NAME");
            file.WriteLine("First Name: " + txtBoxFirstName.Text);
            file.WriteLine("Middle Name: " + txtBoxMiddleName.Text);
            file.WriteLine("Last Name: " + txtBoxLastName.Text);
            file.WriteLine("Suffix: " + txtBoxSuffix.Text);
            file.WriteLine("Birth Date: " + txtBoxBirthDate.Text);
            file.WriteLine("Age: " + txtBoxAge.Text);
            file.WriteLine("Sex: " + txtBoxUBL.Text);
            file.WriteLine("Phone Number: " + txtBoxPhoneNumber.Text);
            file.WriteLine("FULL ADDRESS");
            file.WriteLine("Unit / Block / Lot: " + txtBoxSex.Text);
            file.WriteLine("Street: " + txtBoxStreet.Text);
            file.WriteLine("Village / Subdivision: " + txtBoxVillageSubdivision.Text);
            file.WriteLine("City: " + txtBoxCity.Text);
            file.WriteLine("Country: " + txtBoxCountry.Text);
            file.Close();
        }
    }
}
