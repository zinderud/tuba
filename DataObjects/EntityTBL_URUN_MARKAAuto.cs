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
	public partial class EntityTBL_URUN_MARKA  :ITBL_URUN_MARKA
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_URUN_MARKA");



		/// <summary>
        /// TBL_URUN_MARKA ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_URUN_MARKA(TBL_URUN_MARKADTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_URUN_MARKA(ModelMapper.TBL_URUN_MARKAMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_URUN_MARKA sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_URUN_MARKA sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_URUN_MARKA sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_URUN_MARKA(TBL_URUN_MARKADTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_URUN_MARKA silinecek =
              (from sil in context.TBL_URUN_MARKA where 
              sil.TBL_URUN_MARKA_ID == item.TBL_URUN_MARKA_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_URUN_MARKAMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_URUN_MARKA sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_URUN_MARKA sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_URUN_MARKA degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_URUN_MARKA(TBL_URUN_MARKADTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_URUN_MARKA where item.TBL_URUN_MARKA_ID == d.TBL_URUN_MARKA_ID select d).First();
                    degisecek = ModelMapper.TBL_URUN_MARKAMaping.ToEntity(item);
                    context.TBL_URUN_MARKA.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_URUN_MARKA.Attach(ModelMapper.TBL_URUN_MARKAMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_URUN_MARKAMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_URUN_MARKA sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_URUN_MARKA sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_URUN_MARKA listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_URUN_MARKADTO> Listele__TBL_URUN_MARKA( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_URUN_MARKADTO> liste = new  List<TBL_URUN_MARKADTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_URUN_MARKA.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_URUN_MARKAMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_URUN_MARKA sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_URUN_MARKA sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_URUN_MARKA Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_URUN_MARKADTO  Bul_TBL_URUN_MARKA(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_URUN_MARKA.ToList().Find(x=>x.TBL_URUN_MARKA_ID==ID);;
                      TBL_URUN_MARKADTO veri=new TBL_URUN_MARKADTO();
			         veri=ModelMapper.TBL_URUN_MARKAMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_URUN_MARKA sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_URUN_MARKA sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
