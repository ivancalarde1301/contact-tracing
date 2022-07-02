namespace Contact_Tracing_App
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBoxQRScanner = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbBoxSelectCamera = new System.Windows.Forms.ComboBox();
            this.lblCamera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQRScanner)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxQRScanner
            // 
            this.picBoxQRScanner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxQRScanner.Location = new System.Drawing.Point(12, 51);
            this.picBoxQRScanner.Name = "picBoxQRScanner";
            this.picBoxQRScanner.Size = new System.Drawing.Size(313, 264);
            this.picBoxQRScanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxQRScanner.TabIndex = 0;
            this.picBoxQRScanner.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Center your QR Code on the Camera.";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(111, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 25);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbBoxSelectCamera
            // 
            this.cmbBoxSelectCamera.FormattingEnabled = true;
            this.cmbBoxSelectCamera.Location = new System.Drawing.Point(76, 12);
            this.cmbBoxSelectCamera.Name = "cmbBoxSelectCamera";
            this.cmbBoxSelectCamera.Size = new System.Drawing.Size(249, 24);
            this.cmbBoxSelectCamera.TabIndex = 3;
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Location = new System.Drawing.Point(12, 15);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(58, 16);
            this.lblCamera.TabIndex = 4;
            this.lblCamera.Text = "Camera:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(337, 390);
            this.Controls.Add(this.lblCamera);
            this.Controls.Add(this.cmbBoxSelectCamera);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxQRScanner);
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scan QR Code";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQRScanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxQRScanner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbBoxSelectCamera;
        private System.Windows.Forms.Label lblCamera;
    }
}