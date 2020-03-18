using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFBootstrapUI.src
{
    public class BorderAssist
    {
        public static Brush GetBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(BorderBrushProperty);
        }

        public static void SetBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(BorderBrushProperty, value);
        }

        public static readonly DependencyProperty BorderBrushProperty =
            DependencyProperty.RegisterAttached("BorderBrush", typeof(Brush), typeof(BorderAssist), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(0,0,0)),OnBorderBrushChanged));

        private static void OnBorderBrushChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                if (d is Button)
                {
                    Button button = d as Button;
                    button.BorderBrush = (Brush)e.NewValue;
                }
                else if (d is TextBox)
                {
                    TextBox textBox = d as TextBox;
                    textBox.BorderBrush = (Brush)e.NewValue;
                }
            }
        }

        public static double GetBorderOpacity(DependencyObject obj)
        {
            return (double)obj.GetValue(BorderOpacityProperty);
        }

        public static void SetBorderOpacity(DependencyObject obj, double value)
        {
            obj.SetValue(BorderOpacityProperty, value);
        }

        public static readonly DependencyProperty BorderOpacityProperty =
            DependencyProperty.RegisterAttached("BorderOpacity", typeof(double), typeof(BorderAssist), new PropertyMetadata(double.MinValue, OnBorderAssistPropertyChanged));

        private static void OnBorderAssistPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                if (d is Button)
                {
                    Button button = d as Button;
                    button.BorderBrush.Opacity = (double)e.NewValue;
                }
                else if (d is TextBox)
                {
                    TextBox textBox = d as TextBox;
                    textBox.BorderBrush.Opacity = (double)e.NewValue;
                }
            }
        }
    }
}
