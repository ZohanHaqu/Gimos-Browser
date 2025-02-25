using System;
using System.Windows;
using System.Windows.Controls;

namespace GimosBrowser
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); // Restore this line to ensure XAML elements are recognized
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(AddressBar.Text))
            {
                Browser.Navigate(AddressBar.Text);
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (Browser.CanGoBack)
            {
                Browser.GoBack();
            }
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            if (Browser.CanGoForward)
            {
                Browser.GoForward();
            }
        }

        private void ReloadButton_Click(object sender, RoutedEventArgs e)
        {
            Browser.Refresh();
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

