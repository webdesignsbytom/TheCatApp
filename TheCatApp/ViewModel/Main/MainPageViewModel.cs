using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace TheCatApp.ViewModel.Main
{
    public partial class MainPageViewModel : ObservableObject
    {
        [RelayCommand]
        public async Task NavigateToCotd()
        {
            await Shell.Current.GoToAsync("///CotdPage");
        }
    }
}
