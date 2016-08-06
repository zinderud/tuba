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
	public partial class EntityTBL_URUN_SPARIS  :ITBL_URUN_SPARIS
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_URUN_SPARIS");



		/// <summary>
        /// TBL_URUN_SPARIS ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_URUN_SPARIS(TBL_URUN_SPARISDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_URUN_SPARIS(ModelMapper.TBL_URUN_SPARISMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_URUN_SPARIS sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_URUN_SPARIS sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_URUN_SPARIS sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_URUN_SPARIS(TBL_URUN_SPARISDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_URUN_SPARIS silinecek =
              (from sil in context.TBL_URUN_SPARIS where 
              sil.TBL_URUN_SPARIS_ID == item.TBL_URUN_SPARIS_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_URUN_SPARISMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_URUN_SPARIS sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_URUN_SPARIS sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_URUN_SPARIS degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_URUN_SPARIS(TBL_URUN_SPARISDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_URUN_SPARIS where item.TBL_URUN_SPARIS_ID == d.TBL_URUN_SPARIS_ID select d).First();
                    degisecek = ModelMapper.TBL_URUN_SPARISMaping.ToEntity(item);
                    context.TBL_URUN_SPARIS.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_URUN_SPARIS.Attach(ModelMapper.TBL_URUN_SPARISMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_URUN_SPARISMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_URUN_SPARIS sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_URUN_SPARIS sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_URUN_SPARIS listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_URUN_SPARISDTO> Listele__TBL_URUN_SPARIS( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_URUN_SPARISDTO> liste = new  List<TBL_URUN_SPARISDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_URUN_SPARIS.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_URUN_SPARISMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_URUN_SPARIS sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_URUN_SPARIS sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_URUN_SPARIS Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_URUN_SPARISDTO  Bul_TBL_URUN_SPARIS(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_URUN_SPARIS.ToList().Find(x=>x.TBL_URUN_SPARIS_ID==ID);;
                      TBL_URUN_SPARISDTO veri=new TBL_URUN_SPARISDTO();
			         veri=ModelMapper.TBL_URUN_SPARISMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_URUN_SPARIS sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_URUN_SPARIS sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
