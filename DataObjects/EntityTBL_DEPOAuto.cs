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
	public partial class EntityTBL_DEPO  :ITBL_DEPO
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_DEPO");



		/// <summary>
        /// TBL_DEPO ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_DEPO(TBL_DEPODTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_DEPO(ModelMapper.TBL_DEPOMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_DEPO sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_DEPO sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_DEPO sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_DEPO(TBL_DEPODTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_DEPO silinecek =
              (from sil in context.TBL_DEPO where 
              sil.TBL_DEPO_ID == item.TBL_DEPO_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_DEPOMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_DEPO sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_DEPO sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_DEPO degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_DEPO(TBL_DEPODTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_DEPO where item.TBL_DEPO_ID == d.TBL_DEPO_ID select d).First();
                    degisecek = ModelMapper.TBL_DEPOMaping.ToEntity(item);
                    context.TBL_DEPO.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_DEPO.Attach(ModelMapper.TBL_DEPOMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_DEPOMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_DEPO sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_DEPO sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_DEPO listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_DEPODTO> Listele__TBL_DEPO( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_DEPODTO> liste = new  List<TBL_DEPODTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_DEPO.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_DEPOMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_DEPO sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_DEPO sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_DEPO Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_DEPODTO  Bul_TBL_DEPO(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_DEPO.ToList().Find(x=>x.TBL_DEPO_ID==ID);;
                      TBL_DEPODTO veri=new TBL_DEPODTO();
			         veri=ModelMapper.TBL_DEPOMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_DEPO sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_DEPO sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
