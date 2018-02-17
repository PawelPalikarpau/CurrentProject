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
            this.registrationButton = new MyProjectUI.CustomForms.RegularButton();
            this.backButton = new MyProjectUI.CustomForms.RegularButton();
            this.emailTextControl = new MyProjectUI.CustomForms.InputTextControl();
            this.paswordTextControl = new MyProjectUI.CustomForms.InputTextControl();
            this.confirmPasswrodTextControl = new MyProjectUI.CustomForms.InputTextControl();
            this.SuspendLayout();
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.registrationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.registrationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.registrationButton.ForeColorOnMouseEnter = System.Drawing.Color.Yellow;
            this.registrationButton.Location = new System.Drawing.Point(41, 195);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(186, 55);
            this.registrationButton.TabIndex = 3;
            this.registrationButton.Text = "Registrate";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.backButton.ForeColorOnMouseEnter = System.Drawing.Color.Yellow;
            this.backButton.Location = new System.Drawing.Point(241, 195);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(186, 55);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // emailTextControl
            // 
            this.emailTextControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.emailTextControl.ErrorLabelText = "label2";
            this.emailTextControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailTextControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.emailTextControl.InputText = "";
            this.emailTextControl.Location = new System.Drawing.Point(41, 14);
            this.emailTextControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTextControl.Name = "emailTextControl";
            this.emailTextControl.NameLabelText = "Email";
            this.emailTextControl.Size = new System.Drawing.Size(386, 51);
            this.emailTextControl.TabIndex = 5;
            this.emailTextControl.TextBoxLocation = new System.Drawing.Point(160, 6);
            this.emailTextControl.TextBoxSize = new System.Drawing.Size(225, 19);
            // 
            // paswordTextControl
            // 
            this.paswordTextControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.paswordTextControl.ErrorLabelText = "label2";
            this.paswordTextControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.paswordTextControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.paswordTextControl.InputText = "";
            this.paswordTextControl.Location = new System.Drawing.Point(41, 75);
            this.paswordTextControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paswordTextControl.Name = "paswordTextControl";
            this.paswordTextControl.NameLabelText = "Enter Password";
            this.paswordTextControl.Size = new System.Drawing.Size(386, 51);
            this.paswordTextControl.TabIndex = 6;
            this.paswordTextControl.TextBoxLocation = new System.Drawing.Point(160, 6);
            this.paswordTextControl.TextBoxSize = new System.Drawing.Size(225, 19);
            // 
            // inputTextControl2
            // 
            this.confirmPasswrodTextControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.confirmPasswrodTextControl.ErrorLabelText = "label2";
            this.confirmPasswrodTextControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmPasswrodTextControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.confirmPasswrodTextControl.InputText = "";
            this.confirmPasswrodTextControl.Location = new System.Drawing.Point(41, 136);
            this.confirmPasswrodTextControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmPasswrodTextControl.Name = "inputTextControl2";
            this.confirmPasswrodTextControl.NameLabelText = "Confirm Password";
            this.confirmPasswrodTextControl.Size = new System.Drawing.Size(386, 51);
            this.confirmPasswrodTextControl.TabIndex = 7;
            this.confirmPasswrodTextControl.TextBoxLocation = new System.Drawing.Point(160, 6);
            this.confirmPasswrodTextControl.TextBoxSize = new System.Drawing.Size(225, 19);
            // 
            // RegistrationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(464, 272);
            this.Controls.Add(this.confirmPasswrodTextControl);
            this.Controls.Add(this.paswordTextControl);
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
        private CustomForms.InputTextControl paswordTextControl;
        private CustomForms.InputTextControl confirmPasswrodTextControl;
    }
}