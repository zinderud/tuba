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
	public partial class EntityTBL_URUN_CINSI  :ITBL_URUN_CINSI
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_URUN_CINSI");



		/// <summary>
        /// TBL_URUN_CINSI ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_URUN_CINSI(TBL_URUN_CINSIDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_URUN_CINSI(ModelMapper.TBL_URUN_CINSIMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_URUN_CINSI sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_URUN_CINSI sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_URUN_CINSI sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_URUN_CINSI(TBL_URUN_CINSIDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_URUN_CINSI silinecek =
              (from sil in context.TBL_URUN_CINSI where 
              sil.TBL_URUN_CINSI_ID == item.TBL_URUN_CINSI_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_URUN_CINSIMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_URUN_CINSI sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_URUN_CINSI sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_URUN_CINSI degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_URUN_CINSI(TBL_URUN_CINSIDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_URUN_CINSI where item.TBL_URUN_CINSI_ID == d.TBL_URUN_CINSI_ID select d).First();
                    degisecek = ModelMapper.TBL_URUN_CINSIMaping.ToEntity(item);
                    context.TBL_URUN_CINSI.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_URUN_CINSI.Attach(ModelMapper.TBL_URUN_CINSIMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_URUN_CINSIMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_URUN_CINSI sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_URUN_CINSI sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_URUN_CINSI listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_URUN_CINSIDTO> Listele__TBL_URUN_CINSI( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_URUN_CINSIDTO> liste = new  List<TBL_URUN_CINSIDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_URUN_CINSI.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_URUN_CINSIMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_URUN_CINSI sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_URUN_CINSI sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_URUN_CINSI Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_URUN_CINSIDTO  Bul_TBL_URUN_CINSI(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_URUN_CINSI.ToList().Find(x=>x.TBL_URUN_CINSI_ID==ID);;
                      TBL_URUN_CINSIDTO veri=new TBL_URUN_CINSIDTO();
			         veri=ModelMapper.TBL_URUN_CINSIMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_URUN_CINSI sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_URUN_CINSI sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
