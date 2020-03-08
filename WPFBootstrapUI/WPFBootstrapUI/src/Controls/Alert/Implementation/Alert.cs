using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;

namespace WPFBootstrapUI.src.Controls.Alert.Implementation
{
    public class Alert : ContentControl
    {
        static Alert()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Alert), new FrameworkPropertyMetadata(typeof(Alert)));
        }


        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(Alert), new PropertyMetadata(string.Empty));


        public static CornerRadius GetCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(CornerRadiusProperty, value);
        }

        // Using a DependencyProperty as the backing store for CornerRadius.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(Alert), new PropertyMetadata(new CornerRadius(2.0)));







        public Brush AlertForeground
        {
            get { return (Brush)GetValue(AlertForegroundProperty); }
            set { SetValue(AlertForegroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AlertForeground.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AlertForegroundProperty =
            DependencyProperty.Register("AlertForeground", typeof(Brush), typeof(Alert), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(0,0,0))));






    }
}
