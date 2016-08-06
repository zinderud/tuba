#region ONUR KARADENİZ
// murat onur  Sio
// Görüntü   ResourcesDosyalari.cs
// 2013050116:09
// 2013  05
// 01 01
#endregion

using System.IO;
using System.Reflection;

namespace AnaEkran.Helpers
{
    public class ResourcesDosyalari
    {
        public static StreamReader Getir(string FileName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string[] resourceNmes = assembly.GetManifestResourceNames();
            StreamReader reader = null;
            foreach (string names in resourceNmes)
            {
                if (names.Contains(FileName))
                {
                    reader = new StreamReader(assembly.GetManifestResourceStream(names));
                }
            }

            return reader;
        } 
    }
}