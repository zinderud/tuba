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

    public static readonly ITBL_KASA _tbl_kasa = DataAccess.tbl_kasa;


		/// <summary>
        /// TBL_KASA ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_KASA(TBL_KASADTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_kasa.Ekle__TBL_KASA(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_KASA sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_KASA(TBL_KASADTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_kasa.Sil__TBL_KASA(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_KASA degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_KASA(TBL_KASADTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_kasa.Degistir__TBL_KASA(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_KASA listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_KASADTO> Listele__TBL_KASA()
        {
            try
            {
                return _tbl_kasa.Listele__TBL_KASA();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_KASA Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_KASADTO  Bul_TBL_KASA(int ID)
        { 
                 try
                {
                    return _tbl_kasa.Bul_TBL_KASA(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
