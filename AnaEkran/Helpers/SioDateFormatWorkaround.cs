using System.Globalization;

namespace AnaEkran.Helpers
{
    public  static class SioDateFormatWorkaround
    {
        public  static CultureInfo CultureWithSwissFormat
        {
            set { }
 
            get
            {
                var tempCultureInfo = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                tempCultureInfo.DateTimeFormat.ShortDatePattern = "dd.MM.yyyy";
                return tempCultureInfo;
            }
        }
    }
}