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
            this.inputTextControl1 = new MyProjectUI.CustomForms.InputTextControl();
            this.SuspendLayout();
            // 
            // inputTextControl1
            // 
            this.inputTextControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.inputTextControl1.ErrorLabelText = "Must be filled";
            this.inputTextControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputTextControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.inputTextControl1.Location = new System.Drawing.Point(410, 136);
            this.inputTextControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputTextControl1.Name = "inputTextControl1";
            this.inputTextControl1.NameLabelText = "Email";
            this.inputTextControl1.Size = new System.Drawing.Size(413, 51);
            this.inputTextControl1.TabIndex = 0;
            this.inputTextControl1.TextBoxLocation = new System.Drawing.Point(192, 6);
            this.inputTextControl1.TextBoxSize = new System.Drawing.Size(203, 19);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(968, 795);
            this.Controls.Add(this.inputTextControl1);
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

        private CustomForms.InputTextControl inputTextControl1;
    }
}