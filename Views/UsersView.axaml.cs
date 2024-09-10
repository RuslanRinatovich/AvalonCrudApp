
using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CRUDApp.Entities;


namespace CRUDApp.Views;

public partial class UsersView : UserControl
{
    public List<User> Users { get; set; }
    TradeContext context;
    public UsersView()
    {
        this.InitializeComponent();
        context = new TradeContext();
        Users = context.Users.ToList();
        DataContext = this;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void AddButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        App.MainWindow.MainContentControl.Content = new UserEditView(new User());
    }

    private void EditButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var UsersListBox = this.FindControl<ListBox>("UsersListBox");
        if(UsersListBox.SelectedItem is User user)
        {
            App.MainWindow.MainContentControl.Content = new UserEditView(user);
        }
    }

    private void RemoveButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var UsersListBox = this.FindControl<ListBox>("UsersListBox");
        if (UsersListBox.SelectedItem is User user)
        {
                context.Users.Remove(user);
                context.SaveChanges();
                App.MainWindow.MainContentControl.Content = new UsersView();
        }
    }

}