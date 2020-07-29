using FundRiser.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FundRiser.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EntryPage : ContentPage
	{
		public EntryPage ()
		{
			InitializeComponent ();
			BindingContext = new EntryPageViewModel();
		}
	}
}
