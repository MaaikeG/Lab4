using ShapeDrawing;
using System.Drawing;

public abstract class Shape
{
    protected IDrawer drawer;
    public Color color;

    public abstract void Draw();

    public void SetDrawer(IDrawer drawer)
    {
        this.drawer = drawer;
    }
}