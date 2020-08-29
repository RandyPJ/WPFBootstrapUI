using System.Windows;
using System.Windows.Controls;

namespace WPFBootstrapUI.Controls
{
    public class Jumbotron : ContentControl
    {
        static Jumbotron()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Jumbotron), new FrameworkPropertyMetadata(typeof(Jumbotron)));
        }

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(Jumbotron), new PropertyMetadata(new CornerRadius(0,0,0,0)));

    }
}
