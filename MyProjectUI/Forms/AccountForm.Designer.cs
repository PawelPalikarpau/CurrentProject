namespace MyProjectUI.Forms
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.xButton = new System.Windows.Forms.Button();
            this.topInfoLabel = new System.Windows.Forms.Label();
            this.downInfoLabel = new System.Windows.Forms.Label();
            this.middleInfoLabel = new System.Windows.Forms.Label();
            this.endInfoLabel = new System.Windows.Forms.Label();
            this.phoneTextControl = new MyProjectUI.CustomForms.InputTextControl();
            this.emailTextControl = new MyProjectUI.CustomForms.InputTextControl();
            this.lastNameTextControl = new MyProjectUI.CustomForms.InputTextControl();
            this.firstNameTextControl = new MyProjectUI.CustomForms.InputTextControl();
            this.backButton = new MyProjectUI.CustomForms.RegularButton();
            this.changeApplayButton = new MyProjectUI.CustomForms.RegularButton();
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
            this.xButton.Location = new System.Drawing.Point(474, 0);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(28, 27);
            this.xButton.TabIndex = 11;
            this.xButton.UseVisualStyleBackColor = false;
            this.xButton.Click += new System.EventHandler(this.xButton_Click);
            // 
            // topInfoLabel
            // 
            this.topInfoLabel.AutoSize = true;
            this.topInfoLabel.Location = new System.Drawing.Point(122, 9);
            this.topInfoLabel.Name = "topInfoLabel";
            this.topInfoLabel.Size = new System.Drawing.Size(259, 21);
            this.topInfoLabel.TabIndex = 12;
            this.topInfoLabel.Text = "Account data is not changable";
            // 
            // downInfoLabel
            // 
            this.downInfoLabel.AutoSize = true;
            this.downInfoLabel.Location = new System.Drawing.Point(21, 36);
            this.downInfoLabel.Name = "downInfoLabel";
            this.downInfoLabel.Size = new System.Drawing.Size(121, 21);
            this.downInfoLabel.TabIndex = 13;
            this.downInfoLabel.Text = "You must click";
            // 
            // middleInfoLabel
            // 
            this.middleInfoLabel.AutoSize = true;
            this.middleInfoLabel.ForeColor = System.Drawing.Color.Yellow;
            this.middleInfoLabel.Location = new System.Drawing.Point(137, 36);
            this.middleInfoLabel.Name = "middleInfoLabel";
            this.middleInfoLabel.Size = new System.Drawing.Size(149, 21);
            this.middleInfoLabel.TabIndex = 14;
            this.middleInfoLabel.Text = "Change Account";
            // 
            // endInfoLabel
            // 
            this.endInfoLabel.AutoSize = true;
            this.endInfoLabel.Location = new System.Drawing.Point(285, 36);
            this.endInfoLabel.Name = "endInfoLabel";
            this.endInfoLabel.Size = new System.Drawing.Size(196, 21);
            this.endInfoLabel.TabIndex = 15;
            this.endInfoLabel.Text = "button to change data";
            // 
            // phoneTextControl
            // 
            this.phoneTextControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.phoneTextControl.CharForPassword = '\0';
            this.phoneTextControl.ErrorLabelText = "";
            this.phoneTextControl.ErrorType = MyProjectLibrary.Enums.ErrorMessageType.Warning;
            this.phoneTextControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phoneTextControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.phoneTextControl.InputText = "";
            this.phoneTextControl.Location = new System.Drawing.Point(13, 255);
            this.phoneTextControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneTextControl.Name = "phoneTextControl";
            this.phoneTextControl.NameLabelText = "Phone Number";
            this.phoneTextControl.Size = new System.Drawing.Size(482, 48);
            this.phoneTextControl.TabIndex = 10;
            this.phoneTextControl.TextBoxLocation = new System.Drawing.Point(135, 6);
            this.phoneTextControl.TextBoxSize = new System.Drawing.Size(330, 19);
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
            this.emailTextControl.Location = new System.Drawing.Point(13, 197);
            this.emailTextControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTextControl.Name = "emailTextControl";
            this.emailTextControl.NameLabelText = "Email";
            this.emailTextControl.Size = new System.Drawing.Size(482, 48);
            this.emailTextControl.TabIndex = 9;
            this.emailTextControl.TextBoxLocation = new System.Drawing.Point(135, 6);
            this.emailTextControl.TextBoxSize = new System.Drawing.Size(330, 19);
            // 
            // lastNameTextControl
            // 
            this.lastNameTextControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.lastNameTextControl.CharForPassword = '\0';
            this.lastNameTextControl.ErrorLabelText = "";
            this.lastNameTextControl.ErrorType = MyProjectLibrary.Enums.ErrorMessageType.Warning;
            this.lastNameTextControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameTextControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lastNameTextControl.InputText = "";
            this.lastNameTextControl.Location = new System.Drawing.Point(13, 139);
            this.lastNameTextControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastNameTextControl.Name = "lastNameTextControl";
            this.lastNameTextControl.NameLabelText = "Last Name";
            this.lastNameTextControl.Size = new System.Drawing.Size(482, 48);
            this.lastNameTextControl.TabIndex = 8;
            this.lastNameTextControl.TextBoxLocation = new System.Drawing.Point(135, 6);
            this.lastNameTextControl.TextBoxSize = new System.Drawing.Size(330, 19);
            // 
            // firstNameTextControl
            // 
            this.firstNameTextControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.firstNameTextControl.CharForPassword = '\0';
            this.firstNameTextControl.ErrorLabelText = "";
            this.firstNameTextControl.ErrorType = MyProjectLibrary.Enums.ErrorMessageType.Warning;
            this.firstNameTextControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameTextControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.firstNameTextControl.InputText = "";
            this.firstNameTextControl.Location = new System.Drawing.Point(13, 81);
            this.firstNameTextControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstNameTextControl.Name = "firstNameTextControl";
            this.firstNameTextControl.NameLabelText = "First Name";
            this.firstNameTextControl.Size = new System.Drawing.Size(482, 48);
            this.firstNameTextControl.TabIndex = 7;
            this.firstNameTextControl.TextBoxLocation = new System.Drawing.Point(135, 6);
            this.firstNameTextControl.TextBoxSize = new System.Drawing.Size(330, 19);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.backButton.ForeColorOnMouseEnter = System.Drawing.Color.Yellow;
            this.backButton.Location = new System.Drawing.Point(328, 311);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(153, 57);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // changeApplayButton
            // 
            this.changeApplayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.changeApplayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changeApplayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.changeApplayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeApplayButton.ForeColor = System.Drawing.Color.Yellow;
            this.changeApplayButton.ForeColorOnMouseEnter = System.Drawing.Color.GreenYellow;
            this.changeApplayButton.Location = new System.Drawing.Point(13, 311);
            this.changeApplayButton.Name = "changeApplayButton";
            this.changeApplayButton.Size = new System.Drawing.Size(153, 57);
            this.changeApplayButton.TabIndex = 4;
            this.changeApplayButton.Text = "Change Account";
            this.changeApplayButton.UseVisualStyleBackColor = false;
            this.changeApplayButton.Click += new System.EventHandler(this.changeApplayButton_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(502, 384);
            this.Controls.Add(this.endInfoLabel);
            this.Controls.Add(this.middleInfoLabel);
            this.Controls.Add(this.downInfoLabel);
            this.Controls.Add(this.topInfoLabel);
            this.Controls.Add(this.xButton);
            this.Controls.Add(this.phoneTextControl);
            this.Controls.Add(this.emailTextControl);
            this.Controls.Add(this.lastNameTextControl);
            this.Controls.Add(this.firstNameTextControl);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.changeApplayButton);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomForms.RegularButton changeApplayButton;
        private CustomForms.RegularButton backButton;
        private CustomForms.InputTextControl firstNameTextControl;
        private CustomForms.InputTextControl lastNameTextControl;
        private CustomForms.InputTextControl emailTextControl;
        private CustomForms.InputTextControl phoneTextControl;
        private System.Windows.Forms.Button xButton;
        private System.Windows.Forms.Label topInfoLabel;
        private System.Windows.Forms.Label downInfoLabel;
        private System.Windows.Forms.Label middleInfoLabel;
        private System.Windows.Forms.Label endInfoLabel;
    }
}