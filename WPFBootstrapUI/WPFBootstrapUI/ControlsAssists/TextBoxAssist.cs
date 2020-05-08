using System;
using System.Windows;
using System.Windows.Controls;

namespace WPFBootstrapUI.ControlsAssists
{
    public static class TextBoxAssist
    {
        public static readonly DependencyProperty PlaceHolderProperty =
          DependencyProperty.RegisterAttached("PlaceHolder", typeof(string), typeof(TextBoxAssist), new PropertyMetadata(string.Empty, OnPlaceHolderPropertyChanged));
       
        public static readonly DependencyProperty HasTextProperty =
         DependencyProperty.RegisterAttached("HasText", typeof(bool), typeof(TextBoxAssist), new PropertyMetadata(false));

        public static readonly DependencyProperty IsMonitoringProperty =
         DependencyProperty.RegisterAttached("IsMonitoring", typeof(bool), typeof(TextBoxAssist), new PropertyMetadata(false, OnIsMonitoringChanged));


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

        private static void OnPlaceHolderPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TextBox textBox = (TextBox)d;

            if (!string.IsNullOrEmpty(e.NewValue.ToString()))
                SetIsMonitoring(textBox, true);
        }

        private static void OnIsMonitoringChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TextBox textbox = (TextBox)d;

            if ((bool)e.NewValue == false)
                textbox.TextChanged -= Textbox_TextChanged;

            if (e.NewValue != e.OldValue)
                 textbox.TextChanged += Textbox_TextChanged;
        }

        private static void Textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            SetHasText(textBox, textBox.Text.Length > 0);
        }
    }
}
