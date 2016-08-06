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
	public partial class EntityTBL_BANKA  :ITBL_BANKA
   {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("DataObjects.EntityTBL_BANKA");



		/// <summary>
        /// TBL_BANKA ekle
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Ekle__TBL_BANKA(TBL_BANKADTO item)
        {
		var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  
                context.AddToTBL_BANKA(ModelMapper.TBL_BANKAMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("EKLE__TBL_BANKA sorgusuna gonderilen parametreler veritabanina eklenendi");
				sonuc =true;
                }
                catch (Exception ex)
                {
                    
                 log.Error("EKLE__TBL_BANKA sorgusuna gonderilen parametreler veritabanina eklenemedi", ex);
				 sonuc=false;
                }
				return sonuc;
            }
        }

	    /// <summary>
        /// TBL_BANKA sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_BANKA(TBL_BANKADTO item)
        {
			var sonuc =false;
             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                  

               TBL_BANKA silinecek =
              (from sil in context.TBL_BANKA where 
              sil.TBL_BANKA_ID == item.TBL_BANKA_ID
              select sil).First();

                    context.DeleteObject(silinecek);
                //context.DeleteObject(ModelMapper.TBL_BANKAMaping.ToEntity(item)) ;
                context.SaveChanges();
                log.Info("Sil__TBL_BANKA sorgusuna gonderilen parametreler veritabanida silindi");
				sonuc =true;

                }
                catch (Exception ex)
                {
                    
                 log.Error("Sil__TBL_BANKA sorgusuna gonderilen parametreler veritabanından silinenemedi", ex);
                }
				return sonuc;
            }
        }
        /// <summary>
        /// TBL_BANKA degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_BANKA(TBL_BANKADTO item)
        {
					var sonuc =false;

             using (var context=DataObjectFactory.CreateContext())
            {
               log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {

    
                    var degisecek =
                        (from d in context.TBL_BANKA where item.TBL_BANKA_ID == d.TBL_BANKA_ID select d).First();
                    degisecek = ModelMapper.TBL_BANKAMaping.ToEntity(item);
                    context.TBL_BANKA.ApplyCurrentValues(degisecek);
            
                   context.SaveChanges();
				   sonuc =true;
                  

                   //context.TBL_BANKA.Attach(ModelMapper.TBL_BANKAMaping.ToEntity(item));  
                   //context.ObjectStateManager.ChangeObjectState(ModelMapper.TBL_BANKAMaping.ToEntity(item), EntityState.Modified);
                   //context.SaveChanges();
				   //sonuc =true;

                
                log.Info("Degistir__TBL_BANKA sorgusuna gonderilen parametreler veritabanida Degistirildi");
                }
                catch (Exception ex)
                {
                    
                 log.Error("Degistir__TBL_BANKA sorgusuna gonderilen parametreler veritabanından Degistirilemedi", ex);
                }
				return sonuc;
            }
        }

		 /// <summary>
        /// TBL_BANKA listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_BANKADTO> Listele__TBL_BANKA( )
        {
           using (var context=DataObjectFactory.CreateContext())
            {      
			    List<TBL_BANKADTO> liste = new  List<TBL_BANKADTO>();
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var list = context.TBL_BANKA.ToList();
             
                    foreach (var k in list)
                    {
                        liste.Add(ModelMapper.TBL_BANKAMaping.ToDTO(k));
                    }
                    log.Info("List__TBL_BANKA sorgusuyla liste gonderildi");
                    return liste;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_BANKA sorgusuyla liste gonderilemedi", ex);
					return null;
                }
            }
        }
		 /// <summary>
        /// TBL_BANKA Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_BANKADTO  Bul_TBL_BANKA(int ID)
        {
          using (var context=DataObjectFactory.CreateContext())
            {      
			    
                log4net.Config.XmlConfigurator.Configure(ResourcesFiles.Log4net());
                try
                {
                      var sonuc = context.TBL_BANKA.ToList().Find(x=>x.TBL_BANKA_ID==ID);;
                      TBL_BANKADTO veri=new TBL_BANKADTO();
			         veri=ModelMapper.TBL_BANKAMaping.ToDTO(sonuc);
                   
                    log.Info("List__TBL_BANKA sorgusuyla Bul gonderildi");
                    return veri;
                   
            
                }
                catch (Exception ex)
                {

                    log.Error("List__TBL_BANKA sorgusuyla Bul gonderilemedi", ex);
					return null;
                }
            }
        }
       
   }
         
}
