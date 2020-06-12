using System.Windows;
using System.Windows.Controls;

namespace WPFBootstrapUI.Controls
{
    public class Spinner: Control
    {
        static Spinner()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Spinner), new FrameworkPropertyMetadata(typeof(Spinner)));
        }

        public static readonly DependencyProperty DoSpinProperty =
           DependencyProperty.Register("DoSpin", typeof(bool), typeof(Spinner), new PropertyMetadata(false));

        public static readonly DependencyProperty StrokeThicknessProperty =
           DependencyProperty.Register("StrokeThickness", typeof(double), typeof(Spinner), new PropertyMetadata(0d));

        public bool DoSpin
        {
            get => (bool)GetValue(DoSpinProperty);
            set => SetValue(DoSpinProperty, value);
        }

        public double StrokeThickness
        {
            get { return (double)GetValue(StrokeThicknessProperty); }
            set { SetValue(StrokeThicknessProperty, value); }
        }
    }
}
