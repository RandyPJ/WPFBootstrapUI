using System.Windows.Controls;
using System.Windows;
using System;

namespace WPFBootstrapUI.src.Controls.Alert.Implementation
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
            {
                throw new InvalidOperationException($"Control {part_DismissButton} not found in the template.");
            }

            DismissButton.Click += DismissButton_Click;

            base.OnApplyTemplate(); 
        }

        private void DismissButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
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


        public bool IsAlertDismissible
        {
            get { return (bool)GetValue(IsAlertDismissibleProperty); }
            set { SetValue(IsAlertDismissibleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AlertDismissible.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsAlertDismissibleProperty =
            DependencyProperty.Register("IsAlertDismissible", typeof(bool), typeof(Alert), new PropertyMetadata(false));
    }
}
