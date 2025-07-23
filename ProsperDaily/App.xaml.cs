using ProsperDaily.MVVM.Models;
using ProsperDaily.MVVM.Views;
using ProsperDailyTests.Repositories;

namespace ProsperDaily
{
    public partial class App : Application
    {
        public static BaseRepository<Transaction>
            TransactionsRepo { get; private set; }
        public App(BaseRepository<Transaction> _transactionsRepo)
        {
            InitializeComponent();
            TransactionsRepo = _transactionsRepo;
            MainPage = new NavigationPage(new DashboardPage());
        }

        //protected override Window CreateWindow(IActivationState? activationState)
        //{
        //    return new Window(new DashboardPage());
        //}
    }
}