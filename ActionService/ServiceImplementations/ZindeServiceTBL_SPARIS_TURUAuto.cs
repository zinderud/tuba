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

    public static readonly ITBL_SPARIS_TURU _tbl_sparıs_turu = DataAccess.tbl_sparıs_turu;


		/// <summary>
        /// TBL_SPARIS_TURU ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_SPARIS_TURU(TBL_SPARIS_TURUDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_sparıs_turu.Ekle__TBL_SPARIS_TURU(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_SPARIS_TURU sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_SPARIS_TURU(TBL_SPARIS_TURUDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_sparıs_turu.Sil__TBL_SPARIS_TURU(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_SPARIS_TURU degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_SPARIS_TURU(TBL_SPARIS_TURUDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_sparıs_turu.Degistir__TBL_SPARIS_TURU(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_SPARIS_TURU listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_SPARIS_TURUDTO> Listele__TBL_SPARIS_TURU()
        {
            try
            {
                return _tbl_sparıs_turu.Listele__TBL_SPARIS_TURU();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_SPARIS_TURU Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_SPARIS_TURUDTO  Bul_TBL_SPARIS_TURU(int ID)
        { 
                 try
                {
                    return _tbl_sparıs_turu.Bul_TBL_SPARIS_TURU(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
