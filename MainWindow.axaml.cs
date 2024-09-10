using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CRUDApp.Views;


namespace CRUDApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        App.MainWindow = this;
        App.MainWindow.MainContentControl.Content = new UsersView();
    }

  
}