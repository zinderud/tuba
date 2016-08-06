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
	public partial class EntityTBL_PERSONEL  :ITBL_PERSONEL
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_PERSONEL");



		/// <summary>
        /// TBL_PERSONEL ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_PERSONEL(TBL_PERSONELDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_PERSONEL(ModelMapper.TBL_PERSONELMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_PERSONEL sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_PERSONEL sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_PERSONEL sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_PERSONEL(TBL_PERSONELDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_PERSONEL silinecek =
              (from sil in context.TBL_PERSONEL where 
              sil.TBL_PERSONEL_ID == item.TBL_PERSONEL_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_PERSONELMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_PERSONEL sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_PERSONEL sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_PERSONEL degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_PERSONEL(TBL_PERSONELDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_PERSONEL where item.TBL_PERSONEL_ID == d.TBL_PERSONEL_ID select d).First();
                    degisecek = ModelMapper.TBL_PERSONELMaping.ToEntity(item);
                    context.TBL_PERSONEL.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_PERSONEL.Attach(ModelMapper.TBL_PERSONELMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_PERSONELMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_PERSONEL sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_PERSONEL sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_PERSONEL listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_PERSONELDTO> Listele__TBL_PERSONEL( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_PERSONELDTO> liste = new  List<TBL_PERSONELDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_PERSONEL.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_PERSONELMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_PERSONEL sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_PERSONEL sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_PERSONEL Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_PERSONELDTO  Bul_TBL_PERSONEL(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_PERSONEL.ToList().Find(x=>x.TBL_PERSONEL_ID==ID);;
                      TBL_PERSONELDTO veri=new TBL_PERSONELDTO();
			         veri=ModelMapper.TBL_PERSONELMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_PERSONEL sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_PERSONEL sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
