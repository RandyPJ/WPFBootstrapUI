using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFBootstrapUI.Controls
{
    public class CardChildPanel : ContentControl
    {
        static CardChildPanel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CardChildPanel),new FrameworkPropertyMetadata(typeof(CardChildPanel)));
        }
    }
}
