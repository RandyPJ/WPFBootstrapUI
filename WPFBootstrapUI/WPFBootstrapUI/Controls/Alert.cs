using System.Windows.Controls;
using System.Windows;
using System;
using System.Windows.Media;

namespace WPFBootstrapUI.Controls
{
    [TemplatePart(Name = "PART_DismissButton", Type = typeof(Button))]
    public class Alert : ContentControl
    {
        private const string _dismissButtonName = "PART_DismissButton";
        private Button DismissButton;

        static Alert()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Alert), new FrameworkPropertyMetadata(typeof(Alert)));
        }

        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(Alert), new PropertyMetadata(new CornerRadius(2.0)));
        public static readonly DependencyProperty IsAlertDismissibleProperty = DependencyProperty.Register("IsAlertDismissible", typeof(bool), typeof(Alert), new PropertyMetadata(false));
        public static readonly DependencyProperty AlertDismissButtonForegroundProperty = DependencyProperty.RegisterAttached("AlertDismissButtonForeground", typeof(Brush), typeof(Alert), new PropertyMetadata(Brushes.Transparent, OnAlertAssistDismissForegroundChanged));

        public override void OnApplyTemplate()
        {
            DismissButton = GetTemplateChild(_dismissButtonName) as Button;

            if (DismissButton == null)
                throw new InvalidOperationException($"Control {_dismissButtonName} not found in the template.");

            DismissButton.Click -= DismissButton_Click;

            base.OnApplyTemplate();

            SetAlertDismissButtonForeground(DismissButton, this.Foreground);

            DismissButton.Click += DismissButton_Click;
        }

        private void DismissButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
        }

        public static CornerRadius GetCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(CornerRadiusProperty, value);
        }
       
        public bool IsAlertDismissible
        {
            get { return (bool)GetValue(IsAlertDismissibleProperty); }
            set { SetValue(IsAlertDismissibleProperty, value); }
        }
      
        public static Brush GetAlertDismissButtonForeground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(AlertDismissButtonForegroundProperty);
        }

        public static void SetAlertDismissButtonForeground(DependencyObject obj, Brush value)
        {
            obj.SetValue(AlertDismissButtonForegroundProperty, value);
        }
     
        private static void OnAlertAssistDismissForegroundChanged(DependencyObject element, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != e.OldValue)
                ((Button)element).Foreground = (Brush)e.NewValue;
        }
    }
}
