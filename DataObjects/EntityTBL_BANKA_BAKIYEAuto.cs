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
	public partial class EntityTBL_BANKA_BAKIYE  :ITBL_BANKA_BAKIYE
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_BANKA_BAKIYE");



		/// <summary>
        /// TBL_BANKA_BAKIYE ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_BANKA_BAKIYE(TBL_BANKA_BAKIYEDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_BANKA_BAKIYE(ModelMapper.TBL_BANKA_BAKIYEMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_BANKA_BAKIYE sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_BANKA_BAKIYE sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_BANKA_BAKIYE sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_BANKA_BAKIYE(TBL_BANKA_BAKIYEDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_BANKA_BAKIYE silinecek =
              (from sil in context.TBL_BANKA_BAKIYE where 
              sil.TBL_BANKA_BAKIYE_ID == item.TBL_BANKA_BAKIYE_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_BANKA_BAKIYEMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_BANKA_BAKIYE sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_BANKA_BAKIYE sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_BANKA_BAKIYE degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_BANKA_BAKIYE(TBL_BANKA_BAKIYEDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_BANKA_BAKIYE where item.TBL_BANKA_BAKIYE_ID == d.TBL_BANKA_BAKIYE_ID select d).First();
                    degisecek = ModelMapper.TBL_BANKA_BAKIYEMaping.ToEntity(item);
                    context.TBL_BANKA_BAKIYE.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_BANKA_BAKIYE.Attach(ModelMapper.TBL_BANKA_BAKIYEMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_BANKA_BAKIYEMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_BANKA_BAKIYE sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_BANKA_BAKIYE sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_BANKA_BAKIYE listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_BANKA_BAKIYEDTO> Listele__TBL_BANKA_BAKIYE( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_BANKA_BAKIYEDTO> liste = new  List<TBL_BANKA_BAKIYEDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_BANKA_BAKIYE.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_BANKA_BAKIYEMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_BANKA_BAKIYE sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_BANKA_BAKIYE sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_BANKA_BAKIYE Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_BANKA_BAKIYEDTO  Bul_TBL_BANKA_BAKIYE(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_BANKA_BAKIYE.ToList().Find(x=>x.TBL_BANKA_BAKIYE_ID==ID);;
                      TBL_BANKA_BAKIYEDTO veri=new TBL_BANKA_BAKIYEDTO();
			         veri=ModelMapper.TBL_BANKA_BAKIYEMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_BANKA_BAKIYE sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_BANKA_BAKIYE sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
