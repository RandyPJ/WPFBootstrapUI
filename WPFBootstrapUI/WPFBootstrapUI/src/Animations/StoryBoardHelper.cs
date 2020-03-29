using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace WPFBootstrapUI.src.Animations
{
    public static class StoryBoardHelper
    {
        public static void SlideToLeft(this Storyboard storyboard, long seconds,float offset, float decelerationRatio)
        {
            ThicknessAnimation animation = new ThicknessAnimation()
            {
                Duration = new Duration(new TimeSpan(seconds)),
                From = new Thickness(0),
                To = new Thickness(),
                DecelerationRatio = decelerationRatio
            };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            storyboard.Children.Add(animation);
        }
    }
}
