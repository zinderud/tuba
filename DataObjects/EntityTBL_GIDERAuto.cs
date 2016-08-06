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
	public partial class EntityTBL_GIDER  :ITBL_GIDER
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_GIDER");



		/// <summary>
        /// TBL_GIDER ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_GIDER(TBL_GIDERDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_GIDER(ModelMapper.TBL_GIDERMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_GIDER sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_GIDER sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_GIDER sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_GIDER(TBL_GIDERDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_GIDER silinecek =
              (from sil in context.TBL_GIDER where 
              sil.TBL_GIDER_ID == item.TBL_GIDER_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_GIDERMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_GIDER sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_GIDER sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_GIDER degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_GIDER(TBL_GIDERDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_GIDER where item.TBL_GIDER_ID == d.TBL_GIDER_ID select d).First();
                    degisecek = ModelMapper.TBL_GIDERMaping.ToEntity(item);
                    context.TBL_GIDER.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_GIDER.Attach(ModelMapper.TBL_GIDERMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_GIDERMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_GIDER sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_GIDER sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_GIDER listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_GIDERDTO> Listele__TBL_GIDER( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_GIDERDTO> liste = new  List<TBL_GIDERDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_GIDER.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_GIDERMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_GIDER sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_GIDER sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_GIDER Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_GIDERDTO  Bul_TBL_GIDER(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_GIDER.ToList().Find(x=>x.TBL_GIDER_ID==ID);;
                      TBL_GIDERDTO veri=new TBL_GIDERDTO();
			         veri=ModelMapper.TBL_GIDERMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_GIDER sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_GIDER sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
