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

    public static readonly ITBL_FATURA_TURU _tbl_fatura_turu = DataAccess.tbl_fatura_turu;


		/// <summary>
        /// TBL_FATURA_TURU ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_FATURA_TURU(TBL_FATURA_TURUDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_fatura_turu.Ekle__TBL_FATURA_TURU(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_FATURA_TURU sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_FATURA_TURU(TBL_FATURA_TURUDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_fatura_turu.Sil__TBL_FATURA_TURU(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_FATURA_TURU degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_FATURA_TURU(TBL_FATURA_TURUDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_fatura_turu.Degistir__TBL_FATURA_TURU(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_FATURA_TURU listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_FATURA_TURUDTO> Listele__TBL_FATURA_TURU()
        {
            try
            {
                return _tbl_fatura_turu.Listele__TBL_FATURA_TURU();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_FATURA_TURU Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_FATURA_TURUDTO  Bul_TBL_FATURA_TURU(int ID)
        { 
                 try
                {
                    return _tbl_fatura_turu.Bul_TBL_FATURA_TURU(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
