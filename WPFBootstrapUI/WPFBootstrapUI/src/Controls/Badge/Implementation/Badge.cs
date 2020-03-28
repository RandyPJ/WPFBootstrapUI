using System.Windows;
using System.Windows.Controls;

namespace WPFBootstrapUI.src.Controls
{
    public class Badge : ContentControl
    {
        static Badge()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Badge), new FrameworkPropertyMetadata(typeof(Badge)));
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(Badge), new PropertyMetadata(string.Empty));


        public bool IsNotificationBadge
        {
            get { return (bool)GetValue(IsNotificationBadgeProperty); }
            set { SetValue(IsNotificationBadgeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsNotificationCounter.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsNotificationBadgeProperty =
            DependencyProperty.Register("IsNotificationBadge", typeof(bool), typeof(Badge), new PropertyMetadata(false));


        public object NotificationNumber
        {
            get { return (object)GetValue(NotificationNumberProperty); }
            set { SetValue(NotificationNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NotificationNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NotificationNumberProperty =
            DependencyProperty.Register("NotificationNumber", typeof(object), typeof(Badge), new PropertyMetadata(null));
    }
}
