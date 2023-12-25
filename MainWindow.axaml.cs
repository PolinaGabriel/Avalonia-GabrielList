using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Collections.Generic;

namespace GabrielList
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<int> days = new List<int>();
            List<int> months = new List<int>();
            List<int> years = new List<int>();
            Items(days, 1, 32);
            Items(months, 1, 13);
            Items(years, 1924, 2025);
            day.Items = days;
            month.Items = months;
            year.Items = years;
            send.Click += ShowWind;
        }

        void Items(List<int> list, int a, int b)
        {
            for (int i = a; i < b; i++)
            {
                list.Add(i);
            }
        }

        void ShowWind(object? sender, RoutedEventArgs e)
        {
            Window1 wind = new Window1();
            wind.Show();
            wind.Texts(firstName.Text + " " + lastName.Text, Convert.ToString(day.SelectedItem) + "." + Convert.ToString(month.SelectedItem) + "." + Convert.ToString(year.SelectedItem));
        }
    }
}