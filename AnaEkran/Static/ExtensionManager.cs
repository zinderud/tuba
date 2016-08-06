// murat ONUR karadeniz
// Tuba /AnaEkran/ExtensionManager.cs
// 2013   12   26   12:40

using System.Globalization;

namespace AnaEkran.Static
{
    public static class ExtensionManager
    {
        public static string ToTitleCase(this string Text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Text);
        } 
    }
}