using TheCatApp.ViewModel.EndlessCats;

namespace TheCatApp.View.EndlessCats;

public partial class EndlessCatsPage : ContentPage
{
	public EndlessCatsViewModel ViewModel { get; set; }
    public EndlessCatsPage(EndlessCatsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = ViewModel = viewModel;
	}
}