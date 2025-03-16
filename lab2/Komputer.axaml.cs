using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using SkiaSharp;

namespace lab2;

public partial class Komputer : Window {
    
    MainWindow main_window;

    private double procesor = 0;
    private double dysk = 0;
    
    public Komputer(MainWindow okno) {
        InitializeComponent();
        main_window = okno;
    }

    private void wybor_procesora(object sender, RoutedEventArgs args)
    {
        if (procesory.SelectedItem is ComboBoxItem item)
        {
            if (item.Content is StackPanel panel)
            {
                if (panel.Children[0] is TextBlock text)
                {
                    procesor = Convert.ToDouble(text.Tag);
                }
            }
        }
    }
    
    private void wybor_dysku(object sender, RoutedEventArgs args)
    {
        if (dyski.SelectedItem is ListBoxItem item)
        {
            if (item.Content is StackPanel panel)
            {
                if (panel.Children[0] is TextBlock text)
                {
                    dysk = Convert.ToDouble(text.Tag);
                }
            }
        }
    }
    
    public void klik(object sender, RoutedEventArgs args) {
        if (sender is Button button) {
            if (button.Content.ToString() == "OK") {
                main_window.cena_procesora = procesor;
                main_window.cena_dysku = dysk;
                this.Hide();
                main_window.cena_komputera = main_window.cena_procesora + main_window.cena_dysku + main_window.cena_monitora;
                main_window.cena.InnerRightContent = main_window.cena_komputera;
            }
            else if (button.Content.ToString() == "anuluj") {
                this.Hide();
            }
        }
    }
}