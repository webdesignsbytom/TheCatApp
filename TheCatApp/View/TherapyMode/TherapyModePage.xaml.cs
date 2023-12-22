using TheCatApp.ViewModel.TherapyMode;

namespace TheCatApp.View.TherapyMode;

public partial class TherapyModePage : ContentPage
{
	public TherapyModeViewModel ViewModel { get; set; }
	public TherapyModePage(TherapyModeViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = ViewModel = viewModel;
	}

}