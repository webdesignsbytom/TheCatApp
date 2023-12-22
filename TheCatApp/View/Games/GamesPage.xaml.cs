using TheCatApp.ViewModel.Games;

namespace TheCatApp.View.Games;

public partial class GamesPage : ContentPage
{
	public GamesPageViewModel ViewModel { get; set; }
	public GamesPage(GamesPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = ViewModel = viewModel;
	}
}