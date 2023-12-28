using FeelCoin.ViewModel;

namespace FeelCoin
{
    public partial class MainPage : ContentPage
    {
        public MainPage(StatisticsViewModel statisticsViewModel)
        {
            InitializeComponent();
            BindingContext = statisticsViewModel;
        }
    }
}
