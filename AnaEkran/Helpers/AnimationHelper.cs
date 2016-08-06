using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows;

namespace AnaEkran.Helpers
{
    public class AnimationHelper : IAnimationHelper
    {
        private Storyboard myStoryboard;
        private DoubleAnimation myDoubleAnimation;
        private bool IsSmall = false;
        private double borderWidth;

        public void NavigationBarAnim(Border border, Button navigationBtn, double navigationButtonMargin)
        {

            border.MinWidth = 0;
            myDoubleAnimation = new DoubleAnimation();
  
            if (!IsSmall)
            {
                myDoubleAnimation.From = border.ActualWidth;
                myDoubleAnimation.To = navigationBtn.ActualWidth + navigationButtonMargin;
                myDoubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(1));
                myDoubleAnimation.AccelerationRatio = 0.3;
                myDoubleAnimation.DecelerationRatio = 0.7;
                IsSmall = true;
                borderWidth = border.ActualWidth;
            }

            else
            {
                myDoubleAnimation.From = navigationBtn.ActualWidth + navigationButtonMargin;
                myDoubleAnimation.To = borderWidth;
                myDoubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.5));
                myDoubleAnimation.AccelerationRatio = 0.6;
                myDoubleAnimation.DecelerationRatio = 0.4;
                IsSmall = false;
            }

            myStoryboard = new Storyboard();
            myStoryboard.Children.Add(myDoubleAnimation);
            Storyboard.SetTargetName(myDoubleAnimation, border.Name);
            Storyboard.SetTargetProperty(myDoubleAnimation, new PropertyPath(Border.WidthProperty));
            myStoryboard.Begin(border);
        }

        public void UserControlOpacityAnim(Button userCtrl)
        {     
            var myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = 0;
            myDoubleAnimation.To = 1;
            myDoubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.6));
            myStoryboard = new Storyboard();
            myStoryboard.Children.Add(myDoubleAnimation);
            Storyboard.SetTargetName(myDoubleAnimation, userCtrl.Name);
            Storyboard.SetTargetProperty(myDoubleAnimation, new PropertyPath(Button.OpacityProperty));
            myStoryboard.Begin(userCtrl);
        }

        public void UserControlDropDownAnim(UserControl userCtrl,double height) 
        {
            //userCtrl.Height = 0;
            //var myDoubleAnimation = new DoubleAnimation();
            //myDoubleAnimation.From = 0;
            //myDoubleAnimation.To = height;
            //myDoubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.5));
            //myDoubleAnimation.AccelerationRatio = 0.6;
            //myDoubleAnimation.DecelerationRatio = 0.4;
            //myStoryboard = new Storyboard();
            //myStoryboard.Children.Add(myDoubleAnimation);
            //Storyboard.SetTargetName(myDoubleAnimation, userCtrl.Name);
            //Storyboard.SetTargetProperty(myDoubleAnimation, new PropertyPath(UserControl.HeightProperty));
            //myStoryboard.Begin(userCtrl);
        }
    }
}
