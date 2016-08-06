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
	public partial class EntityTBL_KASA  :ITBL_KASA
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_KASA");



		/// <summary>
        /// TBL_KASA ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_KASA(TBL_KASADTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_KASA(ModelMapper.TBL_KASAMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_KASA sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_KASA sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_KASA sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_KASA(TBL_KASADTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_KASA silinecek =
              (from sil in context.TBL_KASA where 
              sil.TBL_KASA_ID == item.TBL_KASA_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_KASAMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_KASA sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_KASA sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_KASA degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_KASA(TBL_KASADTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_KASA where item.TBL_KASA_ID == d.TBL_KASA_ID select d).First();
                    degisecek = ModelMapper.TBL_KASAMaping.ToEntity(item);
                    context.TBL_KASA.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_KASA.Attach(ModelMapper.TBL_KASAMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_KASAMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_KASA sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_KASA sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_KASA listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_KASADTO> Listele__TBL_KASA( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_KASADTO> liste = new  List<TBL_KASADTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_KASA.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_KASAMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_KASA sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_KASA sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_KASA Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_KASADTO  Bul_TBL_KASA(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_KASA.ToList().Find(x=>x.TBL_KASA_ID==ID);;
                      TBL_KASADTO veri=new TBL_KASADTO();
			         veri=ModelMapper.TBL_KASAMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_KASA sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_KASA sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
