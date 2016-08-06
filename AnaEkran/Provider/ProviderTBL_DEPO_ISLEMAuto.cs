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
        /// TBL_DEPO_ISLEM ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public async Task<bool> Ekle__TBL_DEPO_ISLEM_MODEL(TBL_DEPO_ISLEM_MODEL item)
        {
        log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
		var sonuc = false;
            try
            {

               sonuc= await Client.Ekle__TBL_DEPO_ISLEMAsync(Mapper.TBL_DEPO_ISLEMMaping.ToDTO(item));
			   log.Info("EKLE__TBL_DEPO_ISLEM sorgusuna gonderilen parametreler Arayüzden veritabanina eklenendi");

            }
             catch (Exception ex )
            {
			  log.Error("EKLE__TBL_DEPO_ISLEM sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_DEPO_ISLEM sil
        /// </summary>
        /// <param name="item">Item</param>
	    public async Task<bool>  Sil__TBL_DEPO_ISLEM_MODEL(TBL_DEPO_ISLEM_MODEL item)
        {
				var sonuc = false;
             log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

             try
            {
              sonuc=  await Client.Sil__TBL_DEPO_ISLEMAsync(Mapper.TBL_DEPO_ISLEMMaping.ToDTO(item));
			   log.Info("Sil__TBL_DEPO_ISLEM sorgusuna gonderilen parametreler Arayüzden veritabanina eklenendi");

            }
             catch (Exception  ex)
            {
			  log.Error("Sil__TBL_DEPO_ISLEM sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
			return sonuc;
        }
        /// <summary>
        /// TBL_DEPO_ISLEM degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public async Task<bool> Degistir__TBL_DEPO_ISLEM_MODEL(TBL_DEPO_ISLEM_MODEL item)
        {
             log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

				var sonuc = false;

              try
            {
              sonuc= await Client.Degistir__TBL_DEPO_ISLEMAsync(Mapper.TBL_DEPO_ISLEMMaping.ToDTO(item));
			   log.Info("Degistir__TBL_DEPO_ISLEM sorgusuna gonderilen parametreler Arayüzden  veritabanina eklenendi");

            }
             catch (Exception ex )
            {
			   log.Error("Degistir__TBL_DEPO_ISLEM sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_DEPO_ISLEM listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  async Task<ObservableCollection<TBL_DEPO_ISLEM_MODEL>> Listele__TBL_DEPO_ISLEM_MODEL()
        {
             log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

            try
            {
                return  CollectionUtils.ToObservableCollection(Mapper.TBL_DEPO_ISLEMMaping.ToEntities( await Client.Listele__TBL_DEPO_ISLEMAsync()));
			    log.Info("Listele__TBL_DEPO_ISLEM sorgusuna gonderilen parametreler Arayüzden  veritabanina eklenendi");

            }
            catch (Exception ex)
            {
                return null;
			   log.Error("Listele__TBL_DEPO_ISLEM sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
            }
       
        /// <summary>
        /// TBL_DEPO_ISLEM Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  async Task<TBL_DEPO_ISLEM_MODEL>  Bul_TBL_DEPO_ISLEM_MODEL(int ID)
        {    
                 log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

                 try
                {            
                    return Mapper.TBL_DEPO_ISLEMMaping.ToEntity( await Client.Bul_TBL_DEPO_ISLEMAsync(ID));
                    log.Info("Bul_TBL_DEPO_ISLEM sorgusuna gonderilen parametreler Arayüzden  veritabanina eklenendi");

            
                }
                catch (Exception ex)
                {

 				return null;
               log.Error("Bul_TBL_DEPO_ISLEM sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex); 
                }
             
        }
   }
         
}
