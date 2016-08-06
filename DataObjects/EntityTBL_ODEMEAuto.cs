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
	public partial class EntityTBL_ODEME  :ITBL_ODEME
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_ODEME");



		/// <summary>
        /// TBL_ODEME ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_ODEME(TBL_ODEMEDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_ODEME(ModelMapper.TBL_ODEMEMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_ODEME sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_ODEME sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_ODEME sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_ODEME(TBL_ODEMEDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_ODEME silinecek =
              (from sil in context.TBL_ODEME where 
              sil.TBL_ODEME_ID == item.TBL_ODEME_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_ODEMEMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_ODEME sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_ODEME sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_ODEME degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_ODEME(TBL_ODEMEDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_ODEME where item.TBL_ODEME_ID == d.TBL_ODEME_ID select d).First();
                    degisecek = ModelMapper.TBL_ODEMEMaping.ToEntity(item);
                    context.TBL_ODEME.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_ODEME.Attach(ModelMapper.TBL_ODEMEMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_ODEMEMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_ODEME sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_ODEME sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_ODEME listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_ODEMEDTO> Listele__TBL_ODEME( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_ODEMEDTO> liste = new  List<TBL_ODEMEDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_ODEME.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_ODEMEMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_ODEME sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_ODEME sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_ODEME Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_ODEMEDTO  Bul_TBL_ODEME(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_ODEME.ToList().Find(x=>x.TBL_ODEME_ID==ID);;
                      TBL_ODEMEDTO veri=new TBL_ODEMEDTO();
			         veri=ModelMapper.TBL_ODEMEMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_ODEME sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_ODEME sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
