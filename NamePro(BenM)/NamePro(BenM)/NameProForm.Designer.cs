namespace NamePro_BenM_
{
    partial class frmNamePro
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
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.btnPressMe = new System.Windows.Forms.Button();
            this.lblAptNumb = new System.Windows.Forms.Label();
            this.txtAptNumb = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(64, 43);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(104, 13);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Enter Street Address";
            this.lblStreet.Click += new System.EventHandler(this.lblFirstName_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(64, 98);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(52, 13);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "Enter City";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(64, 154);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(77, 13);
            this.lblProvince.TabIndex = 2;
            this.lblProvince.Text = "Enter Province";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(172, 40);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(100, 20);
            this.txtStreetAddress.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(172, 98);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 4;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(172, 151);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(100, 20);
            this.txtProvince.TabIndex = 5;
            // 
            // btnPressMe
            // 
            this.btnPressMe.Location = new System.Drawing.Point(355, 137);
            this.btnPressMe.Name = "btnPressMe";
            this.btnPressMe.Size = new System.Drawing.Size(134, 47);
            this.btnPressMe.TabIndex = 6;
            this.btnPressMe.Text = "Press Me!";
            this.btnPressMe.UseVisualStyleBackColor = true;
            this.btnPressMe.Click += new System.EventHandler(this.btnPressMe_Click);
            // 
            // lblAptNumb
            // 
            this.lblAptNumb.AutoSize = true;
            this.lblAptNumb.Location = new System.Drawing.Point(305, 43);
            this.lblAptNumb.Name = "lblAptNumb";
            this.lblAptNumb.Size = new System.Drawing.Size(101, 13);
            this.lblAptNumb.TabIndex = 7;
            this.lblAptNumb.Text = "Appartment Number";
            // 
            // txtAptNumb
            // 
            this.txtAptNumb.Location = new System.Drawing.Point(412, 40);
            this.txtAptNumb.Name = "txtAptNumb";
            this.txtAptNumb.Size = new System.Drawing.Size(100, 20);
            this.txtAptNumb.TabIndex = 8;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(64, 226);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(88, 13);
            this.lblPostalCode.TabIndex = 9;
            this.lblPostalCode.Text = "Enter Postalcode";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(172, 219);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 10;
            // 
            // frmNamePro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 309);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.txtAptNumb);
            this.Controls.Add(this.lblAptNumb);
            this.Controls.Add(this.btnPressMe);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreet);
            this.Name = "frmNamePro";
            this.Text = "Address Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Button btnPressMe;
        private System.Windows.Forms.Label lblAptNumb;
        private System.Windows.Forms.TextBox txtAptNumb;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtPostalCode;
    }
}

