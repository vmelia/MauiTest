using MauiTest.ViewModels;
using NUnit.Framework;

namespace MauiTest.Tests.ViewModels;

[TestFixture]
public class MainViewModelTests
{
    private MainViewModel _mainViewModel = new MainViewModel();

    [SetUp]
    public void SetUp()
    {
        _mainViewModel = new MainViewModel();
    }

    [Test]
    public void ViewModel_WhenConstructed_UsesCorrectDefaults()
    {
        Assert.AreEqual(0.0, _mainViewModel.Amount);
        Assert.AreEqual(10.0, _mainViewModel.TipRate);
        Assert.AreEqual(1, _mainViewModel.NumPeople);
    }

    [Test]
    public void Amount_WhenSet_CalculatesCorrectTotals()
    {
        _mainViewModel.Amount = 100.00;

        Assert.AreEqual(10.0, _mainViewModel.Tip);
        Assert.AreEqual(110.0, _mainViewModel.Total);
        Assert.AreEqual(110.0, _mainViewModel.PersonalAmount);
    }
}