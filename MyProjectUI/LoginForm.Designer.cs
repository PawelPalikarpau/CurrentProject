namespace MyProjectUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.exitButton = new MyProjectUI.CustomForms.RegularButton();
            this.registrateButton = new MyProjectUI.CustomForms.RegularButton();
            this.loginButton = new MyProjectUI.CustomForms.RegularButton();
            this.emailTextControl = new MyProjectUI.CustomForms.InputTextControl();
            this.passwordTextControl = new MyProjectUI.CustomForms.InputTextControl();
            this.xButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.exitButton.ForeColorOnMouseEnter = System.Drawing.Color.Yellow;
            this.exitButton.Location = new System.Drawing.Point(289, 156);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(132, 56);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // registrateButton
            // 
            this.registrateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.registrateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.registrateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.registrateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.registrateButton.ForeColorOnMouseEnter = System.Drawing.Color.Yellow;
            this.registrateButton.Location = new System.Drawing.Point(151, 156);
            this.registrateButton.Name = "registrateButton";
            this.registrateButton.Size = new System.Drawing.Size(132, 56);
            this.registrateButton.TabIndex = 3;
            this.registrateButton.Text = "Registrate";
            this.registrateButton.UseVisualStyleBackColor = false;
            this.registrateButton.Click += new System.EventHandler(this.registrateButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.loginButton.ForeColorOnMouseEnter = System.Drawing.Color.Yellow;
            this.loginButton.Location = new System.Drawing.Point(13, 156);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(132, 56);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
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
            this.emailTextControl.Location = new System.Drawing.Point(13, 42);
            this.emailTextControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTextControl.Name = "emailTextControl";
            this.emailTextControl.NameLabelText = "E-mail";
            this.emailTextControl.Size = new System.Drawing.Size(408, 48);
            this.emailTextControl.TabIndex = 0;
            this.emailTextControl.TextBoxLocation = new System.Drawing.Point(90, 6);
            this.emailTextControl.TextBoxSize = new System.Drawing.Size(315, 19);
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
            this.passwordTextControl.Location = new System.Drawing.Point(13, 100);
            this.passwordTextControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTextControl.Name = "passwordTextControl";
            this.passwordTextControl.NameLabelText = "Password";
            this.passwordTextControl.Size = new System.Drawing.Size(408, 48);
            this.passwordTextControl.TabIndex = 1;
            this.passwordTextControl.TextBoxLocation = new System.Drawing.Point(90, 6);
            this.passwordTextControl.TextBoxSize = new System.Drawing.Size(315, 19);
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
            this.xButton.Location = new System.Drawing.Point(408, 0);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(28, 27);
            this.xButton.TabIndex = 5;
            this.xButton.UseVisualStyleBackColor = false;
            this.xButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(436, 227);
            this.Controls.Add(this.xButton);
            this.Controls.Add(this.passwordTextControl);
            this.Controls.Add(this.emailTextControl);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.registrateButton);
            this.Controls.Add(this.loginButton);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion
        private CustomForms.RegularButton loginButton;
        private CustomForms.RegularButton registrateButton;
        private CustomForms.RegularButton exitButton;
        private CustomForms.InputTextControl emailTextControl;
        private CustomForms.InputTextControl passwordTextControl;
        private System.Windows.Forms.Button xButton;
    }
}

