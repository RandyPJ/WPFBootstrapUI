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
        string popupName = "Popup";
        string containerName = "Container";

        Popup Popup;
        Grid Container;
        static PopOver()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PopOver), new FrameworkPropertyMetadata(typeof(PopOver)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            Popup = GetTemplateChild(popupName) as Popup;
            Container = GetTemplateChild(containerName) as Grid;

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
            DependencyProperty.Register("PopupPlacement", typeof(PlacementMode), typeof(PopOver), new PropertyMetadata(PlacementMode.Left));


        protected override void OnToggle()
        {
            base.OnToggle();

            if (IsChecked.Value)
            {
                switch (PopupPlacement)
                {
                    case PlacementMode.Left:
                        Popup.VerticalOffset = -8;
                        break;
                    case PlacementMode.Top:
                        Popup.HorizontalOffset = -(Popup.Width / 3);
                        break;
                    case PlacementMode.Right:
                        Popup.VerticalOffset = -8;
                        break;
                    case PlacementMode.Bottom:
                        Popup.HorizontalOffset = -(Popup.Width / 3);
                        break;
                    default:
                        break;
                }
            }
        }

    }
}
