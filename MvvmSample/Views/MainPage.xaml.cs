using MvvmSample.ViewModels;

namespace MvvmSample;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
	
		InitializeComponent();
		this.BindingContext = new MainPageViewModel();

	}

	
}

