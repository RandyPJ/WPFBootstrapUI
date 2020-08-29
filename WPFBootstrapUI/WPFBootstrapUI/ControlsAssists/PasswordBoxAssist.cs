using System.Windows;
using System.Windows.Controls;

namespace WPFBootstrapUI.ControlsAssists
{
    /// <summary>
    /// The PasswordBox control's assistant
    /// </summary>
    public class PasswordBoxAssist : DependencyObject
    {
        private readonly PasswordBox _passwordBox;

        public PasswordBoxAssist(PasswordBox passwordBox)
        {
            _passwordBox = passwordBox;
        }

        public static readonly DependencyProperty AttachProperty = DependencyProperty.RegisterAttached("Attach", typeof(bool), typeof(PasswordBoxAssist), new PropertyMetadata(false,OnAttachChanged));
        public static readonly DependencyProperty IsMonitoringProperty = DependencyProperty.RegisterAttached("IsMonitoring", typeof(bool), typeof(PasswordBoxAssist), new PropertyMetadata(false));
        public static readonly DependencyProperty TextProperty = DependencyProperty.RegisterAttached("Text", typeof(string), typeof(PasswordBoxAssist), new PropertyMetadata(string.Empty, OnTextPropertyChanged));
        public static readonly DependencyProperty HasTextProperty = DependencyProperty.RegisterAttached("HasText", typeof(bool), typeof(PasswordBoxAssist), new PropertyMetadata(false));
        public static readonly DependencyProperty CanShowPasswordProperty = DependencyProperty.RegisterAttached("CanShowPassword", typeof(bool), typeof(PasswordBoxAssist), new PropertyMetadata(false));
        public static readonly DependencyProperty PlaceHolderProperty = DependencyProperty.RegisterAttached("PlaceHolder", typeof(string), typeof(PasswordBoxAssist), new PropertyMetadata(string.Empty));
        public static readonly DependencyProperty AttachHelperButtonProperty = DependencyProperty.RegisterAttached("AttachHelperButton", typeof(bool), typeof(PasswordBoxAssist), new PropertyMetadata(false, OnAttachedChanged));

        public static bool GetAttach(DependencyObject obj)
        {
            return (bool)obj.GetValue(AttachProperty);
        }

        public static void SetAttach(DependencyObject obj, bool value)
        {
            obj.SetValue(AttachProperty, value);
        }

        public static bool GetIsMonitoring(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsMonitoringProperty);
        }

        public static void SetIsMonitoring(DependencyObject obj, bool value)
        {
            obj.SetValue(IsMonitoringProperty, value);
        }
     
        public static string GetText(DependencyObject obj)
        {
            return (string)obj.GetValue(TextProperty);
        }

        public static void SetText(DependencyObject obj, string value)
        {
            obj.SetValue(TextProperty, value);
        }

        public static bool GetHasText(DependencyObject obj)
        {
            return (bool)obj.GetValue(HasTextProperty);
        }

        public static void SetHasText(DependencyObject obj, bool value)
        {
            obj.SetValue(HasTextProperty, value);
        }
       
        public static bool GetCanShowPassword(DependencyObject obj)
        {
            return (bool)obj.GetValue(CanShowPasswordProperty);
        }

        public static void SetCanShowPassword(DependencyObject obj, bool value)
        {
            obj.SetValue(CanShowPasswordProperty, value);
        }
      
        public static string GetPlaceHolder(DependencyObject obj)
        {
            return (string)obj.GetValue(PlaceHolderProperty);
        }

        public static void SetPlaceHolder(DependencyObject obj, string value)
        {
            obj.SetValue(PlaceHolderProperty, value);
        }

        public static bool GetAttachHelperButton(DependencyObject obj)
        {
            return (bool)obj.GetValue(AttachHelperButtonProperty);
        }

        public static void SetAttachHelperButton(DependencyObject obj, bool value)
        {
            obj.SetValue(AttachHelperButtonProperty, value);
        }

        private static void OnAttachChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)d;

            if (passwordBox == null)
                return;

            if ((bool)e.OldValue)
                passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;


            if ((bool)e.NewValue)
                passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
        }

        private static void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)sender;

            SetIsMonitoring(passwordBox, true);
            SetText(passwordBox, passwordBox.Password);
            SetIsMonitoring(passwordBox, false);
        }

        private static void OnTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)d;

            passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;

            string newValue = (string)e.NewValue;

            if (!(bool)GetIsMonitoring(passwordBox))
            {
                passwordBox.Password = newValue;
            }

            SetHasText(passwordBox, passwordBox.Password.Length > 0);
            SetCanShowPassword(passwordBox, passwordBox.Password.Length < 0);
            ToggleShowPasswordButtonContent = !(passwordBox.Password.Length > 0);

            passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
        }

        private static void OnAttachedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Button button = (Button)d;

            if (button == null)
                return;

            if ((bool)e.NewValue)
                button.Click -= ButtonClicked;

            if ((bool)e.NewValue)
                button.Click += ButtonClicked;
        }

        ///Toggles the content of the ShowPasswordButton.
        ///Decides if the <see cref="PasswordBox"/> can take inputs.
        private static bool ToggleShowPasswordButtonContent = false;

        private static void ButtonClicked(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            ToggleShowPasswordButtonContent ^= true;

            if (button.TemplatedParent is PasswordBox passwordBox)
            {
                if (GetHasText(passwordBox))
                    SetCanShowPassword(passwordBox, ToggleShowPasswordButtonContent);
            }
        }
    }
}
