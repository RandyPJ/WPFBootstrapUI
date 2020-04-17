using System.Windows;
using System.Windows.Controls;

namespace WPFBootstrapUI.src.Controls
{
    public class Card : ContentControl
    {
        static Card()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Card), new FrameworkPropertyMetadata(typeof(Card)));
        }
    }
}
