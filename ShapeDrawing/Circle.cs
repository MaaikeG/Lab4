using System.Drawing;

class Circle : Shape
{
    private int x;
	private int y;
	private int diameter;

    public Circle(int x, int y, int diameter, Color color)
    {
		this.x = x;
		this.y = y;
		this.diameter = diameter;
        this.color = color;
    }

    public override void Draw()
    {
        drawer.DrawEllipse(color, this.x, this.y, this.diameter);
    }

}
