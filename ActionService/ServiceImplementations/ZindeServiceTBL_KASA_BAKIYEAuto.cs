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

    public static readonly ITBL_KASA_BAKIYE _tbl_kasa_bakıye = DataAccess.tbl_kasa_bakıye;


		/// <summary>
        /// TBL_KASA_BAKIYE ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_KASA_BAKIYE(TBL_KASA_BAKIYEDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_kasa_bakıye.Ekle__TBL_KASA_BAKIYE(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_KASA_BAKIYE sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_KASA_BAKIYE(TBL_KASA_BAKIYEDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_kasa_bakıye.Sil__TBL_KASA_BAKIYE(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_KASA_BAKIYE degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_KASA_BAKIYE(TBL_KASA_BAKIYEDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_kasa_bakıye.Degistir__TBL_KASA_BAKIYE(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_KASA_BAKIYE listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_KASA_BAKIYEDTO> Listele__TBL_KASA_BAKIYE()
        {
            try
            {
                return _tbl_kasa_bakıye.Listele__TBL_KASA_BAKIYE();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_KASA_BAKIYE Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_KASA_BAKIYEDTO  Bul_TBL_KASA_BAKIYE(int ID)
        { 
                 try
                {
                    return _tbl_kasa_bakıye.Bul_TBL_KASA_BAKIYE(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
