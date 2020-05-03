using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace WPFBootstrapUI.Animations
{
    public static class StoryBoardHelper
    {
        public static void SlideToLeft(this Storyboard storyboard, long seconds,float offset, float decelerationRatio, bool keepMargin)
        {
            ThicknessAnimation animation = new ThicknessAnimation()
            {
                Duration = new Duration(new TimeSpan(seconds)),
                From = new Thickness(0),
                To = new Thickness(-offset, keepMargin ? offset : 0, 0,0),
                DecelerationRatio = decelerationRatio
            };

            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            storyboard.Children.Add(animation);
        }
    }
}
