using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using ZindeService.ServiceContracts;

namespace ServerUygulamasi
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(ZindeService.ServiceImplementations.ZindeService));

          //var  host = new ServiceHost(typeof(ZindeService.ServiceImplementations.ZindeService));
          //  host.AddServiceEndpoint(typeof(IZindeService), new NetTcpBinding(), "net.tcp://localhost:3014/ActionService");
            //srvHost.Open();


            //host.Open();
            //Console.WriteLine("Sunucu  dinlemede...");
            //Console.ReadLine();
            //host.Close();
            //ServiceHost host = new ServiceHost(
            //    typeof(ActionService.ServiceImplementations.ActionService)
            //    );
            host.Opened += (o, e) =>
            {
                Console.WriteLine("Servis dinlemede");
            };
            host.Closed += (o, e) =>
            {
                Console.WriteLine("Servis kapatıldı");
            };
            host.Open();
            Console.WriteLine("Çıkmak için bir tuşa basınız");
            Console.ReadLine();
            host.Close();
        }


    }
}
