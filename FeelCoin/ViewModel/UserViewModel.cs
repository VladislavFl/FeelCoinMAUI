using FeelCoin.Views;
using System.Windows.Input;

namespace FeelCoin.ViewModel
{
    public class UserViewModel : BindableObject
    {
        public ICommand? OnButtonClickCommand { get; }

        public UserViewModel()
        {
            OnButtonClickCommand = new Command(OnButtonClick);
        }

        private void OnButtonClick()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
