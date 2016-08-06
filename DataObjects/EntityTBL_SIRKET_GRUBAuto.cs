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
	public partial class EntityTBL_SIRKET_GRUB  :ITBL_SIRKET_GRUB
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_SIRKET_GRUB");



		/// <summary>
        /// TBL_SIRKET_GRUB ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_SIRKET_GRUB(TBL_SIRKET_GRUBDTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_SIRKET_GRUB(ModelMapper.TBL_SIRKET_GRUBMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_SIRKET_GRUB sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_SIRKET_GRUB sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_SIRKET_GRUB sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_SIRKET_GRUB(TBL_SIRKET_GRUBDTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_SIRKET_GRUB silinecek =
              (from sil in context.TBL_SIRKET_GRUB where 
              sil.TBL_SIRKET_GRUB_ID == item.TBL_SIRKET_GRUB_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_SIRKET_GRUBMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_SIRKET_GRUB sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_SIRKET_GRUB sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_SIRKET_GRUB degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_SIRKET_GRUB(TBL_SIRKET_GRUBDTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_SIRKET_GRUB where item.TBL_SIRKET_GRUB_ID == d.TBL_SIRKET_GRUB_ID select d).First();
                    degisecek = ModelMapper.TBL_SIRKET_GRUBMaping.ToEntity(item);
                    context.TBL_SIRKET_GRUB.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_SIRKET_GRUB.Attach(ModelMapper.TBL_SIRKET_GRUBMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_SIRKET_GRUBMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_SIRKET_GRUB sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_SIRKET_GRUB sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_SIRKET_GRUB listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_SIRKET_GRUBDTO> Listele__TBL_SIRKET_GRUB( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_SIRKET_GRUBDTO> liste = new  List<TBL_SIRKET_GRUBDTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_SIRKET_GRUB.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_SIRKET_GRUBMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_SIRKET_GRUB sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_SIRKET_GRUB sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_SIRKET_GRUB Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_SIRKET_GRUBDTO  Bul_TBL_SIRKET_GRUB(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_SIRKET_GRUB.ToList().Find(x=>x.TBL_SIRKET_GRUB_ID==ID);;
                      TBL_SIRKET_GRUBDTO veri=new TBL_SIRKET_GRUBDTO();
			         veri=ModelMapper.TBL_SIRKET_GRUBMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_SIRKET_GRUB sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_SIRKET_GRUB sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
