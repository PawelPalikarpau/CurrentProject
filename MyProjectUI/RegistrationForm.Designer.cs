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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.xButton = new System.Windows.Forms.Button();
            this.confirmPasswrodTextControl = new MyProjectUI.CustomForms.InputTextControl();
            this.passwordTextControl = new MyProjectUI.CustomForms.InputTextControl();
            this.emailTextControl = new MyProjectUI.CustomForms.InputTextControl();
            this.backButton = new MyProjectUI.CustomForms.RegularButton();
            this.registrationButton = new MyProjectUI.CustomForms.RegularButton();
            this.SuspendLayout();
            // 
            // xButton
            // 
            this.xButton.BackColor = System.Drawing.Color.Tomato;
            this.xButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xButton.BackgroundImage")));
            this.xButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xButton.FlatAppearance.BorderSize = 0;
            this.xButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.xButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.xButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xButton.Location = new System.Drawing.Point(398, 0);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(28, 27);
            this.xButton.TabIndex = 6;
            this.xButton.UseVisualStyleBackColor = false;
            this.xButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirmPasswrodTextControl
            // 
            this.confirmPasswrodTextControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.confirmPasswrodTextControl.CharForPassword = '*';
            this.confirmPasswrodTextControl.ErrorLabelText = "";
            this.confirmPasswrodTextControl.ErrorType = MyProjectLibrary.Enums.ErrorMessageType.Warning;
            this.confirmPasswrodTextControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmPasswrodTextControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.confirmPasswrodTextControl.InputText = "";
            this.confirmPasswrodTextControl.Location = new System.Drawing.Point(13, 159);
            this.confirmPasswrodTextControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmPasswrodTextControl.Name = "confirmPasswrodTextControl";
            this.confirmPasswrodTextControl.NameLabelText = "Confirm Password";
            this.confirmPasswrodTextControl.Size = new System.Drawing.Size(397, 51);
            this.confirmPasswrodTextControl.TabIndex = 2;
            this.confirmPasswrodTextControl.TextBoxLocation = new System.Drawing.Point(160, 6);
            this.confirmPasswrodTextControl.TextBoxSize = new System.Drawing.Size(235, 19);
            // 
            // passwordTextControl
            // 
            this.passwordTextControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.passwordTextControl.CharForPassword = '*';
            this.passwordTextControl.ErrorLabelText = "";
            this.passwordTextControl.ErrorType = MyProjectLibrary.Enums.ErrorMessageType.Warning;
            this.passwordTextControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordTextControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.passwordTextControl.InputText = "";
            this.passwordTextControl.Location = new System.Drawing.Point(13, 98);
            this.passwordTextControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTextControl.Name = "passwordTextControl";
            this.passwordTextControl.NameLabelText = "Enter Password";
            this.passwordTextControl.Size = new System.Drawing.Size(397, 51);
            this.passwordTextControl.TabIndex = 1;
            this.passwordTextControl.TextBoxLocation = new System.Drawing.Point(160, 6);
            this.passwordTextControl.TextBoxSize = new System.Drawing.Size(235, 19);
            // 
            // emailTextControl
            // 
            this.emailTextControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.emailTextControl.CharForPassword = '\0';
            this.emailTextControl.ErrorLabelText = "";
            this.emailTextControl.ErrorType = MyProjectLibrary.Enums.ErrorMessageType.Warning;
            this.emailTextControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailTextControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.emailTextControl.InputText = "";
            this.emailTextControl.Location = new System.Drawing.Point(13, 37);
            this.emailTextControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTextControl.Name = "emailTextControl";
            this.emailTextControl.NameLabelText = "E-mail";
            this.emailTextControl.Size = new System.Drawing.Size(397, 51);
            this.emailTextControl.TabIndex = 0;
            this.emailTextControl.TextBoxLocation = new System.Drawing.Point(160, 6);
            this.emailTextControl.TextBoxSize = new System.Drawing.Size(235, 19);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.backButton.ForeColorOnMouseEnter = System.Drawing.Color.Yellow;
            this.backButton.Location = new System.Drawing.Point(224, 218);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(186, 55);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.registrationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.registrationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.registrationButton.ForeColorOnMouseEnter = System.Drawing.Color.Yellow;
            this.registrationButton.Location = new System.Drawing.Point(13, 218);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(186, 55);
            this.registrationButton.TabIndex = 3;
            this.registrationButton.Text = "Registrate";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(426, 288);
            this.Controls.Add(this.xButton);
            this.Controls.Add(this.confirmPasswrodTextControl);
            this.Controls.Add(this.passwordTextControl);
            this.Controls.Add(this.emailTextControl);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.registrationButton);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);

        }

        #endregion
        private CustomForms.RegularButton registrationButton;
        private CustomForms.RegularButton backButton;
        private CustomForms.InputTextControl emailTextControl;
        private CustomForms.InputTextControl passwordTextControl;
        private CustomForms.InputTextControl confirmPasswrodTextControl;
        private System.Windows.Forms.Button xButton;
    }
}