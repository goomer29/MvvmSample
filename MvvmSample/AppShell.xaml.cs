using MvvmSample.Views;

namespace MvvmSample;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("DetailsPage", typeof(StudentDetails));
	}
}
