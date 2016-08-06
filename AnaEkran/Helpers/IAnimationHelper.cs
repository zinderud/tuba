using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;

namespace AnaEkran.Helpers
{
    public interface IAnimationHelper
    {
        /// <summary>
        /// Navigasyon için kullanılan açılıp kapanan animasyon.
        /// Parametre olarak border, animasyon butonu ve butonun margin değeri verilir.
        /// Margin degerine gore ne kadar küçültüleceği hesaplanır.
        /// </summary>
        /// <param name="border"></param>
        /// <param name="navigationBtn"></param>
        /// <param name="navigationButtonMargin"></param>
        void NavigationBarAnim(Border border, Button navigationBtn, double navigationButtonMargin);

        /// <summary>
        /// İlgili user control parametre olarak verilir.
        /// Alınan control için yazılmış olan bir opacity animasyonudur.
        /// Ekranda rigid olarak degil de daha smooth bir geçiş sağlanır.
        /// </summary>
        /// <param name="userCtrl"></param>
        void UserControlOpacityAnim(Button userCtrl);
            
        /// <summary>
        /// Kullanıcı hangi alanda bulunuyorsa onunla ilgili olan
        /// menuye tıklayarak, düşme efekti sağlar. 
        /// </summary>
        /// <param name="userCtrl"></param>
        void UserControlDropDownAnim(UserControl userCtrl,double height);

     
    }
}
