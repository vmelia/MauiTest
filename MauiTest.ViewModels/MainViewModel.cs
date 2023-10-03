using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiTest.ViewModels;

public partial class MainViewModel : ObservableObject
{
    // Bindings.
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Total))]
    [NotifyPropertyChangedFor(nameof(Tip))]
    [NotifyPropertyChangedFor(nameof(PersonalAmount))]
    private double _amount;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Total))]
    [NotifyPropertyChangedFor(nameof(Tip))]
    [NotifyPropertyChangedFor(nameof(PersonalAmount))]
    private double _tipRate = 10;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(PersonalAmount))]
    private double _numPeople = 1;

    public double Tip => RoundUp(Amount * (TipRate / 100.0));
    public double Total => RoundUp(Amount + Tip);
    public double PersonalAmount => RoundUp(Total / NumPeople);

    private static double RoundUp(double amount)
    {
        var d = (decimal)amount;
        d = Math.Ceiling(d * 100) / 100;

        return (double)d;
    }
}