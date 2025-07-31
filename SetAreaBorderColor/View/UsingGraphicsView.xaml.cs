namespace SetAreaBorderColor;

public partial class UsingGraphicsView : ContentPage
{
	public UsingGraphicsView()
	{
		InitializeComponent();
	}
}


public class CustomBorderDrawable : IDrawable
{
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.StrokeColor = Colors.DarkSeaGreen;
        canvas.StrokeSize = 5;
        canvas.DrawRectangle(dirtyRect);
    }
}
