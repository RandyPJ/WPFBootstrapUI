using System.Windows;
using System.Windows.Controls;

namespace WPFBootstrapUI.Controls
{
    [TemplatePart( Name = "InnerBorder", Type = typeof(Border))]
    [TemplatePart(Name = "PART_Content", Type = typeof(TextBlock))]
    public class Badge : Control
    {
        static Badge()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Badge), new FrameworkPropertyMetadata(typeof(Badge)));
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(Badge), new FrameworkPropertyMetadata(string.Empty));


        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(Badge), new PropertyMetadata(new CornerRadius(0,0,0,0)));
    }
}
