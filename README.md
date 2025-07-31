## How to set area border color for .NET MAUI Cartesian Chart

In [.NET MAUI SfCartesianChart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts), the [PlotAreaBackgroundView ](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.ChartBase.html#Syncfusion_Maui_Toolkit_Charts_ChartBase_PlotAreaBackgroundView) property allows you to customize the visual appearance of the chart’s plot area. This includes setting a border color and adding custom graphics.

**Method 1: Using Border to Set Area Border Color**

**Step 1:** Initialize the [SfCartesianChart](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.SfCartesianChart.html) in .NET MAUI. For detailed steps, please refer to the [documentatin](https://help.syncfusion.com/maui-toolkit/cartesian-charts/getting-started).

**[XAML]**
```
<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>

    <chart:ColumnSeries ItemsSource="{Binding Data}"
                        Fill="DarkSeaGreen"
                        XBindingPath="Name" 
                        YBindingPath="Height">
    </chart:ColumnSeries>

</chart:SfCartesianChart>
```
**Step 2:** Use the [PlotAreaBackgroundView](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.ChartBase.html#Syncfusion_Maui_Toolkit_Charts_ChartBase_PlotAreaBackgroundView) with a `Border` element to define a simple, solid border around the chart’s plot area.

**[XAML]**
```
<chart:SfCartesianChart>

    <chart:SfCartesianChart.PlotAreaBackgroundView>
        <Border Stroke="PaleVioletRed" StrokeThickness="5"></Border>
    </chart:SfCartesianChart.PlotAreaBackgroundView>

    . . .

</chart:SfCartesianChart>
```
This approach is ideal for simple use cases where you want to visually separate the chart area using a colored border.

**Method 2: Using GraphicsView with Custom Drawable**

For more advanced visuals—such as dashed lines, gradients, or dynamic effects—you can use a `GraphicsView` with a custom `IDrawable`.

**Step 1:** Create a Custom Drawable.

**[C#]**
```
public class CustomBorderDrawable : IDrawable
{
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.StrokeColor = Colors.PaleVioletRed;
        canvas.StrokeSize = 10;
        canvas.DrawRectangle(dirtyRect);
    }
}
```
**Step 2:** Register Drawable in XAML Resources.

**[XAML]**
```
ContentPage.Resources>
    <model:CustomBorderDrawable x:Key="CustomDrawable" />
</ContentPage.Resources>
```
**Step 3:** Use `GraphicsView` in [PlotAreaBackgroundView](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.ChartBase.html#Syncfusion_Maui_Toolkit_Charts_ChartBase_PlotAreaBackgroundView).

**[XAML ]:**
```
<chart:SfCartesianChart>

    <chart:SfCartesianChart.PlotAreaBackgroundView>
        <GraphicsView Drawable="{StaticResource CustomDrawable}" />
    </chart:SfCartesianChart.PlotAreaBackgroundView>

    . . .

</chart:SfCartesianChart>
```
This method gives you full control over how the border is rendered, including custom shapes.
 
**Output**
 
 ![Chart_with_area_border_color.png](https://support.syncfusion.com/kb/agent/attachment/article/20750/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjQ0NTU2Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.CzijSulM9OzNm6pIIXQlZsR6eTWiWfnpz6sgjfZ74ek)

### Troubleshooting

**Path too long exception**

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

For more details, refer to the KB on [How to set area border color for .NET MAUI Cartesian Chart]()
