using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFBootstrapUI.ControlsAssists
{
    /// <summary>
    /// The PasswordBox control's assistant
    /// </summary>
    public class PasswordBoxAssist
    {
        private static PasswordBox PasswordBox;

        public PasswordBoxAssist()
        {
            PasswordBox = new PasswordBox();
        }

        public static bool GetAttach(DependencyObject obj)
        {
            return (bool)obj.GetValue(AttachProperty);
        }

        public static void SetAttach(DependencyObject obj, bool value)
        {
            obj.SetValue(AttachProperty, value);
        }

        
        public static readonly DependencyProperty AttachProperty =
            DependencyProperty.RegisterAttached("Attach", typeof(bool), typeof(PasswordBoxAssist), new PropertyMetadata(false,OnAttachChanged));


        public static bool GetIsMonitoring(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsMonitoringProperty);
        }

        public static void SetIsMonitoring(DependencyObject obj, bool value)
        {
            obj.SetValue(IsMonitoringProperty, value);
        }

        public static readonly DependencyProperty IsMonitoringProperty =
            DependencyProperty.RegisterAttached("IsMonitoring", typeof(bool), typeof(PasswordBoxAssist), new PropertyMetadata(false));


        public static string GetText(DependencyObject obj)
        {
            return (string)obj.GetValue(TextProperty);
        }

        public static void SetText(DependencyObject obj, string value)
        {
            obj.SetValue(TextProperty, value);
        }

        //This property sets the Password.
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.RegisterAttached("Text", typeof(string), typeof(PasswordBoxAssist), new PropertyMetadata(string.Empty, OnTextPropertyChanged));

        private static void OnTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)d;

            passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;

            string newValue = (string)e.NewValue;

            if (!(bool)GetIsMonitoring(passwordBox))
            {
                passwordBox.Password = newValue;
            }

            passwordBox.PasswordChanged += PasswordBox_PasswordChanged;

            SetHasText(passwordBox, passwordBox.Password.Length > 0);
        }

        public static bool GetHasText(DependencyObject obj)
        {
            return (bool)obj.GetValue(HasTextProperty);
        }

        public static void SetHasText(DependencyObject obj, bool value)
        {
            obj.SetValue(HasTextProperty, value);
        }

        public static readonly DependencyProperty HasTextProperty =
            DependencyProperty.RegisterAttached("HasText", typeof(bool), typeof(PasswordBoxAssist), new PropertyMetadata(false));
        
        public static bool GetCanShowPassword(DependencyObject obj)
        {
            return (bool)obj.GetValue(CanShowPasswordProperty);
        }

        public static void SetCanShowPassword(DependencyObject obj, bool value)
        {
            obj.SetValue(CanShowPasswordProperty, value);
        }

        public static readonly DependencyProperty CanShowPasswordProperty =
            DependencyProperty.RegisterAttached("CanShowPassword", typeof(bool), typeof(PasswordBoxAssist), new PropertyMetadata(false));

        public static string GetPlaceHolder(DependencyObject obj)
        {
            return (string)obj.GetValue(PlaceHolderProperty);
        }

        public static void SetPlaceHolder(DependencyObject obj, string value)
        {
            obj.SetValue(PlaceHolderProperty, value);
        }

        public static readonly DependencyProperty PlaceHolderProperty =
            DependencyProperty.RegisterAttached("PlaceHolder", typeof(string), typeof(PasswordBoxAssist), new PropertyMetadata(string.Empty));


        public static bool GetAttachHelperButton(DependencyObject obj)
        {
            return (bool)obj.GetValue(AttachHelperButtonProperty);
        }

        public static void SetAttachHelperButton(DependencyObject obj, bool value)
        {
            obj.SetValue(AttachHelperButtonProperty, value);
        }

        public static readonly DependencyProperty AttachHelperButtonProperty =
            DependencyProperty.RegisterAttached("AttachHelperButton", typeof(bool), typeof(PasswordBoxAssist), new PropertyMetadata(false, OnAttachedChanged));


        private static void OnAttachChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox = (PasswordBox)d;

            if (PasswordBox == null)
                return;

            if ((bool)e.OldValue)
                PasswordBox.PasswordChanged -= PasswordBox_PasswordChanged;


            if ((bool)e.NewValue)
                PasswordBox.PasswordChanged += PasswordBox_PasswordChanged;
        }

        private static void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox = (PasswordBox)sender;

            SetIsMonitoring(PasswordBox, true);
            SetText(PasswordBox, PasswordBox.Password);
            SetIsMonitoring(PasswordBox, false);
        }
     
        private static void OnAttachedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Button button = (Button)d;

            button.Click -= ButtonClicked;

            if ((bool)e.NewValue)
                button.Click += ButtonClicked;
        }

        ///Toggles the content of the ShowPasswordButton.
        ///Decides if the <see cref="PasswordBox"/> PasswordBox can take inputs.
        private static bool ToggleShowPasswordButtonContent = false;

        private static void ButtonClicked(object sender, RoutedEventArgs e)
        {
            ToggleShowPasswordButtonContent ^= true; 

            if (GetHasText(PasswordBox))
            {
                SetCanShowPassword(PasswordBox, ToggleShowPasswordButtonContent);

                PasswordBox.PreviewTextInput -= PasswordBox_PreviewTextInput;

                if (ToggleShowPasswordButtonContent)
                {
                    PasswordBox.PreviewTextInput += PasswordBox_PreviewTextInput;
                }
            }
        }

        //Stops recieving inputs.
        private static void PasswordBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = true;
        }
    }
}
