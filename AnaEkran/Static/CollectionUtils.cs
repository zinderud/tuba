using System.Collections.Generic;
// muratONUR murat ONUR karadeniz
// Tuba AnaEkran  CollectionUtils.cs
// 201312197:27 PM
// 201312197:27 PM
using System.Collections.ObjectModel;
namespace AnaEkran.Static
{
    public static class CollectionUtils
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> thisCollection)
        {
            if (thisCollection == null) return null;
            var oc = new ObservableCollection<T>();

            foreach (var item in thisCollection)
            {
                oc.Add(item);
            }

            return oc;
        }
    }
}