using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProjectLibrary.Enums;

namespace MyProjectUI.CustomForms
{
    public partial class InputTextControl : UserControl
    {
        public ErrorMessageType errorType;
        private bool isVisibleErrorLine = false;
        private Color errorLineColor;

        [Category("Custom Configs")]
        public string NameLabelText
        {
            get { return this.nameLabel.Text; }
            set { this.nameLabel.Text = value; }
        }

        [Category("Custom Configs")]
        public string ErrorLabelText
        {
            get { return this.errorLabel.Text; }
            set { this.errorLabel.Text = value; }
        }

        [Category("Custom Configs")]
        public Point TextBoxLocation
        {
            get { return this.inputTextBox.Location; }
            set
            {
                this.inputTextBox.Location = value;
                this.errorLabel.Location = new Point(value.X, value.Y + 21);
            }
        }

        [Category("Custom Configs")]
        public Size TextBoxSize
        {
            get { return this.inputTextBox.Size; }
            set { this.inputTextBox.Size = value; }
        }

        public InputTextControl()
        {
            errorType = ErrorMessageType.OK;
            InitializeComponent();
            ConfigureErrorDisplay();
        }

        private void InputTextControl_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen penPath = new Pen(Color.FromArgb(60, 120, 138), 1);
            g.DrawLine(penPath, nameLabel.Left, nameLabel.Bottom, inputTextBox.Right, inputTextBox.Bottom);

            if (isVisibleErrorLine)
            {
                Pen penError = new Pen(errorLineColor, 2);
                g.DrawLine(penError, inputTextBox.Left, inputTextBox.Bottom, inputTextBox.Right, inputTextBox.Bottom);
            }
            g.Dispose();
        }

        private void ConfigureErrorDisplay()
        {
            errorLabel.Visible = false;
            if (errorType == ErrorMessageType.Error)
            {
                errorLineColor = Color.Red;
                errorLabel.Visible = true;
                isVisibleErrorLine = true;
            }
            else if (errorType == ErrorMessageType.Warning)
            {
                errorLineColor = Color.Yellow;
                errorLabel.Visible = false;
                isVisibleErrorLine = true;
            }
        }
    }
}
