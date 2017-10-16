using System.Drawing;
using System.IO;
using ShapeDrawing;

internal class SvgDrawer : IDrawer
{
    private StreamWriter writer;

    public SvgDrawer(StreamWriter writer)
    {
        this.writer = writer;
    }

    public void DrawEllipse(Color color, int x, int y, int diameter)
    {
        writer.WriteLine(string.Format(
            "<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\" stroke-width=\"1\" fill=\"none\" stroke=\"{3}\" />"
            , x + diameter / 2
            , y + diameter / 2
            , diameter / 2
            , color.Name)
        );
    }

    public void DrawLine(Color color, int x1, int y1, int x2, int y2)
    {
        writer.WriteLine(string.Format(
            "<polyline points=\"{0},{1} {2},{3}\" style=\"fill:none;stroke:{4};stroke-width:1\" />"
            , x1
            , y1
            , x2
            , y2
            , color.Name)
        );

    }
}