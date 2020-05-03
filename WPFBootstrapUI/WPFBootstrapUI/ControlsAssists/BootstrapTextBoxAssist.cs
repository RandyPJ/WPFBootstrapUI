using System.Windows;
using System.Windows.Controls;

namespace WPFBootstrapUI.ControlsAssists
{
    public static class BootstrapTextBoxAssist
    {
        public static readonly DependencyProperty PlaceHolderProperty =
          DependencyProperty.RegisterAttached("PlaceHolder", typeof(string), typeof(BootstrapTextBoxAssist), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty HasTextProperty =
         DependencyProperty.RegisterAttached("HasText", typeof(bool), typeof(BootstrapTextBoxAssist), new PropertyMetadata(false));

        public static readonly DependencyProperty IsMonitoringProperty =
         DependencyProperty.RegisterAttached("IsMonitoring", typeof(bool), typeof(BootstrapTextBoxAssist), new PropertyMetadata(false, OnIsMonitoringChanged));


        public static string GetPlaceHolder(DependencyObject obj)
        {
            return (string)obj.GetValue(PlaceHolderProperty);
        }

        public static void SetPlaceHolder(DependencyObject obj, string value)
        {
            obj.SetValue(PlaceHolderProperty, value);
        }

        public static bool GetHasText(DependencyObject obj)
        {
            return (bool)obj.GetValue(HasTextProperty);
        }

        public static void SetHasText(DependencyObject obj, bool value)
        {
            obj.SetValue(HasTextProperty, value);
        }

    
        public static bool GetIsMonitoring(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsMonitoringProperty);
        }

        public static void SetIsMonitoring(DependencyObject obj, bool value)
        {
            obj.SetValue(IsMonitoringProperty, value);
        }
     
        private static void OnIsMonitoringChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TextBox textbox = (TextBox)d;

            if (e.NewValue != e.OldValue)
            {
                if ((bool)e.NewValue)
                    textbox.TextChanged += Textbox_TextChanged;
            }
        }

        private static void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SetHasText(textBox, textBox.Text.Length > 0);
        }
    }
}
