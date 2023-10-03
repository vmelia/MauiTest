using MauiTest.ViewModels;

namespace MauiTestApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        for (var i = 1; i < 16; i++)
        {
            NumberOfPeople.Items.Add(i.ToString());
        }

        NumberOfPeople.SelectedIndex = 0;
    }

    private MainViewModel ViewModel => BindingContext as MainViewModel;

    private void NumberOfPeople_SelectedIndexChanged(object sender, EventArgs _)
    {
        var picker = (Picker)sender;
        var selectedIndex = picker.SelectedIndex;

        if (selectedIndex != -1)
        {
            ViewModel.NumPeople = selectedIndex + 1;
        }
    }
}