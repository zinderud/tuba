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
        /// TBL_PARA_TIPI ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public async Task<bool> Ekle__TBL_PARA_TIPI_MODEL(TBL_PARA_TIPI_MODEL item)
        {
        log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
		var sonuc = false;
            try
            {

               sonuc= await Client.Ekle__TBL_PARA_TIPIAsync(Mapper.TBL_PARA_TIPIMaping.ToDTO(item));
			   log.Info("EKLE__TBL_PARA_TIPI sorgusuna gonderilen parametreler Arayüzden veritabanina eklenendi");

            }
             catch (Exception ex )
            {
			  log.Error("EKLE__TBL_PARA_TIPI sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_PARA_TIPI sil
        /// </summary>
        /// <param name="item">Item</param>
	    public async Task<bool>  Sil__TBL_PARA_TIPI_MODEL(TBL_PARA_TIPI_MODEL item)
        {
				var sonuc = false;
             log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

             try
            {
              sonuc=  await Client.Sil__TBL_PARA_TIPIAsync(Mapper.TBL_PARA_TIPIMaping.ToDTO(item));
			   log.Info("Sil__TBL_PARA_TIPI sorgusuna gonderilen parametreler Arayüzden veritabanina eklenendi");

            }
             catch (Exception  ex)
            {
			  log.Error("Sil__TBL_PARA_TIPI sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
			return sonuc;
        }
        /// <summary>
        /// TBL_PARA_TIPI degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public async Task<bool> Degistir__TBL_PARA_TIPI_MODEL(TBL_PARA_TIPI_MODEL item)
        {
             log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

				var sonuc = false;

              try
            {
              sonuc= await Client.Degistir__TBL_PARA_TIPIAsync(Mapper.TBL_PARA_TIPIMaping.ToDTO(item));
			   log.Info("Degistir__TBL_PARA_TIPI sorgusuna gonderilen parametreler Arayüzden  veritabanina eklenendi");

            }
             catch (Exception ex )
            {
			   log.Error("Degistir__TBL_PARA_TIPI sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_PARA_TIPI listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  async Task<ObservableCollection<TBL_PARA_TIPI_MODEL>> Listele__TBL_PARA_TIPI_MODEL()
        {
             log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

            try
            {
                return  CollectionUtils.ToObservableCollection(Mapper.TBL_PARA_TIPIMaping.ToEntities( await Client.Listele__TBL_PARA_TIPIAsync()));
			    log.Info("Listele__TBL_PARA_TIPI sorgusuna gonderilen parametreler Arayüzden  veritabanina eklenendi");

            }
            catch (Exception ex)
            {
                return null;
			   log.Error("Listele__TBL_PARA_TIPI sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
            }
       
        /// <summary>
        /// TBL_PARA_TIPI Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  async Task<TBL_PARA_TIPI_MODEL>  Bul_TBL_PARA_TIPI_MODEL(int ID)
        {    
                 log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

                 try
                {            
                    return Mapper.TBL_PARA_TIPIMaping.ToEntity( await Client.Bul_TBL_PARA_TIPIAsync(ID));
                    log.Info("Bul_TBL_PARA_TIPI sorgusuna gonderilen parametreler Arayüzden  veritabanina eklenendi");

            
                }
                catch (Exception ex)
                {

 				return null;
               log.Error("Bul_TBL_PARA_TIPI sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex); 
                }
             
        }
   }
         
}
