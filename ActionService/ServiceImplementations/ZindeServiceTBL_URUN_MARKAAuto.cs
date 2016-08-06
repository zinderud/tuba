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

    public static readonly ITBL_URUN_MARKA _tbl_urun_marka = DataAccess.tbl_urun_marka;


		/// <summary>
        /// TBL_URUN_MARKA ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_URUN_MARKA(TBL_URUN_MARKADTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_urun_marka.Ekle__TBL_URUN_MARKA(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_URUN_MARKA sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_URUN_MARKA(TBL_URUN_MARKADTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_urun_marka.Sil__TBL_URUN_MARKA(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_URUN_MARKA degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_URUN_MARKA(TBL_URUN_MARKADTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_urun_marka.Degistir__TBL_URUN_MARKA(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_URUN_MARKA listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_URUN_MARKADTO> Listele__TBL_URUN_MARKA()
        {
            try
            {
                return _tbl_urun_marka.Listele__TBL_URUN_MARKA();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_URUN_MARKA Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_URUN_MARKADTO  Bul_TBL_URUN_MARKA(int ID)
        { 
                 try
                {
                    return _tbl_urun_marka.Bul_TBL_URUN_MARKA(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
