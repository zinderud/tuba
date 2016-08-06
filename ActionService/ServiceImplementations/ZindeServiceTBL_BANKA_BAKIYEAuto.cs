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

    public static readonly ITBL_BANKA_BAKIYE _tbl_banka_bakıye = DataAccess.tbl_banka_bakıye;


		/// <summary>
        /// TBL_BANKA_BAKIYE ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_BANKA_BAKIYE(TBL_BANKA_BAKIYEDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_banka_bakıye.Ekle__TBL_BANKA_BAKIYE(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_BANKA_BAKIYE sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_BANKA_BAKIYE(TBL_BANKA_BAKIYEDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_banka_bakıye.Sil__TBL_BANKA_BAKIYE(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_BANKA_BAKIYE degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_BANKA_BAKIYE(TBL_BANKA_BAKIYEDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_banka_bakıye.Degistir__TBL_BANKA_BAKIYE(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_BANKA_BAKIYE listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_BANKA_BAKIYEDTO> Listele__TBL_BANKA_BAKIYE()
        {
            try
            {
                return _tbl_banka_bakıye.Listele__TBL_BANKA_BAKIYE();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_BANKA_BAKIYE Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_BANKA_BAKIYEDTO  Bul_TBL_BANKA_BAKIYE(int ID)
        { 
                 try
                {
                    return _tbl_banka_bakıye.Bul_TBL_BANKA_BAKIYE(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
