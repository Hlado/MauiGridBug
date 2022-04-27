using Microsoft.Maui.Controls.Shapes;

namespace MauiIssue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		ContentView o;

		for (int i = 0; i < 59; ++i)
        {
			o = new ContentView() { Background = new SolidColorBrush(Colors.Green), Content = new Label() };
			//Label o = new Label() { Background = new SolidColorBrush(Colors.Green) };

			Grid.SetRow(o, i / 10);
			Grid.SetColumn(o, i % 10);

			grid.Add(o);
        }
	}
}

