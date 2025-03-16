using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace lab2;

public partial class MainWindow : Window
{
    public double cena_dysku = 0;
    public double cena_procesora = 0;
    public double cena_monitora = 0;
    public double cena_komputera = 0;
    
    private Komputer kp;
    private Monitor mt;
    public MainWindow() {
        InitializeComponent();
    }

    public void dodanie_do_ceny(double cena) {
        cena_komputera += cena;
    }
    
    public void klik(object sender, RoutedEventArgs args)
    {
        cena.InnerRightContent = "0";
        if (sender is Button button) {
            if (button.Content.ToString() == "Komputer")
            {
                kp = new Komputer(this);
                kp.Show();
            }
            else if (button.Content.ToString() == "Monitor") {
                mt = new Monitor(this);
                mt.Show();
            }
        }
    }
}