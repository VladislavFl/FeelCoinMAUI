using FeelCoin.ViewModel;

namespace FeelCoin.Views;

public partial class UserPage : ContentPage
{
	public UserPage(UserViewModel userViewModel)
	{
		InitializeComponent();
        BindingContext = userViewModel;
    }
}