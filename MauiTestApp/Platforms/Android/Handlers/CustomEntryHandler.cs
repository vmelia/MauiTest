using Android.Widget;
using MauiTestApp.Controls;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

// ReSharper disable once CheckNamespace
namespace MauiTestApp.Handlers;

public partial class CustomEntryHandler : ViewHandler<CustomEntry, EditText>
{
    public static PropertyMapper<CustomEntry, CustomEntryHandler> CustomEntryMapper = 
        new PropertyMapper<CustomEntry, CustomEntryHandler>(ViewMapper)
    {
        [nameof(CustomEntry.Text)] = MapText,
        [nameof(CustomEntry.TextColor)] = MapTextColor,
    };

    public CustomEntryHandler() 
        : base(CustomEntryMapper)
    {
    }

    protected override EditText CreatePlatformView()
    {
        return new EditText(Context);
    }

    private static void MapText(CustomEntryHandler handler, CustomEntry entry)
    {
        handler.PlatformView.Text = entry.Text;
    }

    private static void MapTextColor(CustomEntryHandler handler, CustomEntry entry)
    {
        handler.PlatformView.SetTextColor(entry.TextColor.ToPlatform());
    }
}