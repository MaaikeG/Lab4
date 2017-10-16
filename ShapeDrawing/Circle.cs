using System.Drawing;

class Circle : Shape
{
    private int x;
	private int y;
	private int diameter;

    public Circle(int x, int y, int diameter)
    {
		this.x = x;
		this.y = y;
		this.diameter = diameter;
    }

    public override void Draw()
    {
        drawer.DrawEllipse(Color.Black, this.x, this.y, this.diameter);
    }

}
