using System.Windows;
using System.Windows.Controls;

namespace WPFBootstrapUI.Controls
{
    public class Carousel : Panel
    {
        static Carousel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Carousel), new FrameworkPropertyMetadata(typeof(Carousel)));
        }
    }
}
