using MyProjectUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectUI.LeftButtonsController
{
    public class CategoriesButton : ILeftButtonController
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
        }

        private void SetLocations()
        {
            buttonsPanel.Top = clickedButton.Top;
            increasedPanel.Top = buttonsPanel.Top;
            increasedPanel.AutoSize = true;
            increasedPanel.AutoSizeMode = AutoSizeMode.GrowOnly;

            increasedPanel.Visible = true;
        }
    }
}
