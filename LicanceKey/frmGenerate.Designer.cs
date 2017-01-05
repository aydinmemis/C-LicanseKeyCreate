namespace LicanceKey
{
    partial class frmGenerate
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmnLicanseType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGecerlilik = new System.Windows.Forms.TextBox();
            this.txtProductKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product ID :";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(124, 22);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(348, 20);
            this.txtProductID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = " Licance Type :";
            // 
            // cmnLicanseType
            // 
            this.cmnLicanseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmnLicanseType.FormattingEnabled = true;
            this.cmnLicanseType.Items.AddRange(new object[] {
            "Full",
            "Trial"});
            this.cmnLicanseType.Location = new System.Drawing.Point(125, 46);
            this.cmnLicanseType.Name = "cmnLicanseType";
            this.cmnLicanseType.Size = new System.Drawing.Size(139, 21);
            this.cmnLicanseType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Geçerlilik Süresi :";
            // 
            // txtGecerlilik
            // 
            this.txtGecerlilik.Location = new System.Drawing.Point(124, 72);
            this.txtGecerlilik.Name = "txtGecerlilik";
            this.txtGecerlilik.Size = new System.Drawing.Size(137, 20);
            this.txtGecerlilik.TabIndex = 6;
            // 
            // txtProductKey
            // 
            this.txtProductKey.Location = new System.Drawing.Point(124, 95);
            this.txtProductKey.Name = "txtProductKey";
            this.txtProductKey.ReadOnly = true;
            this.txtProductKey.Size = new System.Drawing.Size(347, 20);
            this.txtProductKey.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product Key :";
            // 
            // frmGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 163);
            this.Controls.Add(this.txtProductKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGecerlilik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmnLicanseType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "frmGenerate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generate";
            this.Load += new System.EventHandler(this.frmGenerate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmnLicanseType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGecerlilik;
        private System.Windows.Forms.TextBox txtProductKey;
        private System.Windows.Forms.Label label4;
    }
}