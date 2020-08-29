using System.Windows;
using System.Windows.Controls;

namespace WPFBootstrapUI.Controls
{
    [TemplatePart( Name = InnerBorderName, Type = typeof(Border))]
    [TemplatePart(Name = ContentName, Type = typeof(TextBlock))]
    public class Badge : Control
    {
        private const string InnerBorderName = "InnerBorder";
        private const string ContentName = "PART_Content";


        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(Badge), new PropertyMetadata(new CornerRadius(0,0,0,0)));
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(Badge), new PropertyMetadata(string.Empty));

        static Badge()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Badge), new FrameworkPropertyMetadata(typeof(Badge)));
        }

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
    }
}