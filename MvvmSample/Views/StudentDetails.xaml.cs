using MvvmSample.ViewModels;

namespace MvvmSample.Views;

public partial class StudentDetails : ContentPage
{
	public StudentDetails(StudentDetailsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}