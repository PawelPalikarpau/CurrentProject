namespace MyProjectUI.Forms
{
    partial class AccountPhotoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountPhotoForm));
            this.xButton = new System.Windows.Forms.Button();
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
            this.xButton.Location = new System.Drawing.Point(433, 12);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(28, 27);
            this.xButton.TabIndex = 12;
            this.xButton.UseVisualStyleBackColor = false;
            this.xButton.Click += new System.EventHandler(this.xButton_Click);
            // 
            // AccountPhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(473, 422);
            this.Controls.Add(this.xButton);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AccountPhotoForm";
            this.Text = "AccountPhotoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button xButton;
    }
}