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
	public partial class EntityTBL_KDV  :ITBL_KDV
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_KDV");



		/// <summary>
        /// TBL_KDV ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_KDV(TBL_KDVDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_KDV(ModelMapper.TBL_KDVMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_KDV sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_KDV sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_KDV sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_KDV(TBL_KDVDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_KDV silinecek =
              (from sil in context.TBL_KDV where 
              sil.TBL_KDV_ID == item.TBL_KDV_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_KDVMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_KDV sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_KDV sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_KDV degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_KDV(TBL_KDVDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_KDV where item.TBL_KDV_ID == d.TBL_KDV_ID select d).First();
                    degisecek = ModelMapper.TBL_KDVMaping.ToEntity(item);
                    context.TBL_KDV.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_KDV.Attach(ModelMapper.TBL_KDVMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_KDVMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_KDV sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_KDV sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_KDV listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_KDVDTO> Listele__TBL_KDV( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_KDVDTO> liste = new  List<TBL_KDVDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_KDV.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_KDVMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_KDV sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_KDV sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_KDV Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_KDVDTO  Bul_TBL_KDV(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_KDV.ToList().Find(x=>x.TBL_KDV_ID==ID);;
                      TBL_KDVDTO veri=new TBL_KDVDTO();
			         veri=ModelMapper.TBL_KDVMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_KDV sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_KDV sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
