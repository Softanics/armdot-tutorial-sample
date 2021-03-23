namespace armdot_tutorial_sample
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
            this.buttonCheckPassword = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCheckLicense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCheckPassword
            // 
            this.buttonCheckPassword.Location = new System.Drawing.Point(12, 102);
            this.buttonCheckPassword.Name = "buttonCheckPassword";
            this.buttonCheckPassword.Size = new System.Drawing.Size(158, 23);
            this.buttonCheckPassword.TabIndex = 0;
            this.buttonCheckPassword.Text = "Check Password";
            this.buttonCheckPassword.UseVisualStyleBackColor = true;
            this.buttonCheckPassword.Click += new System.EventHandler(this.buttonCheckPassword_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(105, 13);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(224, 73);
            this.textBoxPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Password: ";
            // 
            // buttonCheckLicense
            // 
            this.buttonCheckLicense.Location = new System.Drawing.Point(174, 102);
            this.buttonCheckLicense.Name = "buttonCheckLicense";
            this.buttonCheckLicense.Size = new System.Drawing.Size(155, 23);
            this.buttonCheckLicense.TabIndex = 3;
            this.buttonCheckLicense.Text = "Check License";
            this.buttonCheckLicense.UseVisualStyleBackColor = true;
            this.buttonCheckLicense.Click += new System.EventHandler(this.buttonCheckLicense_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 159);
            this.Controls.Add(this.buttonCheckLicense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonCheckPassword);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCheckLicense;
    }
}

