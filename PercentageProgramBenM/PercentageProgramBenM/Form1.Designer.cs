namespace PercentageProgramBenM
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
            this.lblEnterGrade = new System.Windows.Forms.Label();
            this.txtGradeLvl = new System.Windows.Forms.TextBox();
            this.btnCalculatePercent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterGrade
            // 
            this.lblEnterGrade.AutoSize = true;
            this.lblEnterGrade.Location = new System.Drawing.Point(68, 66);
            this.lblEnterGrade.Name = "lblEnterGrade";
            this.lblEnterGrade.Size = new System.Drawing.Size(93, 13);
            this.lblEnterGrade.TabIndex = 0;
            this.lblEnterGrade.Text = "Enter Grade Level";
            // 
            // txtGradeLvl
            // 
            this.txtGradeLvl.Location = new System.Drawing.Point(179, 63);
            this.txtGradeLvl.Name = "txtGradeLvl";
            this.txtGradeLvl.Size = new System.Drawing.Size(100, 20);
            this.txtGradeLvl.TabIndex = 1;
            // 
            // btnCalculatePercent
            // 
            this.btnCalculatePercent.Location = new System.Drawing.Point(88, 144);
            this.btnCalculatePercent.Name = "btnCalculatePercent";
            this.btnCalculatePercent.Size = new System.Drawing.Size(134, 42);
            this.btnCalculatePercent.TabIndex = 2;
            this.btnCalculatePercent.Text = "Calculate Percentage";
            this.btnCalculatePercent.UseVisualStyleBackColor = true;
            this.btnCalculatePercent.Click += new System.EventHandler(this.btnCalculatePercent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 276);
            this.Controls.Add(this.btnCalculatePercent);
            this.Controls.Add(this.txtGradeLvl);
            this.Controls.Add(this.lblEnterGrade);
            this.Name = "Form1";
            this.Text = "Percentage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterGrade;
        private System.Windows.Forms.TextBox txtGradeLvl;
        private System.Windows.Forms.Button btnCalculatePercent;
    }
}

