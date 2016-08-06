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
	public partial class EntityTBL_DEPO_ISLEM  :ITBL_DEPO_ISLEM
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_DEPO_ISLEM");



		/// <summary>
        /// TBL_DEPO_ISLEM ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_DEPO_ISLEM(TBL_DEPO_ISLEMDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_DEPO_ISLEM(ModelMapper.TBL_DEPO_ISLEMMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_DEPO_ISLEM sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_DEPO_ISLEM sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_DEPO_ISLEM sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_DEPO_ISLEM(TBL_DEPO_ISLEMDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_DEPO_ISLEM silinecek =
              (from sil in context.TBL_DEPO_ISLEM where 
              sil.TBL_DEPO_ISLEM_ID == item.TBL_DEPO_ISLEM_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_DEPO_ISLEMMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_DEPO_ISLEM sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_DEPO_ISLEM sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_DEPO_ISLEM degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_DEPO_ISLEM(TBL_DEPO_ISLEMDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_DEPO_ISLEM where item.TBL_DEPO_ISLEM_ID == d.TBL_DEPO_ISLEM_ID select d).First();
                    degisecek = ModelMapper.TBL_DEPO_ISLEMMaping.ToEntity(item);
                    context.TBL_DEPO_ISLEM.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_DEPO_ISLEM.Attach(ModelMapper.TBL_DEPO_ISLEMMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_DEPO_ISLEMMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_DEPO_ISLEM sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_DEPO_ISLEM sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_DEPO_ISLEM listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_DEPO_ISLEMDTO> Listele__TBL_DEPO_ISLEM( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_DEPO_ISLEMDTO> liste = new  List<TBL_DEPO_ISLEMDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_DEPO_ISLEM.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_DEPO_ISLEMMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_DEPO_ISLEM sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_DEPO_ISLEM sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_DEPO_ISLEM Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_DEPO_ISLEMDTO  Bul_TBL_DEPO_ISLEM(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_DEPO_ISLEM.ToList().Find(x=>x.TBL_DEPO_ISLEM_ID==ID);;
                      TBL_DEPO_ISLEMDTO veri=new TBL_DEPO_ISLEMDTO();
			         veri=ModelMapper.TBL_DEPO_ISLEMMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_DEPO_ISLEM sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_DEPO_ISLEM sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
