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

    public static readonly ITBL_ODEME_TURU _tbl_odeme_turu = DataAccess.tbl_odeme_turu;


		/// <summary>
        /// TBL_ODEME_TURU ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_ODEME_TURU(TBL_ODEME_TURUDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_odeme_turu.Ekle__TBL_ODEME_TURU(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_ODEME_TURU sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_ODEME_TURU(TBL_ODEME_TURUDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_odeme_turu.Sil__TBL_ODEME_TURU(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_ODEME_TURU degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_ODEME_TURU(TBL_ODEME_TURUDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_odeme_turu.Degistir__TBL_ODEME_TURU(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_ODEME_TURU listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_ODEME_TURUDTO> Listele__TBL_ODEME_TURU()
        {
            try
            {
                return _tbl_odeme_turu.Listele__TBL_ODEME_TURU();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_ODEME_TURU Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_ODEME_TURUDTO  Bul_TBL_ODEME_TURU(int ID)
        { 
                 try
                {
                    return _tbl_odeme_turu.Bul_TBL_ODEME_TURU(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
