using MvvmSample.ViewModels;

namespace MvvmSample.Views;

public partial class TeacherPage : ContentPage
{
	public TeacherPage(TeacherPageViewModel vm)
	{
		InitializeComponent();
		BindingContext=vm;	
	}
}