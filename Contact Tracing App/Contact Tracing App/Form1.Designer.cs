using System;

namespace Contact_Tracing_App
{
    partial class Form1
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.picboxDesign = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblHeader2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxInfo1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxMiddleName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxSuffix = new System.Windows.Forms.TextBox();
            this.lvlBirthDate = new System.Windows.Forms.Label();
            this.txtBoxBirthDate = new System.Windows.Forms.TextBox();
            this.lblmmddyyy = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.lblFullAddress = new System.Windows.Forms.Label();
            this.txtBoxSex = new System.Windows.Forms.TextBox();
            this.lblUBL = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblVillageSubdivision = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxUBL = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtBoxStreet = new System.Windows.Forms.TextBox();
            this.txtBoxVillageSubdivision = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxProvince = new System.Windows.Forms.TextBox();
            this.txtBoxZipCode = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.mskdTxtBoxBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDesign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(388, 523);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(165, 32);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // picboxDesign
            // 
            this.picboxDesign.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picboxDesign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxDesign.Location = new System.Drawing.Point(-5, -1);
            this.picboxDesign.Name = "picboxDesign";
            this.picboxDesign.Size = new System.Drawing.Size(911, 63);
            this.picboxDesign.TabIndex = 7;
            this.picboxDesign.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHeader.Font = new System.Drawing.Font("Bebas Neue", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(12, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(877, 39);
            this.lblHeader.TabIndex = 8;
            this.lblHeader.Text = "Online Contact Tracing Form";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeader2
            // 
            this.lblHeader2.Font = new System.Drawing.Font("Bebas Neue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader2.Location = new System.Drawing.Point(12, 65);
            this.lblHeader2.Name = "lblHeader2";
            this.lblHeader2.Size = new System.Drawing.Size(877, 26);
            this.lblHeader2.TabIndex = 9;
            this.lblHeader2.Text = "Personal Information";
            this.lblHeader2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(877, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Please enter your personal information.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxInfo1
            // 
            this.picBoxInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxInfo1.Location = new System.Drawing.Point(-5, 114);
            this.picBoxInfo1.Name = "picBoxInfo1";
            this.picBoxInfo1.Size = new System.Drawing.Size(911, 462);
            this.picBoxInfo1.TabIndex = 11;
            this.picBoxInfo1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(13, 131);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 24);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(14, 155);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 16);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "(First Name)";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(16, 174);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(113, 22);
            this.txtBoxFirstName.TabIndex = 14;
            // 
            // txtBoxMiddleName
            // 
            this.txtBoxMiddleName.Location = new System.Drawing.Point(135, 174);
            this.txtBoxMiddleName.Name = "txtBoxMiddleName";
            this.txtBoxMiddleName.Size = new System.Drawing.Size(113, 22);
            this.txtBoxMiddleName.TabIndex = 15;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(254, 174);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(113, 22);
            this.txtBoxLastName.TabIndex = 16;
            // 
            // txtBoxSuffix
            // 
            this.txtBoxSuffix.Location = new System.Drawing.Point(373, 174);
            this.txtBoxSuffix.Name = "txtBoxSuffix";
            this.txtBoxSuffix.Size = new System.Drawing.Size(46, 22);
            this.txtBoxSuffix.TabIndex = 17;
            // 
            // lvlBirthDate
            // 
            this.lvlBirthDate.AutoSize = true;
            this.lvlBirthDate.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlBirthDate.Location = new System.Drawing.Point(421, 131);
            this.lvlBirthDate.Name = "lvlBirthDate";
            this.lvlBirthDate.Size = new System.Drawing.Size(77, 24);
            this.lvlBirthDate.TabIndex = 18;
            this.lvlBirthDate.Text = "Birth Date";
            // 
            // txtBoxBirthDate
            // 
            this.txtBoxBirthDate.Location = new System.Drawing.Point(474, 403);
            this.txtBoxBirthDate.Name = "txtBoxBirthDate";
            this.txtBoxBirthDate.Size = new System.Drawing.Size(153, 22);
            this.txtBoxBirthDate.TabIndex = 19;
            // 
            // lblmmddyyy
            // 
            this.lblmmddyyy.AutoSize = true;
            this.lblmmddyyy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmmddyyy.Location = new System.Drawing.Point(422, 155);
            this.lblmmddyyy.Name = "lblmmddyyy";
            this.lblmmddyyy.Size = new System.Drawing.Size(89, 16);
            this.lblmmddyyy.TabIndex = 20;
            this.lblmmddyyy.Text = "(mm-dd-yyyy)";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(569, 147);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 24);
            this.lblAge.TabIndex = 21;
            this.lblAge.Text = "Age";
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(573, 174);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(54, 22);
            this.txtBoxAge.TabIndex = 22;
            this.txtBoxAge.TextChanged += new System.EventHandler(this.txtBoxAge_TextChanged);
            // 
            // lblFullAddress
            // 
            this.lblFullAddress.AutoSize = true;
            this.lblFullAddress.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullAddress.Location = new System.Drawing.Point(13, 212);
            this.lblFullAddress.Name = "lblFullAddress";
            this.lblFullAddress.Size = new System.Drawing.Size(95, 24);
            this.lblFullAddress.TabIndex = 23;
            this.lblFullAddress.Text = "Full Address";
            // 
            // txtBoxSex
            // 
            this.txtBoxSex.Location = new System.Drawing.Point(633, 174);
            this.txtBoxSex.Name = "txtBoxSex";
            this.txtBoxSex.Size = new System.Drawing.Size(93, 22);
            this.txtBoxSex.TabIndex = 24;
            // 
            // lblUBL
            // 
            this.lblUBL.AutoSize = true;
            this.lblUBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUBL.Location = new System.Drawing.Point(12, 236);
            this.lblUBL.Name = "lblUBL";
            this.lblUBL.Size = new System.Drawing.Size(102, 16);
            this.lblUBL.TabIndex = 25;
            this.lblUBL.Text = "Unit / Block / Lot";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(147, 236);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(42, 16);
            this.lblStreet.TabIndex = 26;
            this.lblStreet.Text = "Street";
            // 
            // lblVillageSubdivision
            // 
            this.lblVillageSubdivision.AutoSize = true;
            this.lblVillageSubdivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVillageSubdivision.Location = new System.Drawing.Point(284, 236);
            this.lblVillageSubdivision.Name = "lblVillageSubdivision";
            this.lblVillageSubdivision.Size = new System.Drawing.Size(129, 16);
            this.lblVillageSubdivision.TabIndex = 29;
            this.lblVillageSubdivision.Text = "Village / Subdivision";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(451, 236);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 16);
            this.lblCity.TabIndex = 31;
            this.lblCity.Text = "City";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(588, 236);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(60, 16);
            this.lblProvince.TabIndex = 33;
            this.lblProvince.Text = "Province";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(728, 147);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(104, 24);
            this.lblPhoneNumber.TabIndex = 35;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(132, 155);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(96, 16);
            this.lblMiddleName.TabIndex = 36;
            this.lblMiddleName.Text = "(Middle Name)";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(252, 155);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 16);
            this.lblLastName.TabIndex = 37;
            this.lblLastName.Text = "(Last Name)";
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuffix.Location = new System.Drawing.Point(370, 155);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(46, 16);
            this.lblSuffix.TabIndex = 38;
            this.lblSuffix.Text = "(Suffix)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 297);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(911, 279);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(877, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "Personal Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxUBL
            // 
            this.txtBoxUBL.Location = new System.Drawing.Point(15, 255);
            this.txtBoxUBL.Name = "txtBoxUBL";
            this.txtBoxUBL.Size = new System.Drawing.Size(129, 22);
            this.txtBoxUBL.TabIndex = 41;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(629, 147);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(32, 24);
            this.lblSex.TabIndex = 42;
            this.lblSex.Text = "Sex";
            // 
            // txtBoxStreet
            // 
            this.txtBoxStreet.Location = new System.Drawing.Point(150, 255);
            this.txtBoxStreet.Name = "txtBoxStreet";
            this.txtBoxStreet.Size = new System.Drawing.Size(131, 22);
            this.txtBoxStreet.TabIndex = 43;
            // 
            // txtBoxVillageSubdivision
            // 
            this.txtBoxVillageSubdivision.Location = new System.Drawing.Point(287, 255);
            this.txtBoxVillageSubdivision.Name = "txtBoxVillageSubdivision";
            this.txtBoxVillageSubdivision.Size = new System.Drawing.Size(161, 22);
            this.txtBoxVillageSubdivision.TabIndex = 44;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(454, 255);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(131, 22);
            this.txtBoxCity.TabIndex = 45;
            // 
            // txtBoxProvince
            // 
            this.txtBoxProvince.Location = new System.Drawing.Point(591, 255);
            this.txtBoxProvince.Name = "txtBoxProvince";
            this.txtBoxProvince.Size = new System.Drawing.Size(131, 22);
            this.txtBoxProvince.TabIndex = 46;
            // 
            // txtBoxZipCode
            // 
            this.txtBoxZipCode.Location = new System.Drawing.Point(728, 255);
            this.txtBoxZipCode.Name = "txtBoxZipCode";
            this.txtBoxZipCode.Size = new System.Drawing.Size(153, 22);
            this.txtBoxZipCode.TabIndex = 47;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.Location = new System.Drawing.Point(725, 236);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(62, 16);
            this.lblZipCode.TabIndex = 48;
            this.lblZipCode.Text = "Zip Code";
            // 
            // mskdTxtBoxBirthDate
            // 
            this.mskdTxtBoxBirthDate.Location = new System.Drawing.Point(425, 174);
            this.mskdTxtBoxBirthDate.Mask = "00-00-0000";
            this.mskdTxtBoxBirthDate.Name = "mskdTxtBoxBirthDate";
            this.mskdTxtBoxBirthDate.Size = new System.Drawing.Size(141, 22);
            this.mskdTxtBoxBirthDate.TabIndex = 49;
            this.mskdTxtBoxBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(732, 174);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(153, 22);
            this.txtBoxPhoneNumber.TabIndex = 34;
            this.txtBoxPhoneNumber.TextChanged += new System.EventHandler(this.txtBoxPhoneNumber_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 567);
            this.Controls.Add(this.mskdTxtBoxBirthDate);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.txtBoxZipCode);
            this.Controls.Add(this.txtBoxProvince);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.txtBoxVillageSubdivision);
            this.Controls.Add(this.txtBoxStreet);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.txtBoxUBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSuffix);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtBoxPhoneNumber);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblVillageSubdivision);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblUBL);
            this.Controls.Add(this.txtBoxSex);
            this.Controls.Add(this.lblFullAddress);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblmmddyyy);
            this.Controls.Add(this.txtBoxBirthDate);
            this.Controls.Add(this.lvlBirthDate);
            this.Controls.Add(this.txtBoxSuffix);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxMiddleName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picBoxInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeader2);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.picboxDesign);
            this.Name = "Form1";
            this.Text = "Contact Tracing App";
            ((System.ComponentModel.ISupportInitialize)(this.picboxDesign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox picboxDesign;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxInfo1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxMiddleName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxSuffix;
        private System.Windows.Forms.Label lvlBirthDate;
        private System.Windows.Forms.TextBox txtBoxBirthDate;
        private System.Windows.Forms.Label lblmmddyyy;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.Label lblFullAddress;
        private System.Windows.Forms.TextBox txtBoxSex;
        private System.Windows.Forms.Label lblUBL;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblVillageSubdivision;
        private EventHandler txtBoxFirstName_TextChanged;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxUBL;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtBoxStreet;
        private System.Windows.Forms.TextBox txtBoxVillageSubdivision;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxProvince;
        private System.Windows.Forms.TextBox txtBoxZipCode;
        private System.Windows.Forms.Label lblZipCode;
        private EventHandler label3_Click;
        private EventHandler pictureBox1_Click;
        private System.Windows.Forms.MaskedTextBox mskdTxtBoxBirthDate;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
    }
}

