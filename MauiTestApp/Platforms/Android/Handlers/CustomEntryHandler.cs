using Android.Widget;
using MauiTestApp.Controls;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

// ReSharper disable once CheckNamespace
namespace MauiTestApp.Handlers;

public partial class CustomEntryHandler : ViewHandler<ICustomEntry, EditText>
{
    public static PropertyMapper<ICustomEntry, CustomEntryHandler> CustomEntryMapper = 
        new PropertyMapper<ICustomEntry, CustomEntryHandler>(ViewMapper)
    {
        [nameof(ICustomEntry.Text)] = MapText,
        [nameof(ICustomEntry.TextColor)] = MapTextColor,
    };

    public CustomEntryHandler() 
        : base(CustomEntryMapper)
    {
    }

    protected override EditText CreatePlatformView()
    {
        return new EditText(Context);
    }

    private static void MapText(CustomEntryHandler handler, ICustomEntry entry)
    {
        handler.PlatformView.Text = entry.Text;
    }

    private static void MapTextColor(CustomEntryHandler handler, ICustomEntry entry)
    {
        handler.PlatformView.SetTextColor(entry.TextColor.ToPlatform());
    }
}