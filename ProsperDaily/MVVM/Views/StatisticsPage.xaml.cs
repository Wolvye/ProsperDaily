using ProsperDaily.MVVM.ViewModels;

namespace ProsperDaily.MVVM.Views;

public partial class StatisticsPage : ContentPage
{
	public StatisticsPage()
	{
		InitializeComponent();
		BindingContext = new StatsticsViewModel();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        var vm = (StatsticsViewModel)BindingContext;
        vm.GetTransactionsSummary();
        var count = vm.SpendingList?.Count ?? -1;
        System.Diagnostics.Debug.WriteLine($" SpendingList.Count = {count}");

    }
}