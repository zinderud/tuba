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
	public partial class EntityTBL_PARA_TIPI  :ITBL_PARA_TIPI
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_PARA_TIPI");



		/// <summary>
        /// TBL_PARA_TIPI ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_PARA_TIPI(TBL_PARA_TIPIDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_PARA_TIPI(ModelMapper.TBL_PARA_TIPIMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_PARA_TIPI sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_PARA_TIPI sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_PARA_TIPI sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_PARA_TIPI(TBL_PARA_TIPIDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_PARA_TIPI silinecek =
              (from sil in context.TBL_PARA_TIPI where 
              sil.TBL_PARA_TIPI_ID == item.TBL_PARA_TIPI_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_PARA_TIPIMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_PARA_TIPI sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_PARA_TIPI sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_PARA_TIPI degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_PARA_TIPI(TBL_PARA_TIPIDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_PARA_TIPI where item.TBL_PARA_TIPI_ID == d.TBL_PARA_TIPI_ID select d).First();
                    degisecek = ModelMapper.TBL_PARA_TIPIMaping.ToEntity(item);
                    context.TBL_PARA_TIPI.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_PARA_TIPI.Attach(ModelMapper.TBL_PARA_TIPIMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_PARA_TIPIMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_PARA_TIPI sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_PARA_TIPI sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_PARA_TIPI listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_PARA_TIPIDTO> Listele__TBL_PARA_TIPI( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_PARA_TIPIDTO> liste = new  List<TBL_PARA_TIPIDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_PARA_TIPI.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_PARA_TIPIMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_PARA_TIPI sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_PARA_TIPI sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_PARA_TIPI Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_PARA_TIPIDTO  Bul_TBL_PARA_TIPI(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_PARA_TIPI.ToList().Find(x=>x.TBL_PARA_TIPI_ID==ID);;
                      TBL_PARA_TIPIDTO veri=new TBL_PARA_TIPIDTO();
			         veri=ModelMapper.TBL_PARA_TIPIMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_PARA_TIPI sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_PARA_TIPI sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
