using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CRUDApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUDApp.Views;

public partial class UserEditView : UserControl
{
    public User User { get; set; }
    TradeContext context;
    public UserEditView(User user)
    {
        InitializeComponent();

        User = user;
        context = new TradeContext();
        DataContext = this;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    private void SaveButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (User.Username is null)
            context.Users.Add(User);
        else
            context.Entry(User).State = EntityState.Modified;
            context.SaveChanges();
            App.MainWindow.MainContentControl.Content = new UsersView();
    }

    private void CancelButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        App.MainWindow.MainContentControl.Content = new UsersView();
    }
}