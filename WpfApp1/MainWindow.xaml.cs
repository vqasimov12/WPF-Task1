using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApp1;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btn1_Click(object sender, RoutedEventArgs e)
    {
        ChangeColor(sender);
    }

    private void btn2_Click(object sender, RoutedEventArgs e)
    {
        ChangeColor(sender);
    }

    private void btn3_Click(object sender, RoutedEventArgs e)
    {
        ChangeColor(sender);
    }

    private void btn4_Click(object sender, RoutedEventArgs e)
    {
        ChangeColor(sender);
    }

    private void btn5_Click(object sender, RoutedEventArgs e)
    {
        ChangeColor(sender);
    }

    private void btn6_Click(object sender, RoutedEventArgs e)
    {
        ChangeColor(sender);
    }

    private void btn1_Letf(object sender, MouseButtonEventArgs e)
    {
        Button? button = sender as Button;
        button!.Visibility = Visibility.Collapsed; ;
        Title = "1";
    }
    private void btn2_Letf(object sender, MouseButtonEventArgs e)
    {
        Button? button = sender as Button;
        button!.Visibility = Visibility.Collapsed;
        Title = "2";
    }

    private void btn3_Letf(object sender, MouseButtonEventArgs e)
    {
        Button? button = sender as Button;
        button!.Visibility = Visibility.Collapsed; ;
        Title = "3";
    }

    private void btn4_Letf(object sender, MouseButtonEventArgs e)
    {
        Button? button = sender as Button;
        button!.Visibility = Visibility.Collapsed; ;
        Title = "4";
    }

    private void btn5_Letf(object sender, MouseButtonEventArgs e)
    {
        Button? button = sender as Button;
        button!.Visibility = Visibility.Collapsed; ;
        Title = "5";
    }

    private void btn6_Letf(object sender, MouseButtonEventArgs e)
    {
        Button? button = sender as Button;
        button!.Visibility = Visibility.Collapsed; ;
        Title = "6";
    }
    void ChangeColor(object sender)
    {
        int a = Random.Shared.Next(255);
        int b = Random.Shared.Next(255);
        int c = Random.Shared.Next(255);
        Button? button = sender as Button;
        button!.Background = new SolidColorBrush(Color.FromRgb((byte)a, (byte)b, (byte)c));

    }
}
