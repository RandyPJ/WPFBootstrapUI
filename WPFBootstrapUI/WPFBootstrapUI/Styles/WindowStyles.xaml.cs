using System.Windows;
using System.Windows.Controls;
using WPFBootstrapUI;


namespace WPFBootstrapUI.Styles
{
    public partial class WindowStyles : ResourceDictionary
    {
        public WindowStyles()
        {
            InitializeComponent();
        }

        private void OnClose(object sender, RoutedEventArgs e)
        {
            var window = (Window)((FrameworkElement)sender).TemplatedParent;
            window.Close();
        }

        private void OnMinimize(object sender, RoutedEventArgs e)
        {
            var window = (Window)((FrameworkElement)sender).TemplatedParent;
            if (window.WindowState == WindowState.Normal || window.WindowState == WindowState.Maximized)
                window.WindowState = WindowState.Minimized;
        }

        private void OnRestoreMaximize(object sender, RoutedEventArgs e)
        {
            var window = (Window)((FrameworkElement)sender).TemplatedParent;

            if (window.WindowState == WindowState.Normal)
                window.WindowState = WindowState.Maximized;
            else if (window.WindowState == WindowState.Maximized)
                window.WindowState = WindowState.Normal;
        }
    }
}