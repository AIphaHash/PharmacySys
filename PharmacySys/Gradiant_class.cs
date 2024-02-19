using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacySys
{
    public class Gradiant_class : Panel
    {
        public Color TopColor { get; set; }

        public Color BottomColor { get; set;}

        public float Angel { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.TopColor, this.BottomColor, this.Angel);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }



    }
}
