using System.Windows;
using System.Windows.Controls;

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
