using System;
using System.Windows;
using System.Windows.Controls;
using WPFBootstrapUI.Controls.Modals;

namespace WPFBootstrapUI.Controls
{
    [TemplatePart(Name = "PART_Title", Type = typeof(StackPanel))]
    [TemplatePart(Name = "PART_CloseButton", Type = typeof(Button))]
    [TemplatePart(Name = "PART_MessageScrollViewer", Type = typeof(ScrollViewer))]
    [TemplatePart(Name = "PART_TextBlockMessage", Type = typeof(TextBlock))]
    [TemplatePart(Name = "PART_AcceptButton", Type = typeof(Button))]
    [TemplatePart(Name = "PART_CancelButton", Type = typeof(Button))]
    public class Modal : Window
    {
        public static readonly DependencyProperty MessageProperty =
          DependencyProperty.Register("Message", typeof(string), typeof(Modal), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty AcceptButtonTextProperty =
            DependencyProperty.Register("AcceptButtonText", typeof(string), typeof(Modal), new PropertyMetadata(string.Empty));

        public static readonly DependencyProperty CancelButtonTextProperty =
            DependencyProperty.Register("CancelButtonText", typeof(string), typeof(Modal), new PropertyMetadata(string.Empty));
        
        public static readonly DependencyProperty IsDesitionProperty =
            DependencyProperty.Register("IsDesition", typeof(bool), typeof(Modal), new PropertyMetadata(false));

        static Modal()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Modal), new FrameworkPropertyMetadata(typeof(Modal)));
        }

        public Modal(Window ownerWindow)
        {
            this.Width = 600;
            this.Height = 280;

            this.Owner = ownerWindow;
            this.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            this.WindowStyle = WindowStyle.None;
            this.AllowsTransparency = true;
        }

        private readonly string closeButtonName = "PART_CloseButton";
        private readonly string acceptButtonName = "PART_AcceptButton";
        private readonly string cancelButtonName = "PART_CancelButton";

        private Button CloseButton;
        private Button AcceptButton;
        private Button CancelButton;

        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }
        public string AcceptButtonText
        {
            get { return (string)GetValue(AcceptButtonTextProperty); }
            set { SetValue(AcceptButtonTextProperty, value); }
        }
        public string CancelButtonText
        {
            get { return (string)GetValue(CancelButtonTextProperty); }
            set { SetValue(CancelButtonTextProperty, value); }
        }
        public bool IsDesition
        {
            get { return (bool)GetValue(IsDesitionProperty); }
            set { SetValue(IsDesitionProperty, value); }
        }

        public ModalResult ModalResult { get; set; }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this.CloseButton = GetTemplateChild(closeButtonName) as Button;
            this.AcceptButton = GetTemplateChild(acceptButtonName) as Button;
            this.CancelButton = GetTemplateChild(cancelButtonName) as Button;

            UnHookEvents();

            if (CloseButton != null && AcceptButton != null && CancelButton != null)
            {
                HookUpEvents();
            }
            else
            {
                throw new InvalidOperationException("An error occured while applying the template to the modal control.");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Dispatcher.Invoke(new Action(() =>
            {
                this.ModalResult = ModalResult.Cancel;
                this.Close();
            }));
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Dispatcher.Invoke(new Action(() =>
            {
                this.ModalResult = ModalResult.Accept;
                this.Close();
            }));
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Dispatcher.Invoke(new Action(() => 
            {
                this.ModalResult = ModalResult.None;
                this.Close(); }
            ));
        }

        private void HookUpEvents()
        {
            this.CloseButton.Click += CloseButton_Click;
            this.AcceptButton.Click += AcceptButton_Click;
            this.CancelButton.Click += CancelButton_Click;
        }

        private void UnHookEvents()
        {
            this.CloseButton.Click -= CloseButton_Click;
            this.AcceptButton.Click -= AcceptButton_Click;
            this.CancelButton.Click -= CancelButton_Click;
        }
    }
}
