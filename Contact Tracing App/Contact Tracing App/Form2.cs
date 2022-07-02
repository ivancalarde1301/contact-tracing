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
using ZXing;
using ZXing.QrCode;

namespace Contact_Tracing_App
{
    public partial class Form2 : Form
    {
        public static string passLine1 = "";
        public static string passLine2;
        public static string passLine3;
        public static string passLine4;
        public static string passLine5;
        public static string passLine6;
        public static string passLine7;
        public static string passLine8;
        public static string passLine9;
        public static string passLine10;
        public static string passLine11;
        public static string passLine12;
        public static string passLine13;
        public static string passLine14;
        public Form2()
        {
            InitializeComponent();
        }

        FilterInfoCollection filter;
        VideoCaptureDevice captureDevice;
        string firstLine;
        private object reader;

        private void Form2_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filter)
                cmbBoxSelectCamera.Items.Add(filterInfo.Name);
            cmbBoxSelectCamera.SelectedIndex = 0;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filter[cmbBoxSelectCamera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            picBoxQRScanner.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picBoxQRScanner.Image != null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result = barcode.Decode((Bitmap)picBoxQRScanner.Image);
                if (result != null)
                {
                    textBox1.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                    MessageBox.Show("Scan Successful");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            processFile();
            StreamReader file = new StreamReader(@"C:\Users\ivanc\Downloads\QRCode-Personal-Information.txt");
            String line1 = file.ReadLine();
            String line2 = file.ReadLine();
            String line3 = file.ReadLine();
            String line4 = file.ReadLine();
            String line5 = file.ReadLine();
            String line6 = file.ReadLine();
            String line7 = file.ReadLine();
            String line8 = file.ReadLine();
            String line9 = file.ReadLine();
            String line10 = file.ReadLine();
            String line11 = file.ReadLine();
            String line12 = file.ReadLine();
            String line13 = file.ReadLine();
            String line14 = file.ReadLine();
            passLine1 = line1;
            passLine2 = line2;
            passLine3 = line3;
            passLine4 = line4;
            passLine5 = line5;
            passLine6 = line6;
            passLine7 = line7;
            passLine8 = line8;
            passLine9 = line9;
            passLine10 = line10;
            passLine11 = line11;
            passLine12 = line12;
            passLine13 = line13;
            passLine14 = line14;
            Close();
        }

        private void processFile()
        {
            StreamWriter file = new StreamWriter(@"C:\Users\ivanc\Downloads\QRCode-Personal-Information.txt");
            file.WriteLine(textBox1.Text);
            file.Close();
        }
    }
}
