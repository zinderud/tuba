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
	public partial class EntityTBL_SIRKET_SINIF  :ITBL_SIRKET_SINIF
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_SIRKET_SINIF");



		/// <summary>
        /// TBL_SIRKET_SINIF ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_SIRKET_SINIF(TBL_SIRKET_SINIFDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_SIRKET_SINIF(ModelMapper.TBL_SIRKET_SINIFMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_SIRKET_SINIF sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_SIRKET_SINIF sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_SIRKET_SINIF sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_SIRKET_SINIF(TBL_SIRKET_SINIFDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_SIRKET_SINIF silinecek =
              (from sil in context.TBL_SIRKET_SINIF where 
              sil.TBL_SIRKET_SINIF_ID == item.TBL_SIRKET_SINIF_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_SIRKET_SINIFMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_SIRKET_SINIF sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_SIRKET_SINIF sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_SIRKET_SINIF degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_SIRKET_SINIF(TBL_SIRKET_SINIFDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_SIRKET_SINIF where item.TBL_SIRKET_SINIF_ID == d.TBL_SIRKET_SINIF_ID select d).First();
                    degisecek = ModelMapper.TBL_SIRKET_SINIFMaping.ToEntity(item);
                    context.TBL_SIRKET_SINIF.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_SIRKET_SINIF.Attach(ModelMapper.TBL_SIRKET_SINIFMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_SIRKET_SINIFMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_SIRKET_SINIF sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_SIRKET_SINIF sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_SIRKET_SINIF listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_SIRKET_SINIFDTO> Listele__TBL_SIRKET_SINIF( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_SIRKET_SINIFDTO> liste = new  List<TBL_SIRKET_SINIFDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_SIRKET_SINIF.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_SIRKET_SINIFMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_SIRKET_SINIF sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_SIRKET_SINIF sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_SIRKET_SINIF Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_SIRKET_SINIFDTO  Bul_TBL_SIRKET_SINIF(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_SIRKET_SINIF.ToList().Find(x=>x.TBL_SIRKET_SINIF_ID==ID);;
                      TBL_SIRKET_SINIFDTO veri=new TBL_SIRKET_SINIFDTO();
			         veri=ModelMapper.TBL_SIRKET_SINIFMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_SIRKET_SINIF sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_SIRKET_SINIF sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
