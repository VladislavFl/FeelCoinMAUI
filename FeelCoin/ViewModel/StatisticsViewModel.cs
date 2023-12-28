using FeelCoin.Services.Interfaces;
using FeelCoin.Views;
using System.Windows.Input;

namespace FeelCoin.ViewModel
{
    public class StatisticsViewModel : BindableObject
    {
        public ICommand? OnButtonClickCommand { get; }
        private readonly IStatisticsService _statisticsService;

        public StatisticsViewModel(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
            OnButtonClickCommand = new Command(OnButtonClick);
        }

        private void OnButtonClick()
        {
            UserViewModel userViewModel = new UserViewModel();
            Application.Current.MainPage.Navigation.PushAsync(new UserPage(userViewModel));
        }

        public string Message => _statisticsService.GetMessage();
    }
}
