using FundRiser.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FundRiser.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TaskList : ContentPage
	{
		public TaskList ()
		{
			InitializeComponent ();
			BindingContext = new TaskListViewModel();
		}
	}
}
