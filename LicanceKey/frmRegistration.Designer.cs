namespace LicanceKey
{
    partial class frmRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductKey = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Key :";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(98, 23);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(317, 20);
            this.txtProductID.TabIndex = 2;
            // 
            // txtProductKey
            // 
            this.txtProductKey.Location = new System.Drawing.Point(98, 50);
            this.txtProductKey.Name = "txtProductKey";
            this.txtProductKey.Size = new System.Drawing.Size(317, 20);
            this.txtProductKey.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 107);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProductKey);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmRegistration";
            this.Text = "frmRegistration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductKey;
        private System.Windows.Forms.Button button1;
    }
}