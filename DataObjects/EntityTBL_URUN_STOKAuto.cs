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
	public partial class EntityTBL_URUN_STOK  :ITBL_URUN_STOK
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_URUN_STOK");



		/// <summary>
        /// TBL_URUN_STOK ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_URUN_STOK(TBL_URUN_STOKDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_URUN_STOK(ModelMapper.TBL_URUN_STOKMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_URUN_STOK sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_URUN_STOK sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_URUN_STOK sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_URUN_STOK(TBL_URUN_STOKDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_URUN_STOK silinecek =
              (from sil in context.TBL_URUN_STOK where 
              sil.TBL_URUN_STOK_ID == item.TBL_URUN_STOK_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_URUN_STOKMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_URUN_STOK sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_URUN_STOK sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_URUN_STOK degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_URUN_STOK(TBL_URUN_STOKDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_URUN_STOK where item.TBL_URUN_STOK_ID == d.TBL_URUN_STOK_ID select d).First();
                    degisecek = ModelMapper.TBL_URUN_STOKMaping.ToEntity(item);
                    context.TBL_URUN_STOK.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_URUN_STOK.Attach(ModelMapper.TBL_URUN_STOKMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_URUN_STOKMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_URUN_STOK sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_URUN_STOK sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_URUN_STOK listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_URUN_STOKDTO> Listele__TBL_URUN_STOK( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_URUN_STOKDTO> liste = new  List<TBL_URUN_STOKDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_URUN_STOK.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_URUN_STOKMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_URUN_STOK sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_URUN_STOK sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_URUN_STOK Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_URUN_STOKDTO  Bul_TBL_URUN_STOK(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_URUN_STOK.ToList().Find(x=>x.TBL_URUN_STOK_ID==ID);;
                      TBL_URUN_STOKDTO veri=new TBL_URUN_STOKDTO();
			         veri=ModelMapper.TBL_URUN_STOKMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_URUN_STOK sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_URUN_STOK sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
