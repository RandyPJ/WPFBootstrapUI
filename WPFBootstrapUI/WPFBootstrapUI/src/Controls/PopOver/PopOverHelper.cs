using System.Windows;
using System.Windows.Controls.Primitives;

namespace WPFBootstrapUI.src.Controls
{
    public class PopOverHelper
    {
        public static PlacementMode GetPopupPlacement(DependencyObject obj)
        {
            return (PlacementMode)obj.GetValue(PopupPlacementProperty);
        }

        public static void SetPopupPlacement(DependencyObject obj, PlacementMode value)
        {
            obj.SetValue(PopupPlacementProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PopupPlacementProperty =
            DependencyProperty.RegisterAttached("PopupPlacement", typeof(PlacementMode), typeof(PopOverHelper), new PropertyMetadata(PlacementMode.Relative, OnPlacementChanged));

        private static void OnPlacementChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Popup popup = d as Popup;

            if (e.OldValue == null && e.OldValue == e.NewValue) return;

            PlacementMode placementMode = (PlacementMode)e.NewValue;

            if (placementMode == PlacementMode.Left || placementMode == PlacementMode.Right)
            {
                if (popup != null)
                    popup.VerticalOffset = -8;
            }
        }
    }
}
