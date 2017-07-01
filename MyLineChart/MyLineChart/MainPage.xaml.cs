using OxyPlot;
using OxyPlot.Series;
using Xamarin.Forms;

namespace MyLineChart
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var model = new PlotModel { Title = "OxyPlot Test." };

            var X_line = new LineSeries();
            X_line.Color = OxyColors.Red;
            X_line.Points.Add(new DataPoint(0, 0));
            X_line.Points.Add(new DataPoint(1, 4));
            X_line.Points.Add(new DataPoint(2, 1));
            X_line.Points.Add(new DataPoint(3, 3));
            model.Series.Add(X_line);

            var Y_line = new LineSeries();
            Y_line.Color = OxyColors.Blue;
            Y_line.Points.Add(new DataPoint(0, 0));
            Y_line.Points.Add(new DataPoint(1, 2));
            Y_line.Points.Add(new DataPoint(2, 0));
            Y_line.Points.Add(new DataPoint(3, 6));
            model.Series.Add(Y_line);

            PlotView.BackgroundColor = Color.LightBlue;
            PlotView.HeightRequest = 300;
            PlotView.WidthRequest = 300;
            PlotView.Model = model;
        }
    }
}
