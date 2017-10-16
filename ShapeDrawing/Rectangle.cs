using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShapeDrawing;

class Rectangle : Shape
{
    private int x;
	private int y;
	private int width;
	private int height;

    public Rectangle(int x, int y, int width, int height, Color color)
    {
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
        this.color = color;
    }
    
	public override void Draw()
    {
		drawer.DrawLine(color,x,y,x + width,y);
		drawer.DrawLine(color,x+width,y,x+width,y+height);
		drawer.DrawLine(color,x+width,y+height,x,y+height);
		drawer.DrawLine(color, x,y+height,x,y);
    }
}

