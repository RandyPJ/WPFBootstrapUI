using System.Windows.Controls;
using System.Windows;
using System;
using System.Windows.Media;

namespace WPFBootstrapUI.src.Controls
{
    [TemplatePart(Name = "PART_DismissButton", Type = typeof(Button))]
    public class Alert : ContentControl
    {
        private readonly string part_DismissButton = "PART_DismissButton";

        private Button DismissButton;

        static Alert()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Alert), new FrameworkPropertyMetadata(typeof(Alert)));
        }

        public override void OnApplyTemplate()
        {
            DismissButton = GetTemplateChild(part_DismissButton) as Button;

            if (DismissButton == null)
                throw new InvalidOperationException($"Control {part_DismissButton} not found in the template.");

            SetAlertDismissButtonForeground(DismissButton, this.Foreground);

            DismissButton.Click += DismissButton_Click;

            base.OnApplyTemplate(); 
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

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(Alert), new PropertyMetadata(new CornerRadius(2.0)));

        public bool IsAlertDismissible
        {
            get { return (bool)GetValue(IsAlertDismissibleProperty); }
            set { SetValue(IsAlertDismissibleProperty, value); }
        }

        public static readonly DependencyProperty IsAlertDismissibleProperty =
            DependencyProperty.Register("IsAlertDismissible", typeof(bool), typeof(Alert), new PropertyMetadata(false));


        public static Brush GetAlertDismissButtonForeground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(AlertDismissButtonForegroundProperty);
        }

        public static void SetAlertDismissButtonForeground(DependencyObject obj, Brush value)
        {
            obj.SetValue(AlertDismissButtonForegroundProperty, value);
        }

        public static readonly DependencyProperty AlertDismissButtonForegroundProperty =
            DependencyProperty.RegisterAttached("AlertDismissButtonForeground", typeof(Brush), typeof(Alert), new PropertyMetadata(Brushes.Transparent,OnAlertAssistDismissForegroundChanged));

        private static void OnAlertAssistDismissForegroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Button button = (Button)d;
            if (e.NewValue != e.OldValue)
                button.Foreground = (Brush)e.NewValue;
        }
    }
}
