using MyProjectLibrary;
using MyProjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProjectUI.LeftButtonsController;

namespace MyProjectUI.Forms
{
    public partial class MainForm : Form
    {
        private ILeftButtonController ButtonController { get; set; }

        public UserModel UserModel { get; set; }
        public AccountModel AccountModel { get; set; }

        public MainForm()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.Bounds.Size;
            xButton.Location = new Point(Location.X + Size.Width - xButton.Size.Width, Location.Y);
            leftPanel.Size = new Size(leftPanel.Size.Width, this.Size.Height);
            increasedButonsPanel.Visible = false;
            this.Show();
            if (UserModel == null) UserVarification();
        }

        private void UserVarification()
        {
            this.Enabled = false;
            ILoginForm loginForm = new LoginForm();
            loginForm.InitializeForm(this);
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            ButtonController = new AccountButton();
            ButtonController.GeneratePanelView(accountButton, buttonsPanel, increasedButonsPanel, this);
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            ButtonController = new CategoriesButton();
            ButtonController.GeneratePanelView(categoriesButton, buttonsPanel, increasedButonsPanel, this);
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            ButtonController = new ProductsButton();
            ButtonController.GeneratePanelView(productsButton, buttonsPanel, increasedButonsPanel, this);
        }
    }
}
