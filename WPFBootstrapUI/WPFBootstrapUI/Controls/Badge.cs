using System.Windows;
using System.Windows.Controls;

namespace WPFBootstrapUI.Controls
{
    [TemplatePart( Name = "InnerBorder", Type = typeof(Border))]
    [TemplatePart(Name = "PART_Content", Type = typeof(TextBlock))]
    public class Badge : Control
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(Badge), new FrameworkPropertyMetadata(string.Empty));
        static Badge()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Badge), new FrameworkPropertyMetadata(typeof(Badge)));
        }
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
    }
}