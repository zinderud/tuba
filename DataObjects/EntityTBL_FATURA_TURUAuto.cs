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
	public partial class EntityTBL_FATURA_TURU  :ITBL_FATURA_TURU
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_FATURA_TURU");



		/// <summary>
        /// TBL_FATURA_TURU ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_FATURA_TURU(TBL_FATURA_TURUDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_FATURA_TURU(ModelMapper.TBL_FATURA_TURUMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_FATURA_TURU sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_FATURA_TURU sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_FATURA_TURU sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_FATURA_TURU(TBL_FATURA_TURUDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_FATURA_TURU silinecek =
              (from sil in context.TBL_FATURA_TURU where 
              sil.TBL_FATURA_TURU_ID == item.TBL_FATURA_TURU_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_FATURA_TURUMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_FATURA_TURU sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_FATURA_TURU sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_FATURA_TURU degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_FATURA_TURU(TBL_FATURA_TURUDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_FATURA_TURU where item.TBL_FATURA_TURU_ID == d.TBL_FATURA_TURU_ID select d).First();
                    degisecek = ModelMapper.TBL_FATURA_TURUMaping.ToEntity(item);
                    context.TBL_FATURA_TURU.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_FATURA_TURU.Attach(ModelMapper.TBL_FATURA_TURUMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_FATURA_TURUMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_FATURA_TURU sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_FATURA_TURU sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_FATURA_TURU listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_FATURA_TURUDTO> Listele__TBL_FATURA_TURU( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_FATURA_TURUDTO> liste = new  List<TBL_FATURA_TURUDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_FATURA_TURU.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_FATURA_TURUMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_FATURA_TURU sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_FATURA_TURU sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_FATURA_TURU Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_FATURA_TURUDTO  Bul_TBL_FATURA_TURU(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_FATURA_TURU.ToList().Find(x=>x.TBL_FATURA_TURU_ID==ID);;
                      TBL_FATURA_TURUDTO veri=new TBL_FATURA_TURUDTO();
			         veri=ModelMapper.TBL_FATURA_TURUMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_FATURA_TURU sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_FATURA_TURU sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
