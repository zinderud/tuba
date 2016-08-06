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

    public static readonly ITBL_FIS _tbl_fıs = DataAccess.tbl_fıs;


		/// <summary>
        /// TBL_FIS ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_FIS(TBL_FISDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_fıs.Ekle__TBL_FIS(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_FIS sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_FIS(TBL_FISDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_fıs.Sil__TBL_FIS(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_FIS degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_FIS(TBL_FISDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_fıs.Degistir__TBL_FIS(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_FIS listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_FISDTO> Listele__TBL_FIS()
        {
            try
            {
                return _tbl_fıs.Listele__TBL_FIS();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_FIS Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_FISDTO  Bul_TBL_FIS(int ID)
        { 
                 try
                {
                    return _tbl_fıs.Bul_TBL_FIS(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
