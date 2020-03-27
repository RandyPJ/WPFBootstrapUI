using System;
using System.Windows;

namespace WPFBootstrapUI.src
{
    public static class BootstrapTextBoxAssist
    {
        public static string GetPlaceHolder(DependencyObject obj)
        {
            return (string)obj.GetValue(PlaceHolderProperty);
        }

        public static void SetPlaceHolder(DependencyObject obj, string value)
        {
            obj.SetValue(PlaceHolderProperty, value);
        }

        // Using a DependencyProperty as the backing store for PlaceHolder.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceHolderProperty =
            DependencyProperty.RegisterAttached("PlaceHolder", typeof(string), typeof(BootstrapTextBoxAssist), new PropertyMetadata(string.Empty));


        public static bool GetHasText(DependencyObject obj)
        {
            return (bool)obj.GetValue(HasTextProperty);
        }

        public static void SetHasText(DependencyObject obj, bool value)
        {
            obj.SetValue(HasTextProperty, value);
        }

        // Using a DependencyProperty as the backing store for HasText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HasTextProperty =
            DependencyProperty.RegisterAttached("HasText", typeof(bool), typeof(BootstrapTextBoxAssist), new PropertyMetadata(true));

        public static bool GetIsMonitoring(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsMonitoringProperty);
        }

        public static void SetIsMonitoring(DependencyObject obj, bool value)
        {
            obj.SetValue(IsMonitoringProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsMonitoring.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsMonitoringProperty =
            DependencyProperty.RegisterAttached("IsMonitoring", typeof(bool), typeof(BootstrapTextBoxAssist), new PropertyMetadata(false));



        public static bool GetIsPasswordBox(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsPasswordBoxProperty);
        }

        public static void SetIsPasswordBox(DependencyObject obj, bool value)
        {
            obj.SetValue(IsPasswordBoxProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsPasswordBox.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsPasswordBoxProperty =
            DependencyProperty.RegisterAttached("IsPasswordBox", typeof(bool), typeof(BootstrapTextBoxAssist), new PropertyMetadata(false));



        public static string GetPasswordChar(DependencyObject obj)
        {
            return (string)obj.GetValue(PasswordCharProperty);
        }

        public static void SetPasswordChar(DependencyObject obj, string value)
        {
            obj.SetValue(PasswordCharProperty, value);
        }

        // Using a DependencyProperty as the backing store for PasswordChar.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordCharProperty =
            DependencyProperty.RegisterAttached("PasswordChar", typeof(string), typeof(BootstrapTextBoxAssist), new PropertyMetadata(string.Empty));
    }
}
