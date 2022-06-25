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
            this.lblEnterDate = new System.Windows.Forms.Label();
            this.txtBoxEnterDate = new System.Windows.Forms.TextBox();
            this.lblPleaseEnter = new System.Windows.Forms.Label();
            this.lblEnterTime = new System.Windows.Forms.Label();
            this.txtBoxEnterTime = new System.Windows.Forms.TextBox();
            this.btnFilterSubmission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterDate
            // 
            this.lblEnterDate.AutoSize = true;
            this.lblEnterDate.Location = new System.Drawing.Point(42, 81);
            this.lblEnterDate.Name = "lblEnterDate";
            this.lblEnterDate.Size = new System.Drawing.Size(39, 16);
            this.lblEnterDate.TabIndex = 0;
            this.lblEnterDate.Text = "Date:";
            // 
            // txtBoxEnterDate
            // 
            this.txtBoxEnterDate.Location = new System.Drawing.Point(87, 78);
            this.txtBoxEnterDate.Name = "txtBoxEnterDate";
            this.txtBoxEnterDate.Size = new System.Drawing.Size(157, 22);
            this.txtBoxEnterDate.TabIndex = 1;
            // 
            // lblPleaseEnter
            // 
            this.lblPleaseEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseEnter.Location = new System.Drawing.Point(12, 9);
            this.lblPleaseEnter.Name = "lblPleaseEnter";
            this.lblPleaseEnter.Size = new System.Drawing.Size(271, 64);
            this.lblPleaseEnter.TabIndex = 2;
            this.lblPleaseEnter.Text = "Enter a specific Date and Time of the submission you want to review.";
            this.lblPleaseEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnterTime
            // 
            this.lblEnterTime.AutoSize = true;
            this.lblEnterTime.Location = new System.Drawing.Point(42, 118);
            this.lblEnterTime.Name = "lblEnterTime";
            this.lblEnterTime.Size = new System.Drawing.Size(41, 16);
            this.lblEnterTime.TabIndex = 3;
            this.lblEnterTime.Text = "Time:";
            // 
            // txtBoxEnterTime
            // 
            this.txtBoxEnterTime.Location = new System.Drawing.Point(87, 115);
            this.txtBoxEnterTime.Name = "txtBoxEnterTime";
            this.txtBoxEnterTime.Size = new System.Drawing.Size(157, 22);
            this.txtBoxEnterTime.TabIndex = 4;
            // 
            // btnFilterSubmission
            // 
            this.btnFilterSubmission.Location = new System.Drawing.Point(87, 157);
            this.btnFilterSubmission.Name = "btnFilterSubmission";
            this.btnFilterSubmission.Size = new System.Drawing.Size(157, 23);
            this.btnFilterSubmission.TabIndex = 5;
            this.btnFilterSubmission.Text = "Enter";
            this.btnFilterSubmission.UseVisualStyleBackColor = true;
            this.btnFilterSubmission.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 203);
            this.Controls.Add(this.btnFilterSubmission);
            this.Controls.Add(this.txtBoxEnterTime);
            this.Controls.Add(this.lblEnterTime);
            this.Controls.Add(this.lblPleaseEnter);
            this.Controls.Add(this.txtBoxEnterDate);
            this.Controls.Add(this.lblEnterDate);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review Submission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterDate;
        private System.Windows.Forms.TextBox txtBoxEnterDate;
        private System.Windows.Forms.Label lblPleaseEnter;
        private System.Windows.Forms.Label lblEnterTime;
        private System.Windows.Forms.TextBox txtBoxEnterTime;
        private System.Windows.Forms.Button btnFilterSubmission;
    }
}