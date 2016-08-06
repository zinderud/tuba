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
	public partial class EntityTBL_SIRKET  :ITBL_SIRKET
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_SIRKET");



		/// <summary>
        /// TBL_SIRKET ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_SIRKET(TBL_SIRKETDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_SIRKET(ModelMapper.TBL_SIRKETMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_SIRKET sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_SIRKET sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_SIRKET sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_SIRKET(TBL_SIRKETDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_SIRKET silinecek =
              (from sil in context.TBL_SIRKET where 
              sil.TBL_SIRKET_ID == item.TBL_SIRKET_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_SIRKETMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_SIRKET sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_SIRKET sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_SIRKET degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_SIRKET(TBL_SIRKETDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_SIRKET where item.TBL_SIRKET_ID == d.TBL_SIRKET_ID select d).First();
                    degisecek = ModelMapper.TBL_SIRKETMaping.ToEntity(item);
                    context.TBL_SIRKET.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_SIRKET.Attach(ModelMapper.TBL_SIRKETMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_SIRKETMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_SIRKET sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_SIRKET sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_SIRKET listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_SIRKETDTO> Listele__TBL_SIRKET( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_SIRKETDTO> liste = new  List<TBL_SIRKETDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_SIRKET.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_SIRKETMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_SIRKET sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_SIRKET sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_SIRKET Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_SIRKETDTO  Bul_TBL_SIRKET(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_SIRKET.ToList().Find(x=>x.TBL_SIRKET_ID==ID);;
                      TBL_SIRKETDTO veri=new TBL_SIRKETDTO();
			         veri=ModelMapper.TBL_SIRKETMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_SIRKET sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_SIRKET sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
