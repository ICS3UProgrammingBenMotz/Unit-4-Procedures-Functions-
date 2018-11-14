namespace ConvertingTemps_BenM_
{
    partial class frmConvertingTemp
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
            this.lblEnterTemp = new System.Windows.Forms.Label();
            this.txtTempCel = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterTemp
            // 
            this.lblEnterTemp.AutoSize = true;
            this.lblEnterTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterTemp.Location = new System.Drawing.Point(22, 46);
            this.lblEnterTemp.Name = "lblEnterTemp";
            this.lblEnterTemp.Size = new System.Drawing.Size(268, 24);
            this.lblEnterTemp.TabIndex = 0;
            this.lblEnterTemp.Text = "Enter Temperature (in Celcius)";
            // 
            // txtTempCel
            // 
            this.txtTempCel.Location = new System.Drawing.Point(310, 51);
            this.txtTempCel.Name = "txtTempCel";
            this.txtTempCel.Size = new System.Drawing.Size(100, 20);
            this.txtTempCel.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(124, 154);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(192, 61);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert to Farenheight";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // frmConvertingTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 347);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtTempCel);
            this.Controls.Add(this.lblEnterTemp);
            this.Name = "frmConvertingTemp";
            this.Text = "Temp Converter";
            this.Load += new System.EventHandler(this.frmConvertingTemp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterTemp;
        private System.Windows.Forms.TextBox txtTempCel;
        private System.Windows.Forms.Button btnConvert;
    }
}

