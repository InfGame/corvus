using CommunityToolkit.Mvvm.ComponentModel;

namespace Corvus.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    public partial string Greeting { get; set; } = "Welcome to Corvus!";
}
