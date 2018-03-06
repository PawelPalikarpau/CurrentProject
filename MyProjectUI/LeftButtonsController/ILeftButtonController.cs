
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProjectUI.LeftButtonsController
{
    public interface ILeftButtonController
    {
        void GeneratePanelView(Button clickedButton, Panel buttonsPanel, Panel increasedPanel, Form form);
    }
}
