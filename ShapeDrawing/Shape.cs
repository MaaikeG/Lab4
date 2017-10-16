using ShapeDrawing;

public abstract class Shape
{
    protected IDrawer drawer;

	public Shape()
	{
	}

    public abstract void Draw();

    public void SetDrawer(IDrawer drawer)
    {
        this.drawer = drawer;
    }
}