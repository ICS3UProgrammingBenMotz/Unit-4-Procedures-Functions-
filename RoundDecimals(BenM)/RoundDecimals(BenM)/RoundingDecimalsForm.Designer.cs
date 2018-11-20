namespace RoundDecimals_BenM_
{
    partial class frmRoundingDecimals
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
            this.lblEnterNumb = new System.Windows.Forms.Label();
            this.lblNumbOfDeciPla = new System.Windows.Forms.Label();
            this.txtNumb = new System.Windows.Forms.TextBox();
            this.nudNumbOfDeciPla = new System.Windows.Forms.NumericUpDown();
            this.btnRoundIt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumbOfDeciPla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterNumb
            // 
            this.lblEnterNumb.AutoSize = true;
            this.lblEnterNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNumb.Location = new System.Drawing.Point(177, 50);
            this.lblEnterNumb.Name = "lblEnterNumb";
            this.lblEnterNumb.Size = new System.Drawing.Size(121, 18);
            this.lblEnterNumb.TabIndex = 0;
            this.lblEnterNumb.Text = "Enter the number";
            // 
            // lblNumbOfDeciPla
            // 
            this.lblNumbOfDeciPla.AutoSize = true;
            this.lblNumbOfDeciPla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbOfDeciPla.Location = new System.Drawing.Point(12, 137);
            this.lblNumbOfDeciPla.Name = "lblNumbOfDeciPla";
            this.lblNumbOfDeciPla.Size = new System.Drawing.Size(286, 18);
            this.lblNumbOfDeciPla.TabIndex = 1;
            this.lblNumbOfDeciPla.Text = "How many decimal places would you like?";
            // 
            // txtNumb
            // 
            this.txtNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumb.Location = new System.Drawing.Point(337, 51);
            this.txtNumb.Name = "txtNumb";
            this.txtNumb.Size = new System.Drawing.Size(100, 24);
            this.txtNumb.TabIndex = 2;
            // 
            // nudNumbOfDeciPla
            // 
            this.nudNumbOfDeciPla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumbOfDeciPla.Location = new System.Drawing.Point(317, 135);
            this.nudNumbOfDeciPla.Name = "nudNumbOfDeciPla";
            this.nudNumbOfDeciPla.Size = new System.Drawing.Size(120, 24);
            this.nudNumbOfDeciPla.TabIndex = 3;
            // 
            // btnRoundIt
            // 
            this.btnRoundIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoundIt.Location = new System.Drawing.Point(180, 196);
            this.btnRoundIt.Name = "btnRoundIt";
            this.btnRoundIt.Size = new System.Drawing.Size(162, 42);
            this.btnRoundIt.TabIndex = 4;
            this.btnRoundIt.Text = "Round It!";
            this.btnRoundIt.UseVisualStyleBackColor = true;
            this.btnRoundIt.Click += new System.EventHandler(this.btnRoundIt_Click);
            // 
            // frmRoundingDecimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 276);
            this.Controls.Add(this.btnRoundIt);
            this.Controls.Add(this.nudNumbOfDeciPla);
            this.Controls.Add(this.txtNumb);
            this.Controls.Add(this.lblNumbOfDeciPla);
            this.Controls.Add(this.lblEnterNumb);
            this.Name = "frmRoundingDecimals";
            this.Text = "Rounding Decimals";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumbOfDeciPla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNumb;
        private System.Windows.Forms.Label lblNumbOfDeciPla;
        private System.Windows.Forms.TextBox txtNumb;
        private System.Windows.Forms.NumericUpDown nudNumbOfDeciPla;
        private System.Windows.Forms.Button btnRoundIt;
    }
}

