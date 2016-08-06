using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace Zinderud
{
    public static class ResourcesFiles
    {
        public static StreamReader Files(string FileName)
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
        public static Stream Log4net()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string[] resourceNmes = assembly.GetManifestResourceNames();
            //Stream readers = null;
            Stream reader = null;
            foreach (string names in resourceNmes)
            {
                if (names.Contains("log4net.Config"))
                {
                    reader = assembly.GetManifestResourceStream(names);
                }
            }

            return reader;

        }
    }
}
