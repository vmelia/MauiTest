using MauiTestApp.Controls;
using Microsoft.Maui.Platform;

namespace MauiTestApp;

public partial class App
{
    public App()
    {
        InitializeComponent();

//        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry),
//            (handler, view) =>
//            {
//                if (view is BorderlessEntry)
//                {
//#if __ANDROID__
//                    handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());
//#elif __IOS__
//                    handler.PlatformView.BackgroundColor = Colors.Transparent.ToPlatform();
//                    handler.PlatformView.Layer.BackgroundColor = Colors.Transparent.ToCGColor();
//                    handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;

//#endif
//                }
//            });

        MainPage = new AppShell();
    }
}