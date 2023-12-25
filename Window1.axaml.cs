using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GabrielList;

public partial class Window1 : Window
{
    public Window1()
    {
        InitializeComponent();
        
    }

    public void Texts(string a, string b)
    {
        name.Text = a;
        date.Text = b;
    }
}