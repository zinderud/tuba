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
	public partial class EntityTBL_URUN_FATURA  :ITBL_URUN_FATURA
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_URUN_FATURA");



		/// <summary>
        /// TBL_URUN_FATURA ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_URUN_FATURA(TBL_URUN_FATURADTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_URUN_FATURA(ModelMapper.TBL_URUN_FATURAMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_URUN_FATURA sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_URUN_FATURA sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_URUN_FATURA sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_URUN_FATURA(TBL_URUN_FATURADTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_URUN_FATURA silinecek =
              (from sil in context.TBL_URUN_FATURA where 
              sil.TBL_URUN_FATURA_ID == item.TBL_URUN_FATURA_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_URUN_FATURAMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_URUN_FATURA sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_URUN_FATURA sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_URUN_FATURA degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_URUN_FATURA(TBL_URUN_FATURADTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_URUN_FATURA where item.TBL_URUN_FATURA_ID == d.TBL_URUN_FATURA_ID select d).First();
                    degisecek = ModelMapper.TBL_URUN_FATURAMaping.ToEntity(item);
                    context.TBL_URUN_FATURA.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_URUN_FATURA.Attach(ModelMapper.TBL_URUN_FATURAMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_URUN_FATURAMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_URUN_FATURA sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_URUN_FATURA sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_URUN_FATURA listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_URUN_FATURADTO> Listele__TBL_URUN_FATURA( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_URUN_FATURADTO> liste = new  List<TBL_URUN_FATURADTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_URUN_FATURA.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_URUN_FATURAMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_URUN_FATURA sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_URUN_FATURA sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_URUN_FATURA Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_URUN_FATURADTO  Bul_TBL_URUN_FATURA(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_URUN_FATURA.ToList().Find(x=>x.TBL_URUN_FATURA_ID==ID);;
                      TBL_URUN_FATURADTO veri=new TBL_URUN_FATURADTO();
			         veri=ModelMapper.TBL_URUN_FATURAMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_URUN_FATURA sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_URUN_FATURA sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
