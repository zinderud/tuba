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
	public partial class EntityTBL_URUN_BIRIM  :ITBL_URUN_BIRIM
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_URUN_BIRIM");



		/// <summary>
        /// TBL_URUN_BIRIM ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_URUN_BIRIM(TBL_URUN_BIRIMDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_URUN_BIRIM(ModelMapper.TBL_URUN_BIRIMMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_URUN_BIRIM sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_URUN_BIRIM sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_URUN_BIRIM sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_URUN_BIRIM(TBL_URUN_BIRIMDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_URUN_BIRIM silinecek =
              (from sil in context.TBL_URUN_BIRIM where 
              sil.TBL_URUN_BIRIM_ID == item.TBL_URUN_BIRIM_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_URUN_BIRIMMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_URUN_BIRIM sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_URUN_BIRIM sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_URUN_BIRIM degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_URUN_BIRIM(TBL_URUN_BIRIMDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_URUN_BIRIM where item.TBL_URUN_BIRIM_ID == d.TBL_URUN_BIRIM_ID select d).First();
                    degisecek = ModelMapper.TBL_URUN_BIRIMMaping.ToEntity(item);
                    context.TBL_URUN_BIRIM.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_URUN_BIRIM.Attach(ModelMapper.TBL_URUN_BIRIMMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_URUN_BIRIMMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_URUN_BIRIM sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_URUN_BIRIM sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_URUN_BIRIM listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_URUN_BIRIMDTO> Listele__TBL_URUN_BIRIM( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_URUN_BIRIMDTO> liste = new  List<TBL_URUN_BIRIMDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_URUN_BIRIM.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_URUN_BIRIMMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_URUN_BIRIM sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_URUN_BIRIM sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_URUN_BIRIM Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_URUN_BIRIMDTO  Bul_TBL_URUN_BIRIM(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_URUN_BIRIM.ToList().Find(x=>x.TBL_URUN_BIRIM_ID==ID);;
                      TBL_URUN_BIRIMDTO veri=new TBL_URUN_BIRIMDTO();
			         veri=ModelMapper.TBL_URUN_BIRIMMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_URUN_BIRIM sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_URUN_BIRIM sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
