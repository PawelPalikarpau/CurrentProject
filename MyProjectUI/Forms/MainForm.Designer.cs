namespace MyProjectUI.Forms
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.productsButton = new System.Windows.Forms.Button();
            this.categoriesButton = new System.Windows.Forms.Button();
            this.accountButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoLabel = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.increasedButonsPanel = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
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
            this.xButton.Location = new System.Drawing.Point(874, 0);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(28, 27);
            this.xButton.TabIndex = 6;
            this.xButton.UseVisualStyleBackColor = false;
            this.xButton.Click += new System.EventHandler(this.xButton_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.productsButton);
            this.leftPanel.Controls.Add(this.categoriesButton);
            this.leftPanel.Controls.Add(this.accountButton);
            this.leftPanel.Controls.Add(this.logoPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(150, 686);
            this.leftPanel.TabIndex = 7;
            // 
            // productsButton
            // 
            this.productsButton.FlatAppearance.BorderSize = 0;
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButton.ForeColor = System.Drawing.Color.White;
            this.productsButton.Image = ((System.Drawing.Image)(resources.GetObject("productsButton.Image")));
            this.productsButton.Location = new System.Drawing.Point(0, 280);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(150, 75);
            this.productsButton.TabIndex = 3;
            this.productsButton.Text = "Products";
            this.productsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.productsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.productsButton.UseVisualStyleBackColor = true;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // categoriesButton
            // 
            this.categoriesButton.FlatAppearance.BorderSize = 0;
            this.categoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesButton.ForeColor = System.Drawing.Color.White;
            this.categoriesButton.Image = ((System.Drawing.Image)(resources.GetObject("categoriesButton.Image")));
            this.categoriesButton.Location = new System.Drawing.Point(0, 205);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Size = new System.Drawing.Size(150, 75);
            this.categoriesButton.TabIndex = 2;
            this.categoriesButton.Text = "Categories";
            this.categoriesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.categoriesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.categoriesButton.UseVisualStyleBackColor = true;
            this.categoriesButton.Click += new System.EventHandler(this.categoriesButton_Click);
            // 
            // accountButton
            // 
            this.accountButton.FlatAppearance.BorderSize = 0;
            this.accountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountButton.ForeColor = System.Drawing.Color.White;
            this.accountButton.Image = ((System.Drawing.Image)(resources.GetObject("accountButton.Image")));
            this.accountButton.Location = new System.Drawing.Point(0, 130);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(150, 75);
            this.accountButton.TabIndex = 1;
            this.accountButton.Text = "Account";
            this.accountButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.accountButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.accountButton.UseVisualStyleBackColor = true;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.logoPanel.Controls.Add(this.logoLabel);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(150, 103);
            this.logoPanel.TabIndex = 0;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Edwardian Script ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.logoLabel.Location = new System.Drawing.Point(16, 19);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(99, 57);
            this.logoLabel.TabIndex = 0;
            this.logoLabel.Text = "PP";
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.Yellow;
            this.buttonsPanel.Location = new System.Drawing.Point(150, 130);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(8, 75);
            this.buttonsPanel.TabIndex = 8;
            // 
            // increasedButonsPanel
            // 
            this.increasedButonsPanel.AutoSize = true;
            this.increasedButonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.increasedButonsPanel.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.increasedButonsPanel.Location = new System.Drawing.Point(158, 130);
            this.increasedButonsPanel.Name = "increasedButonsPanel";
            this.increasedButonsPanel.Size = new System.Drawing.Size(200, 100);
            this.increasedButonsPanel.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(903, 686);
            this.Controls.Add(this.increasedButonsPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.xButton);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.leftPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xButton;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button accountButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Button categoriesButton;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Panel increasedButonsPanel;
    }
}