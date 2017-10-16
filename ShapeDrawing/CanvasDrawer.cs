using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ShapeDrawing
{
    class CanvasDrawer : IDrawer
    {
        private Graphics graphics;

        public CanvasDrawer(Graphics gr)
        {
            this.graphics = gr;
        }

        void IDrawer.DrawEllipse(Color color, int x, int y, int diameter)
        {
            Pen pen = new Pen(color);
            graphics.DrawEllipse(pen, x, y, diameter, diameter);
        }

        void IDrawer.DrawLine(Color color, int x1, int y1, int x2, int y2)
        {
            Pen pen = new Pen(color);
            graphics.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
