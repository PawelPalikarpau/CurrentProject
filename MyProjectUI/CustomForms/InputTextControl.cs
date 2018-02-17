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
        Color errorLineColor = Color.FromArgb(60, 120, 138);
        private ErrorMessageType errorType;

        [Category("Custom Configs")]
        public ErrorMessageType ErrorType
        {
            get { return errorType; }
            set { errorType = value; }
        }

        [Category("Custom Configs")]
        public string NameLabelText
        {
            get { return nameLabel.Text; }
            set { nameLabel.Text = value; }
        }

        [Category("Custom Configs")]
        public string ErrorLabelText
        {
            get { return errorLabel.Text; }
            set { errorLabel.Text = value; }
        }

        [Category("Custom Configs")]
        public Point TextBoxLocation
        {
            get { return inputTextBox.Location; }
            set
            {
                inputTextBox.Location = value;
                errorPanel.Location = new Point(value.X, 25);
                errorLabel.Location = new Point(value.X, errorLabel.Location.Y);
            }
        }

        [Category("Custom Configs")]
        public Size TextBoxSize
        {
            get { return inputTextBox.Size; }
            set
            {
                inputTextBox.Size = value;
                errorPanel.Size = new Size(value.Width, 1);
            }
        }

        [Category("Custom Configs")]
        public string InputText
        {
            get { return this.inputTextBox.Text; }
            set { this.inputTextBox.Text = value; }
        }

        [Category("Custom Configs")]
        public char CharForPassword
        {
            get { return inputTextBox.PasswordChar;  }
            set { inputTextBox.PasswordChar = value; }
        }

        public InputTextControl()
        {
            InitializeComponent();
            ConfigureErrorDisplay();
        }

        private void ConfigureErrorDisplay()
        {
            if (ErrorType == ErrorMessageType.Error)
            {
                errorPanel.BackColor = Color.Red;
                errorPanel.Visible = true;
                errorLabel.Visible = true;
            }
            else if (ErrorType == ErrorMessageType.Warning)
            {
                errorPanel.BackColor = Color.Yellow;
                errorPanel.Visible = true;
                errorLabel.Visible = false;
            }
            else if (ErrorType == ErrorMessageType.OK)
            {
                errorPanel.Visible = false;
                errorLabel.Visible = false;
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            ConfigureErrorDisplay();
        }

        private void InputTextControl_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Pen penPath = new Pen(Color.FromArgb(60, 120, 138), 1);

            Point startPointLabel = new Point(nameLabel.Left, nameLabel.Bottom);
            Point finishPointTextBox = new Point(inputTextBox.Right, inputTextBox.Bottom);

            gr.DrawLine(penPath, startPointLabel, finishPointTextBox);
            gr.Dispose();
        }
    }
}
