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
            StreamWriter file = new StreamWriter(@"C:\Users\ivanc\Downloads\test.txt", true);
            file.WriteLine("First Name: " + txtboxFirstName.Text);
            file.WriteLine("Middle Name: " + txtboxMiddleName.Text);
            file.WriteLine("Last Name: " + txtboxLastName.Text);
            file.Close();
        }
    }
}
