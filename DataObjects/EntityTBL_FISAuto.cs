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
	public partial class EntityTBL_FIS  :ITBL_FIS
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_FIS");



		/// <summary>
        /// TBL_FIS ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_FIS(TBL_FISDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_FIS(ModelMapper.TBL_FISMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_FIS sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_FIS sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_FIS sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_FIS(TBL_FISDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_FIS silinecek =
              (from sil in context.TBL_FIS where 
              sil.TBL_FIS_ID == item.TBL_FIS_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_FISMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_FIS sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_FIS sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_FIS degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_FIS(TBL_FISDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_FIS where item.TBL_FIS_ID == d.TBL_FIS_ID select d).First();
                    degisecek = ModelMapper.TBL_FISMaping.ToEntity(item);
                    context.TBL_FIS.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_FIS.Attach(ModelMapper.TBL_FISMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_FISMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_FIS sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_FIS sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_FIS listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_FISDTO> Listele__TBL_FIS( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_FISDTO> liste = new  List<TBL_FISDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_FIS.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_FISMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_FIS sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_FIS sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_FIS Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_FISDTO  Bul_TBL_FIS(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_FIS.ToList().Find(x=>x.TBL_FIS_ID==ID);;
                      TBL_FISDTO veri=new TBL_FISDTO();
			         veri=ModelMapper.TBL_FISMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_FIS sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_FIS sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
