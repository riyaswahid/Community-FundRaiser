using FundRiser.Models;
using FundRiser.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FundRiser.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TaskDetail : ContentPage
	{
		public TaskDetail (TodoItem item = null)
		{
			InitializeComponent ();
			BindingContext = new TaskDetailViewModel(item);
		}
	}
}
