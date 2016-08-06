//===================================================================================
// Sio
// Sio
//===================================================================================

#region
using System;
using System.Configuration;
using System.Linq;
 
using System.Collections.Generic;
using System.ServiceModel;
 
 using System.Collections.ObjectModel;
 using AnaEkran.Static;

using System.Collections;
using System.Threading.Tasks;
using AnaEkran.Models;
using Zinderud;
#endregion

namespace  AnaEkran.Provider
{
 	public partial class Provider : IProvider
   {

    
 

		/// <summary>
        /// TBL_URUN ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public async Task<bool> Ekle__TBL_URUN_MODEL(TBL_URUN_MODEL item)
        {
        log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
		var sonuc = false;
            try
            {

               sonuc= await Client.Ekle__TBL_URUNAsync(Mapper.TBL_URUNMaping.ToDTO(item));
			   log.Info("EKLE__TBL_URUN sorgusuna gonderilen parametreler Arayüzden veritabanina eklenendi");

            }
             catch (Exception ex )
            {
			  log.Error("EKLE__TBL_URUN sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_URUN sil
        /// </summary>
        /// <param name="item">Item</param>
	    public async Task<bool>  Sil__TBL_URUN_MODEL(TBL_URUN_MODEL item)
        {
				var sonuc = false;
             log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

             try
            {
              sonuc=  await Client.Sil__TBL_URUNAsync(Mapper.TBL_URUNMaping.ToDTO(item));
			   log.Info("Sil__TBL_URUN sorgusuna gonderilen parametreler Arayüzden veritabanina eklenendi");

            }
             catch (Exception  ex)
            {
			  log.Error("Sil__TBL_URUN sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
			return sonuc;
        }
        /// <summary>
        /// TBL_URUN degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public async Task<bool> Degistir__TBL_URUN_MODEL(TBL_URUN_MODEL item)
        {
             log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

				var sonuc = false;

              try
            {
              sonuc= await Client.Degistir__TBL_URUNAsync(Mapper.TBL_URUNMaping.ToDTO(item));
			   log.Info("Degistir__TBL_URUN sorgusuna gonderilen parametreler Arayüzden  veritabanina eklenendi");

            }
             catch (Exception ex )
            {
			   log.Error("Degistir__TBL_URUN sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_URUN listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  async Task<ObservableCollection<TBL_URUN_MODEL>> Listele__TBL_URUN_MODEL()
        {
             log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

            try
            {
                return  CollectionUtils.ToObservableCollection(Mapper.TBL_URUNMaping.ToEntities( await Client.Listele__TBL_URUNAsync()));
			    log.Info("Listele__TBL_URUN sorgusuna gonderilen parametreler Arayüzden  veritabanina eklenendi");

            }
            catch (Exception ex)
            {
                return null;
			   log.Error("Listele__TBL_URUN sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
            }
       
        /// <summary>
        /// TBL_URUN Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  async Task<TBL_URUN_MODEL>  Bul_TBL_URUN_MODEL(int ID)
        {    
                 log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

                 try
                {            
                    return Mapper.TBL_URUNMaping.ToEntity( await Client.Bul_TBL_URUNAsync(ID));
                    log.Info("Bul_TBL_URUN sorgusuna gonderilen parametreler Arayüzden  veritabanina eklenendi");

            
                }
                catch (Exception ex)
                {

 				return null;
               log.Error("Bul_TBL_URUN sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex); 
                }
             
        }
   }
         
}
