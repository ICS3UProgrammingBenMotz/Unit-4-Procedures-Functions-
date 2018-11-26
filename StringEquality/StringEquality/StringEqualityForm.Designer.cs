namespace StringEquality
{
    partial class frmStringEquality
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
            this.lblEnterTwo = new System.Windows.Forms.Label();
            this.txtStringOne = new System.Windows.Forms.TextBox();
            this.txtStringTwo = new System.Windows.Forms.TextBox();
            this.lblStringOne = new System.Windows.Forms.Label();
            this.lblStringTwo = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterTwo
            // 
            this.lblEnterTwo.AutoSize = true;
            this.lblEnterTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterTwo.Location = new System.Drawing.Point(82, 36);
            this.lblEnterTwo.Name = "lblEnterTwo";
            this.lblEnterTwo.Size = new System.Drawing.Size(296, 20);
            this.lblEnterTwo.TabIndex = 0;
            this.lblEnterTwo.Text = "Enter two strings to see if they are equal.";
            // 
            // txtStringOne
            // 
            this.txtStringOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStringOne.Location = new System.Drawing.Point(182, 90);
            this.txtStringOne.Name = "txtStringOne";
            this.txtStringOne.Size = new System.Drawing.Size(196, 26);
            this.txtStringOne.TabIndex = 1;
            // 
            // txtStringTwo
            // 
            this.txtStringTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStringTwo.Location = new System.Drawing.Point(182, 170);
            this.txtStringTwo.Name = "txtStringTwo";
            this.txtStringTwo.Size = new System.Drawing.Size(196, 26);
            this.txtStringTwo.TabIndex = 2;
            // 
            // lblStringOne
            // 
            this.lblStringOne.AutoSize = true;
            this.lblStringOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStringOne.Location = new System.Drawing.Point(82, 90);
            this.lblStringOne.Name = "lblStringOne";
            this.lblStringOne.Size = new System.Drawing.Size(68, 20);
            this.lblStringOne.TabIndex = 3;
            this.lblStringOne.Text = "String 1:";
            // 
            // lblStringTwo
            // 
            this.lblStringTwo.AutoSize = true;
            this.lblStringTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStringTwo.Location = new System.Drawing.Point(82, 176);
            this.lblStringTwo.Name = "lblStringTwo";
            this.lblStringTwo.Size = new System.Drawing.Size(68, 20);
            this.lblStringTwo.TabIndex = 4;
            this.lblStringTwo.Text = "String 2:";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(182, 222);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 32);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmStringEquality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 317);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblStringTwo);
            this.Controls.Add(this.lblStringOne);
            this.Controls.Add(this.txtStringTwo);
            this.Controls.Add(this.txtStringOne);
            this.Controls.Add(this.lblEnterTwo);
            this.Name = "frmStringEquality";
            this.Text = "String Equality";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterTwo;
        private System.Windows.Forms.TextBox txtStringOne;
        private System.Windows.Forms.TextBox txtStringTwo;
        private System.Windows.Forms.Label lblStringOne;
        private System.Windows.Forms.Label lblStringTwo;
        private System.Windows.Forms.Button btnCheck;
    }
}

