using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using SkiaSharp;

namespace lab2;

public partial class Monitor : Window
{
    MainWindow main_window;

    private double monitor;
    public Monitor(MainWindow okno)
    {
        InitializeComponent();
        main_window = okno;
    }
    
    private void wybor_monitora(object sender, RoutedEventArgs args)
    {
        if (dyski.SelectedItem is ListBoxItem item)
        {
            if (item.Content is StackPanel panel)
            {
                if (panel.Children[0] is TextBlock text)
                {
                    monitor = Convert.ToDouble(text.Tag);
                }
            }
        }
    }
    
    public void klik(object sender, RoutedEventArgs args) {
        if (sender is Button button) {
            if (button.Content.ToString() == "OK") {
                main_window.cena_monitora = monitor;
                main_window.cena.InnerRightContent = main_window.cena_komputera;
                this.Hide();
            }
            else if (button.Content.ToString() == "anuluj") {
                this.Hide();
            }
        }
    }
}