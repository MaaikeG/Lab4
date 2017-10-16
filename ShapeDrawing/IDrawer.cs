using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace ShapeDrawing
{
    public interface IDrawer
    {
        void DrawLine(Color color, int x1, int y1, int x2, int y2);

        void DrawEllipse(Color color, int x, int y, int diameter);
    }
}
