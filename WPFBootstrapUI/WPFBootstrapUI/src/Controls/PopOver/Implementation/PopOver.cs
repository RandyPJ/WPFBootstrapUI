using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace WPFBootstrapUI.src.Controls
{
    [TemplatePart(Name = "Container", Type = typeof(Grid))]
    [TemplatePart(Name = "OutterBorder", Type = typeof(Border))]
    [TemplatePart(Name = "InnerBorder", Type = typeof(Border))]
    [TemplatePart(Name = "Popup", Type = typeof(Popup))]
    [TemplatePart(Name = "PopupContainer", Type = typeof(Grid))]
    public class PopOver : ToggleButton
    {
        readonly string popupName = "Popup";
        readonly string containerName = "Container";

        Popup Popup;
        Grid Container;

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            Popup = GetTemplateChild(popupName) as Popup;

            if (Popup == null)
                throw new InvalidOperationException($"El control de tipo: {Popup.GetType().Name} no ha sido encontrado.");
        }

        public string PopOverText
        {
            get { return (string)GetValue(PopOverTextProperty); }
            set { SetValue(PopOverTextProperty, value); }
        }
        public static readonly DependencyProperty PopOverTextProperty =
            DependencyProperty.Register("PopOverText", typeof(string), typeof(PopOver), new PropertyMetadata(string.Empty));


        public PlacementMode PopupPlacement
        {
            get { return (PlacementMode)GetValue(PopupPlacementProperty); }
            set { SetValue(PopupPlacementProperty, value); }
        }

        public static readonly DependencyProperty PopupPlacementProperty =
            DependencyProperty.Register("PopupPlacement", typeof(PlacementMode), typeof(PopOver), new PropertyMetadata(PlacementMode.Bottom));
    }
}
