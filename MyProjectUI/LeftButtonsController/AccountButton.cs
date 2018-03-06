using MyProjectUI.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectUI.LeftButtonsController
{
    public class AccountButton : ILeftButtonController
    {
        private MainForm mainForm;
        private Button clickedButton;
        private Panel buttonsPanel;
        private Panel increasedPanel;

        public void GeneratePanelView(Button clickedButton, Panel buttonsPanel, Panel increasedPanel, Form form)
        {
            this.mainForm = null;
            this.clickedButton = null;
            this.buttonsPanel = null;
            this.increasedPanel = null;
            increasedPanel.Controls.Clear();
            increasedPanel.Refresh();

            this.mainForm = form as MainForm;
            this.clickedButton = clickedButton;
            this.buttonsPanel = buttonsPanel;
            this.increasedPanel = increasedPanel;
            SetLocations();
            CreateLables();
        }

        private void SetLocations()
        {
            buttonsPanel.Top = clickedButton.Top;
            increasedPanel.Top = buttonsPanel.Top;
            increasedPanel.AutoSize = true;
            increasedPanel.AutoSizeMode = AutoSizeMode.GrowOnly;

            increasedPanel.Visible = true;
        }

        private void CreateLables()
        {
            Label changeAccountLabel = new Label();
            changeAccountLabel.Name = "changeAccountLabel";
            Point changeAccountLabelPoint = new Point(30, 5);
            changeAccountLabel.Location = changeAccountLabelPoint;
            changeAccountLabel.AutoSize = true;
            changeAccountLabel.Text = "Change Account";
            changeAccountLabel.ForeColor = Color.FromArgb(60, 120, 138);
            changeAccountLabel.Click += new EventHandler(ChangeAccountLabel_Click);
            increasedPanel.Controls.Add(changeAccountLabel);

            Label changePhotoLabel = new Label();
            changePhotoLabel.Name = "changePhotoLabel";
            Point changePhotoLabelPoint = new Point(30, 30);
            changePhotoLabel.Location = changePhotoLabelPoint;
            changePhotoLabel.AutoSize = true;
            changePhotoLabel.Text = "Change Photo";
            changePhotoLabel.ForeColor = Color.FromArgb(60, 120, 138);
            changePhotoLabel.Click += new EventHandler(ChangePhotoLabel_Click);
            increasedPanel.Controls.Add(changePhotoLabel);

            Graphics g = increasedPanel.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.FromArgb(60, 120, 138));
            g.FillEllipse(brush, new Rectangle(changeAccountLabelPoint.X - 15, changeAccountLabelPoint.Y + 5, 10, 10));
            g.FillEllipse(brush, new Rectangle(changePhotoLabelPoint.X - 15, changePhotoLabelPoint.Y + 5, 10, 10));
            brush.Dispose();
            g.Dispose();
        }

        private void ChangeAccountLabel_Click(object sender, EventArgs e)
        {
            mainForm.Enabled = false;
            IAccountForm accountForm = new AccountForm();
            accountForm.InitializeForm(mainForm.AccountModel, mainForm, mainForm.Name);
        }

        private void ChangePhotoLabel_Click(object sender, EventArgs e)
        {
            mainForm.Enabled = false;
            IAccountPhotoForm accountPhotoForm = new AccountPhotoForm();
            accountPhotoForm.InitializeForm(mainForm.AccountModel, mainForm);
        }
    }
}
