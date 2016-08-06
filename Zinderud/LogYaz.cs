//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using Log;
//namespace Zinderud
//{
//    public class LogYaz
//    {
//        private string Msj;

//        public delegate void LOGEventHandler(object sender, EventArgs e);

//        public event LOGEventHandler logevent;

//        /// <summary>
//        /// log kısmının calısabilmesi için event olusturur
//        /// </summary>
//        /// <param name="sorgu"></param>
//        public LogYaz(string msj)
//        {
//            Msj = msj;
//            logevent += new LOGEventHandler(loglama);
//            logevent(this, new EventArgs());
//        }

//        /// <summary>
//        /// log methodu tarafından olusturulan eventtır. 
//        /// En son kaydedilen txt dosyasını bulur ve dosyaya hangi sorgunun çalıstırıldıgını yazar.
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        public void loglama(object sender, EventArgs e)
//        {

//            ArrayList ad = new ArrayList();
//            //string[] dizindekiDosyalar = Directory.GetFiles("D:\\Zinde\\Zinde\\log_kayitlari\\");
//            //foreach (var item in dizindekiDosyalar)
//            //{
//            //    FileInfo fileInfo = new FileInfo(item);
//            //    ad.Add(fileInfo.Name);
//            //}
//            //ad.Sort();
//            //string sondosya = ad[ad.Count-1 ].ToString();
//            //Exception ex = new Exception();
//            //LogEventArgs log = new LogEventArgs(LogSeverity.Debug, ex, Msj, DateTime.Now);
//            //ObserverLogToFile dosya = new ObserverLogToFile("D:\\Zinde\\Zinde\\log_kayitlari\\" + sondosya);
//            //dosya.Log(sender, log);
//        }
//    }
//}
