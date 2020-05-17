using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace WPFBootstrapUI.Controls
{
    [TemplatePart(Name = "PART_Title", Type = typeof(StackPanel))]
    [TemplatePart(Name = "PART_MessageScrollViewer", Type = typeof(ScrollViewer))]
    [TemplatePart(Name = "PART_TextBlockMessage", Type = typeof(TextBlock))]
    [TemplatePart(Name = "PART_AcceptButton", Type = typeof(Button))]
    [TemplatePart(Name = "PART_CancelButton", Type = typeof(Button))]
    public class Modal : ContentControl
    {
        static Modal()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Modal), new FrameworkPropertyMetadata(typeof(Modal)));
        }
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(Modal), new PropertyMetadata(string.Empty));

        
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(Modal), new PropertyMetadata(string.Empty));


        public string AcceptButtonText
        {
            get { return (string)GetValue(AcceptButtonTextProperty); }
            set { SetValue(AcceptButtonTextProperty, value); }
        }

        public static readonly DependencyProperty AcceptButtonTextProperty =
            DependencyProperty.Register("AcceptButtonText", typeof(string), typeof(Modal), new PropertyMetadata(string.Empty));

       
        public string CancelButtonText
        {
            get { return (string)GetValue(CancelButtonTextProperty); }
            set { SetValue(CancelButtonTextProperty, value); }
        }
        
        public static readonly DependencyProperty CancelButtonTextProperty =
            DependencyProperty.Register("CancelButtonText", typeof(string), typeof(Modal), new PropertyMetadata(string.Empty));


        public bool Show
        {
            get { return (bool)GetValue(ShowProperty); }
            set { SetValue(ShowProperty, value); }
        }

        public static readonly DependencyProperty ShowProperty =
            DependencyProperty.Register("Show", typeof(bool), typeof(Modal), new PropertyMetadata(false, OnShowPropertyChanged));

        private static void OnShowPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Modal modal = (Modal)d;

            if (modal == null)
                return;

            if (!(bool)e.OldValue)
                modal.Visibility = Visibility.Collapsed;

            if ((bool)e.NewValue)
            {
                modal.Visibility = Visibility.Visible;
                modal.Effect = new DropShadowEffect()
                {
                    BlurRadius = 10,
                    ShadowDepth = 5
                };
            }
        }


      
        public static readonly RoutedEvent CloseModalEvent =
            EventManager.RegisterRoutedEvent("CloseModal", RoutingStrategy.Bubble,typeof(RoutedEventHandler), typeof(Modal));


        public event RoutedEventHandler CloseModal
        {
            add { AddHandler(CloseModalEvent,value); }
            remove { RemoveHandler(CloseModalEvent, value); }
        }
    }
}
