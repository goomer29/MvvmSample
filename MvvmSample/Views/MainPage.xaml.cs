using MvvmSample.ViewModels;

namespace MvvmSample;

public partial class MainPage : ContentPage
{
   

    public MainPage(MainPageViewModel m)
	{
	
		InitializeComponent();
		this.BindingContext = m;

	}

	
}

