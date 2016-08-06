//===================================================================================
// Sio
// Sio
//===================================================================================

#region
using System;
using System.Configuration;
using System.Linq;
using System.Web.Security;
using System.Collections.Generic;
using System.ServiceModel;
using DataObjects.EntityFramework;
using AutoBusinessObjects;
using DataObjects;

 
 using ZindeService.ServiceContracts;
using System.Collections;
#endregion

namespace  ZindeService.ServiceImplementations
{
 	public partial class ZindeService : IZindeService
   {

    public static readonly ITBL_URUN_CINSI _tbl_urun_cınsı = DataAccess.tbl_urun_cınsı;


		/// <summary>
        /// TBL_URUN_CINSI ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_URUN_CINSI(TBL_URUN_CINSIDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_urun_cınsı.Ekle__TBL_URUN_CINSI(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_URUN_CINSI sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_URUN_CINSI(TBL_URUN_CINSIDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_urun_cınsı.Sil__TBL_URUN_CINSI(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_URUN_CINSI degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_URUN_CINSI(TBL_URUN_CINSIDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_urun_cınsı.Degistir__TBL_URUN_CINSI(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_URUN_CINSI listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_URUN_CINSIDTO> Listele__TBL_URUN_CINSI()
        {
            try
            {
                return _tbl_urun_cınsı.Listele__TBL_URUN_CINSI();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_URUN_CINSI Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_URUN_CINSIDTO  Bul_TBL_URUN_CINSI(int ID)
        { 
                 try
                {
                    return _tbl_urun_cınsı.Bul_TBL_URUN_CINSI(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
