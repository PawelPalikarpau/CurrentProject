using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace MyProjectUI.CustomForms
{
    public partial class RegularButton : Button
    {
        private Color defaultForeColor = Color.FromArgb(62, 120, 138);
        private Color defaultBackColor = Color.FromArgb(41, 44, 51);

        private Color redForeColor = Color.Red;
        private Color yellowForeColor = Color.Yellow;
        private Color greenForeCOlor = Color.Green;
        private Color foreColorOnMouseEnter = Color.Yellow;

        public RegularButton()
        {
            ForeColor = defaultForeColor;
            BackColor = defaultBackColor;
            ForeColorOnMouseEnter = yellowForeColor;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.MouseOverBackColor = defaultBackColor;
            FlatAppearance.MouseDownBackColor = defaultBackColor;
        }

        [Description("Change color on mouse enter trigger")]
        [Category("Appearance")]
        public virtual Color ForeColorOnMouseEnter
        {
            get
            {
                return this.foreColorOnMouseEnter;
            }
            set
            {
                defaultForeColor = ForeColor;
                this.foreColorOnMouseEnter = value;
            }
        }

        protected void onMouseEnter()
        {
            this.ForeColor = foreColorOnMouseEnter;
            this.Invalidate();
        }

        protected void NormalStyle()
        {
            this.ForeColor = defaultForeColor;
            this.Invalidate();
        }

        protected void onMouseDown()
        {
            ForeColor = greenForeCOlor;
            this.Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            onMouseEnter();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            NormalStyle();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            onMouseDown();
        }
    }
}
