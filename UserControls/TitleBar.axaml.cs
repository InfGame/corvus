using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;

namespace Corvus.UserControls
{
    public partial class TitleBar : UserControl
    {
        Window ParentWindow;
        /* Assets */
        private string FullScreenSvg = "/Assets/Icons/WindowActions/FullScreen.svg";
        private string WindowedSvg = "/Assets/Icons/WindowActions/Windowed.svg";

        public TitleBar()
        {
            InitializeComponent();

            Loaded += OnLoaded;
        }

        private void OnLoaded(object? sender, RoutedEventArgs e)
        {
            if (TopLevel.GetTopLevel(this) is Window window && window != null)
            {
                ParentWindow = window;
                ParentWindow.PropertyChanged += OnParentWindowPropertyChanged;
            }
        }

        private void OnParentWindowPropertyChanged(object? sender, Avalonia.AvaloniaPropertyChangedEventArgs args)
        {
            if (args.Property == Window.WindowStateProperty) 
            {
                if (args.NewValue is WindowState newState && newState == WindowState.FullScreen)
                {
                    WinFullSvg.Path = WindowedSvg;
                }
                else
                {
                    WinFullSvg.Path = FullScreenSvg;
                }
            }
        }
        /* Window Action */

        //Button Click Event
        protected virtual void OnWindowActionPress(object? sender, RoutedEventArgs args)
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "CloseButton":
                        ParentWindow.Close();
                        break;
                    case "MinButton":
                        ParentWindow.WindowState = WindowState.Minimized;
                        break;
                    case "WinFullButton":
                        ParentWindow.WindowState = ParentWindow.WindowState == WindowState.FullScreen ? WindowState.Normal : WindowState.FullScreen;
                        break;
                        
                }
            }
        }
    }
}