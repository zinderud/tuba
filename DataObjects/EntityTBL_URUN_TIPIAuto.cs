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
	public partial class EntityTBL_URUN_TIPI  :ITBL_URUN_TIPI
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_URUN_TIPI");



		/// <summary>
        /// TBL_URUN_TIPI ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_URUN_TIPI(TBL_URUN_TIPIDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_URUN_TIPI(ModelMapper.TBL_URUN_TIPIMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_URUN_TIPI sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_URUN_TIPI sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_URUN_TIPI sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_URUN_TIPI(TBL_URUN_TIPIDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_URUN_TIPI silinecek =
              (from sil in context.TBL_URUN_TIPI where 
              sil.TBL_URUN_TIPI_ID == item.TBL_URUN_TIPI_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_URUN_TIPIMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_URUN_TIPI sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_URUN_TIPI sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_URUN_TIPI degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_URUN_TIPI(TBL_URUN_TIPIDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_URUN_TIPI where item.TBL_URUN_TIPI_ID == d.TBL_URUN_TIPI_ID select d).First();
                    degisecek = ModelMapper.TBL_URUN_TIPIMaping.ToEntity(item);
                    context.TBL_URUN_TIPI.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_URUN_TIPI.Attach(ModelMapper.TBL_URUN_TIPIMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_URUN_TIPIMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_URUN_TIPI sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_URUN_TIPI sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_URUN_TIPI listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_URUN_TIPIDTO> Listele__TBL_URUN_TIPI( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_URUN_TIPIDTO> liste = new  List<TBL_URUN_TIPIDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_URUN_TIPI.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_URUN_TIPIMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_URUN_TIPI sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_URUN_TIPI sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_URUN_TIPI Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_URUN_TIPIDTO  Bul_TBL_URUN_TIPI(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_URUN_TIPI.ToList().Find(x=>x.TBL_URUN_TIPI_ID==ID);;
                      TBL_URUN_TIPIDTO veri=new TBL_URUN_TIPIDTO();
			         veri=ModelMapper.TBL_URUN_TIPIMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_URUN_TIPI sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_URUN_TIPI sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
