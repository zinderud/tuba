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

    public static readonly ITBL_SIRKET_BAKIYE _tbl_sırket_bakıye = DataAccess.tbl_sırket_bakıye;


		/// <summary>
        /// TBL_SIRKET_BAKIYE ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_SIRKET_BAKIYE(TBL_SIRKET_BAKIYEDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_sırket_bakıye.Ekle__TBL_SIRKET_BAKIYE(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_SIRKET_BAKIYE sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_SIRKET_BAKIYE(TBL_SIRKET_BAKIYEDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_sırket_bakıye.Sil__TBL_SIRKET_BAKIYE(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_SIRKET_BAKIYE degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_SIRKET_BAKIYE(TBL_SIRKET_BAKIYEDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_sırket_bakıye.Degistir__TBL_SIRKET_BAKIYE(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_SIRKET_BAKIYE listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_SIRKET_BAKIYEDTO> Listele__TBL_SIRKET_BAKIYE()
        {
            try
            {
                return _tbl_sırket_bakıye.Listele__TBL_SIRKET_BAKIYE();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_SIRKET_BAKIYE Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_SIRKET_BAKIYEDTO  Bul_TBL_SIRKET_BAKIYE(int ID)
        { 
                 try
                {
                    return _tbl_sırket_bakıye.Bul_TBL_SIRKET_BAKIYE(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
