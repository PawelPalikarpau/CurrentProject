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

namespace MyProjectUI.Forms
{
    public partial class AccountPhotoForm : Form, IAccountPhotoForm
    {
        private MainForm mainForm;

        public AccountModel AccountModel { get; set; }

        public AccountPhotoForm()
        {
            InitializeComponent();
        }

        private void InitializeStartData(AccountModel accountModel, Form form)
        {

            this.mainForm = form as MainForm;
            AccountModel = accountModel;
            xButton.Location = new Point(Location.X + Size.Width - xButton.Size.Width, Location.Y);
        }

        public void InitializeForm(AccountModel accountModel, Form form)
        {
            throw new NotImplementedException();
        }

        private void xButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
