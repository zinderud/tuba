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

    public static readonly ITBL_BANKA _tbl_banka = DataAccess.tbl_banka;


		/// <summary>
        /// TBL_BANKA ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_BANKA(TBL_BANKADTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_banka.Ekle__TBL_BANKA(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_BANKA sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_BANKA(TBL_BANKADTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_banka.Sil__TBL_BANKA(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_BANKA degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_BANKA(TBL_BANKADTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_banka.Degistir__TBL_BANKA(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_BANKA listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_BANKADTO> Listele__TBL_BANKA()
        {
            try
            {
                return _tbl_banka.Listele__TBL_BANKA();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_BANKA Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_BANKADTO  Bul_TBL_BANKA(int ID)
        { 
                 try
                {
                    return _tbl_banka.Bul_TBL_BANKA(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
