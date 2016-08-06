//===================================================================================
// Sio
// Sio
//===================================================================================

#region
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AutoBusinessObjects;
using Zinderud;
#endregion

namespace DataObjects.EntityFramework.Implementation
{
	public partial class EntityTBL_DEPO_TRANSFER  :ITBL_DEPO_TRANSFER
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_DEPO_TRANSFER");



		/// <summary>
        /// TBL_DEPO_TRANSFER ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_DEPO_TRANSFER(TBL_DEPO_TRANSFERDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_DEPO_TRANSFER(ModelMapper.TBL_DEPO_TRANSFERMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_DEPO_TRANSFER sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_DEPO_TRANSFER sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_DEPO_TRANSFER sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_DEPO_TRANSFER(TBL_DEPO_TRANSFERDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_DEPO_TRANSFER silinecek =
              (from sil in context.TBL_DEPO_TRANSFER where 
              sil.TBL_DEPO_TRANSFER_ID == item.TBL_DEPO_TRANSFER_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_DEPO_TRANSFERMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_DEPO_TRANSFER sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_DEPO_TRANSFER sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_DEPO_TRANSFER degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_DEPO_TRANSFER(TBL_DEPO_TRANSFERDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_DEPO_TRANSFER where item.TBL_DEPO_TRANSFER_ID == d.TBL_DEPO_TRANSFER_ID select d).First();
                    degisecek = ModelMapper.TBL_DEPO_TRANSFERMaping.ToEntity(item);
                    context.TBL_DEPO_TRANSFER.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_DEPO_TRANSFER.Attach(ModelMapper.TBL_DEPO_TRANSFERMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_DEPO_TRANSFERMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_DEPO_TRANSFER sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_DEPO_TRANSFER sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_DEPO_TRANSFER listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_DEPO_TRANSFERDTO> Listele__TBL_DEPO_TRANSFER( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_DEPO_TRANSFERDTO> liste = new  List<TBL_DEPO_TRANSFERDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_DEPO_TRANSFER.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_DEPO_TRANSFERMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_DEPO_TRANSFER sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_DEPO_TRANSFER sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_DEPO_TRANSFER Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_DEPO_TRANSFERDTO  Bul_TBL_DEPO_TRANSFER(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_DEPO_TRANSFER.ToList().Find(x=>x.TBL_DEPO_TRANSFER_ID==ID);;
                      TBL_DEPO_TRANSFERDTO veri=new TBL_DEPO_TRANSFERDTO();
			         veri=ModelMapper.TBL_DEPO_TRANSFERMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_DEPO_TRANSFER sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_DEPO_TRANSFER sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
