#region ONUR KARADENİZ
// murat onur  Sio
// Görüntü   ConfigSettings.cs
// 2013040518:36
// 2013  04
// 05 05
#endregion

using System;
using System.Configuration;
using System.Reflection;
using System.Xml;

namespace AnaEkran.Helpers
{
    public class AppAyarlari
    {
        private AppAyarlari()
        {
        }

        public static string AyarlariOku(string key)
        {
            return ConfigurationManager.AppSettings[key].ToString();

        }
        // app.config dosyasında bulunan keylere ait Value leri gunceller.
        public static void AyarlariGuncelle(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static void AyarlariYaz(string key, string value)
        {
            //  Gecerli asmbly için  config document 
            XmlDocument doc = ConfigDosyasiniYukle();

            // gecerli nodu bul
            XmlNode node = doc.SelectSingleNode("//appSettings");

            if (node == null)
                throw new InvalidOperationException("secilen nod !appSettings! bulunamadı  ");

            try
            {
                // add elementi içinde değer
                XmlElement elem = (XmlElement) node.SelectSingleNode(string.Format("//add[@key='{0}']", key));

                if (elem != null)
                {
                    // add için keyi düzenle
                    elem.SetAttribute("value", value);
                }
                else
                {
                    // key yok ise oluştur ve  set et
                     elem = doc.CreateElement("add");
                    elem.SetAttribute("key", key);
                    elem.SetAttribute("value", value);
                    node.AppendChild(elem);
                }
                doc.Save(ConfigDosyasiYoluGetir());
            }
            catch
            {
                throw;
            }
        }

        public static void AyarlariSil(string key)
        {
         
            XmlDocument doc = ConfigDosyasiniYukle();

            // add elementi içinde değer
            XmlNode node = doc.SelectSingleNode("//appSettings");

            try
            {
                if (node == null)
                    throw new InvalidOperationException("appSettings kısmında böyle bir node yok");
                else
                {
                    // sil
                    node.RemoveChild(node.SelectSingleNode(string.Format("//add[@key='{0}']", key)));
                    doc.Save(ConfigDosyasiYoluGetir());
                }
            }
            catch (NullReferenceException e)
            {
                throw new Exception(string.Format("The key {0} does not exist.", key), e);
            }
        }

        private static XmlDocument ConfigDosyasiniYukle()
        {
            XmlDocument doc = null;
            try
            {
                doc = new XmlDocument();
                doc.Load(ConfigDosyasiYoluGetir());
                return doc;
            }
            catch (System.IO.FileNotFoundException e)
            {
                throw new Exception("No configuration file found.", e);
            }
        }

        private static string ConfigDosyasiYoluGetir()
        {
            return Assembly.GetExecutingAssembly().Location + ".config";
        }
    }
}