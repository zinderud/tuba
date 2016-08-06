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
        /// TBL_DEPO_TRANSFER ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public async Task<bool> Ekle__TBL_DEPO_TRANSFER_MODEL(TBL_DEPO_TRANSFER_MODEL item)
        {
        log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
		var sonuc = false;
            try
            {

               sonuc= await Client.Ekle__TBL_DEPO_TRANSFERAsync(Mapper.TBL_DEPO_TRANSFERMaping.ToDTO(item));
			   log.Info("EKLE__TBL_DEPO_TRANSFER sorgusuna gonderilen parametreler Arayüzden veritabanina eklenendi");

            }
             catch (Exception ex )
            {
			  log.Error("EKLE__TBL_DEPO_TRANSFER sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_DEPO_TRANSFER sil
        /// </summary>
        /// <param name="item">Item</param>
	    public async Task<bool>  Sil__TBL_DEPO_TRANSFER_MODEL(TBL_DEPO_TRANSFER_MODEL item)
        {
				var sonuc = false;
             log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

             try
            {
              sonuc=  await Client.Sil__TBL_DEPO_TRANSFERAsync(Mapper.TBL_DEPO_TRANSFERMaping.ToDTO(item));
			   log.Info("Sil__TBL_DEPO_TRANSFER sorgusuna gonderilen parametreler Arayüzden veritabanina eklenendi");

            }
             catch (Exception  ex)
            {
			  log.Error("Sil__TBL_DEPO_TRANSFER sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
			return sonuc;
        }
        /// <summary>
        /// TBL_DEPO_TRANSFER degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public async Task<bool> Degistir__TBL_DEPO_TRANSFER_MODEL(TBL_DEPO_TRANSFER_MODEL item)
        {
             log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

				var sonuc = false;

              try
            {
              sonuc= await Client.Degistir__TBL_DEPO_TRANSFERAsync(Mapper.TBL_DEPO_TRANSFERMaping.ToDTO(item));
			   log.Info("Degistir__TBL_DEPO_TRANSFER sorgusuna gonderilen parametreler Arayüzden  veritabanina eklenendi");

            }
             catch (Exception ex )
            {
			   log.Error("Degistir__TBL_DEPO_TRANSFER sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_DEPO_TRANSFER listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  async Task<ObservableCollection<TBL_DEPO_TRANSFER_MODEL>> Listele__TBL_DEPO_TRANSFER_MODEL()
        {
             log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

            try
            {
                return  CollectionUtils.ToObservableCollection(Mapper.TBL_DEPO_TRANSFERMaping.ToEntities( await Client.Listele__TBL_DEPO_TRANSFERAsync()));
			    log.Info("Listele__TBL_DEPO_TRANSFER sorgusuna gonderilen parametreler Arayüzden  veritabanina eklenendi");

            }
            catch (Exception ex)
            {
                return null;
			   log.Error("Listele__TBL_DEPO_TRANSFER sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex);

            }
            }
       
        /// <summary>
        /// TBL_DEPO_TRANSFER Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  async Task<TBL_DEPO_TRANSFER_MODEL>  Bul_TBL_DEPO_TRANSFER_MODEL(int ID)
        {    
                 log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());

                 try
                {            
                    return Mapper.TBL_DEPO_TRANSFERMaping.ToEntity( await Client.Bul_TBL_DEPO_TRANSFERAsync(ID));
                    log.Info("Bul_TBL_DEPO_TRANSFER sorgusuna gonderilen parametreler Arayüzden  veritabanina eklenendi");

            
                }
                catch (Exception ex)
                {

 				return null;
               log.Error("Bul_TBL_DEPO_TRANSFER sorgusuna gonderilen parametreler Arayüzden veritabanina eklenemedi",ex); 
                }
             
        }
   }
         
}
