namespace MyProjectUI
{
    partial class RegistrationForm
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
            this.emailLabel = new System.Windows.Forms.Label();
            this.enterPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.secondPasswordTextBox = new System.Windows.Forms.TextBox();
            this.firstPasswordTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(33, 41);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(97, 21);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Enter E-mail:";
            // 
            // enterPasswordLabel
            // 
            this.enterPasswordLabel.AutoSize = true;
            this.enterPasswordLabel.Location = new System.Drawing.Point(33, 83);
            this.enterPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enterPasswordLabel.Name = "enterPasswordLabel";
            this.enterPasswordLabel.Size = new System.Drawing.Size(119, 21);
            this.enterPasswordLabel.TabIndex = 1;
            this.enterPasswordLabel.Text = "Enter Password:";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(33, 124);
            this.confirmPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(140, 21);
            this.confirmPasswordLabel.TabIndex = 2;
            this.confirmPasswordLabel.Text = "Confirm Password:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(180, 38);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(205, 29);
            this.emailTextBox.TabIndex = 3;
            // 
            // secondPasswordTextBox
            // 
            this.secondPasswordTextBox.Location = new System.Drawing.Point(180, 121);
            this.secondPasswordTextBox.Name = "secondPasswordTextBox";
            this.secondPasswordTextBox.Size = new System.Drawing.Size(205, 29);
            this.secondPasswordTextBox.TabIndex = 4;
            // 
            // firstPasswordTextBox
            // 
            this.firstPasswordTextBox.Location = new System.Drawing.Point(180, 80);
            this.firstPasswordTextBox.Name = "firstPasswordTextBox";
            this.firstPasswordTextBox.Size = new System.Drawing.Size(205, 29);
            this.firstPasswordTextBox.TabIndex = 5;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.backButton.Location = new System.Drawing.Point(219, 169);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(167, 55);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.registrationButton.Location = new System.Drawing.Point(37, 169);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(167, 55);
            this.registrationButton.TabIndex = 8;
            this.registrationButton.Text = "Registrate";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 250);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.firstPasswordTextBox);
            this.Controls.Add(this.secondPasswordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.enterPasswordLabel);
            this.Controls.Add(this.emailLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrationForm";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label enterPasswordLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox secondPasswordTextBox;
        private System.Windows.Forms.TextBox firstPasswordTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button registrationButton;
    }
}