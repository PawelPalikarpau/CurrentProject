namespace MyProjectUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.xButton.Location = new System.Drawing.Point(766, 43);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(28, 27);
            this.xButton.TabIndex = 6;
            this.xButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(970, 795);
            this.Controls.Add(this.xButton);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button xButton;
    }
}