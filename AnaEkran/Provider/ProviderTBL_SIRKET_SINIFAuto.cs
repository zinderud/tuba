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
        /// TBL_SIRKET_SINIF ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public async Task<bool> Ekle__TBL_SIRKET_SINIF_MODEL(TBL_SIRKET_SINIF_MODEL item)
        {
        log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
		var sonuc = false;
            try
            {

               sonuc= await Client.Ekle__TBL_SIRKET_SINIFAsync(Mapper.TBL_SIRKET_SINIFMaping.ToDTO(item));
			   log.Info("EKLE__TBL_SIRKET_SINIF sorgusuna gonderilen parametreler Arayüzden veritabanina eklenendi");

            }
             catch (Exception ex )
            {
			  log.Error("EKLE__TBL_SIRKET_SINIF sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_SIRKET_SINIF sil
        /// </summary>
        /// <param name="item">Item</param>
	    public async Task<bool>  Sil__TBL_SIRKET_SINIF_MODEL(TBL_SIRKET_SINIF_MODEL item)
        {
				var sonuc = false;
             log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

             try
            {
              sonuc=  await Client.Sil__TBL_SIRKET_SINIFAsync(Mapper.TBL_SIRKET_SINIFMaping.ToDTO(item));
			   log.Info("Sil__TBL_SIRKET_SINIF sorgusuna gonderilen parametreler Arayüzden veritabanina eklenendi");

            }
             catch (Exception  ex)
            {
			  log.Error("Sil__TBL_SIRKET_SINIF sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
			return sonuc;
        }
        /// <summary>
        /// TBL_SIRKET_SINIF degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public async Task<bool> Degistir__TBL_SIRKET_SINIF_MODEL(TBL_SIRKET_SINIF_MODEL item)
        {
             log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

				var sonuc = false;

              try
            {
              sonuc= await Client.Degistir__TBL_SIRKET_SINIFAsync(Mapper.TBL_SIRKET_SINIFMaping.ToDTO(item));
			   log.Info("Degistir__TBL_SIRKET_SINIF sorgusuna gonderilen parametreler Arayüzden  veritabanina eklenendi");

            }
             catch (Exception ex )
            {
			   log.Error("Degistir__TBL_SIRKET_SINIF sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_SIRKET_SINIF listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  async Task<ObservableCollection<TBL_SIRKET_SINIF_MODEL>> Listele__TBL_SIRKET_SINIF_MODEL()
        {
             log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

            try
            {
                return  CollectionUtils.ToObservableCollection(Mapper.TBL_SIRKET_SINIFMaping.ToEntities( await Client.Listele__TBL_SIRKET_SINIFAsync()));
			    log.Info("Listele__TBL_SIRKET_SINIF sorgusuna gonderilen parametreler Arayüzden  veritabanina eklenendi");

            }
            catch (Exception ex)
            {
                return null;
			   log.Error("Listele__TBL_SIRKET_SINIF sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
            }
       
        /// <summary>
        /// TBL_SIRKET_SINIF Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  async Task<TBL_SIRKET_SINIF_MODEL>  Bul_TBL_SIRKET_SINIF_MODEL(int ID)
        {    
                 log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

                 try
                {            
                    return Mapper.TBL_SIRKET_SINIFMaping.ToEntity( await Client.Bul_TBL_SIRKET_SINIFAsync(ID));
                    log.Info("Bul_TBL_SIRKET_SINIF sorgusuna gonderilen parametreler Arayüzden  veritabanina eklenendi");

            
                }
                catch (Exception ex)
                {

 				return null;
               log.Error("Bul_TBL_SIRKET_SINIF sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex); 
                }
             
        }
   }
         
}
