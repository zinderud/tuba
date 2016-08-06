using System.Threading.Tasks;
using AnaEkran.Models;
using AnaEkran.ZindeServiceReference;
// muratONUR murat ONUR karadeniz
// Tuba AnaEkran  Provider.cs
// 201312187:22 PM
// 201312187:22 PM
 
using System;
using System.ServiceModel;
using System.Threading;
using Zinderud;
namespace AnaEkran.Provider
{
    public partial class Provider : IProvider
    {
        #region Static
         private ZindeServiceClient Client { get; set; }

         private static readonly log4net.ILog log = log4net.LogManager.GetLogger("AnaEkran");

        public Provider()
        {
            try
            {
                Client = new ZindeServiceClient();




            }
            catch (Exception ex)
            {
                Client.Abort();
                Thread.Sleep(100);
                Client.Close();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                log.Fatal("Provider ActionServiceClient baglantı hatası", ex);
                if (Client.State == CommunicationState.Closed)
                {
                    Client = new ZindeServiceClient();
                }
            }

        }




        #endregion Static  

        
    }
}