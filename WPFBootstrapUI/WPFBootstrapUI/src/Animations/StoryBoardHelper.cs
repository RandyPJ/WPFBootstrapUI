using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace WPFBootstrapUI.src.Animations
{
    public static class StoryBoardHelper
    {
        public static void SlideToLeft(this Storyboard storyboard, long seconds, double accelerationRatio)
        {
            Storyboard sb = new Storyboard();

            new ThicknessAnimation()
            {
                Duration = new Duration(new TimeSpan(seconds)),
                From = new Thickness(),
                AccelerationRatio = accelerationRatio
            };
        }
    }
}
