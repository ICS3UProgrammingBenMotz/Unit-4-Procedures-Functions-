namespace DynamIcWalker_BenM_
{
    partial class frmDynaimcWalker
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
            this.lblClick = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.Location = new System.Drawing.Point(272, 77);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(121, 13);
            this.lblClick.TabIndex = 0;
            this.lblClick.Text = "Click one of the pictures";
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::DynamIcWalker_BenM_.Properties.Resources.walk10;
            this.PictureBox.Location = new System.Drawing.Point(355, 216);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(151, 49);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // frmDynaimcWalker
            // 
            this.ClientSize = new System.Drawing.Size(650, 435);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.lblClick);
            this.Name = "frmDynaimcWalker";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClick;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}

