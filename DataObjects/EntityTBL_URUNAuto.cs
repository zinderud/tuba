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
	public partial class EntityTBL_URUN  :ITBL_URUN
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_URUN");



		/// <summary>
        /// TBL_URUN ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_URUN(TBL_URUNDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_URUN(ModelMapper.TBL_URUNMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_URUN sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_URUN sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_URUN sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_URUN(TBL_URUNDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_URUN silinecek =
              (from sil in context.TBL_URUN where 
              sil.TBL_URUN_ID == item.TBL_URUN_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_URUNMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_URUN sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_URUN sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_URUN degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_URUN(TBL_URUNDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_URUN where item.TBL_URUN_ID == d.TBL_URUN_ID select d).First();
                    degisecek = ModelMapper.TBL_URUNMaping.ToEntity(item);
                    context.TBL_URUN.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_URUN.Attach(ModelMapper.TBL_URUNMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_URUNMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_URUN sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_URUN sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_URUN listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_URUNDTO> Listele__TBL_URUN( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_URUNDTO> liste = new  List<TBL_URUNDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_URUN.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_URUNMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_URUN sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_URUN sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_URUN Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_URUNDTO  Bul_TBL_URUN(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_URUN.ToList().Find(x=>x.TBL_URUN_ID==ID);;
                      TBL_URUNDTO veri=new TBL_URUNDTO();
			         veri=ModelMapper.TBL_URUNMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_URUN sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_URUN sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
