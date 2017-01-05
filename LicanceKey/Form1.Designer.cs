namespace LicanceKey
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
            this.btnGenarete = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenarete
            // 
            this.btnGenarete.Location = new System.Drawing.Point(51, 73);
            this.btnGenarete.Name = "btnGenarete";
            this.btnGenarete.Size = new System.Drawing.Size(75, 53);
            this.btnGenarete.TabIndex = 0;
            this.btnGenarete.Text = "Genarete";
            this.btnGenarete.UseVisualStyleBackColor = true;
            this.btnGenarete.Click += new System.EventHandler(this.btnGenarete_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(142, 73);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(75, 53);
            this.btnRegistration.TabIndex = 1;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(234, 73);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 53);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 183);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnGenarete);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenarete;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnAbout;
    }
}

