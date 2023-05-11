using MvvmSample.ViewModels;

namespace MvvmSample;

public partial class App : Application
{
	public App(MainPage p)
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
