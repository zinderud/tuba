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

    public static readonly ITBL_GIDER_BAKIYE _tbl_gıder_bakıye = DataAccess.tbl_gıder_bakıye;


		/// <summary>
        /// TBL_GIDER_BAKIYE ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_GIDER_BAKIYE(TBL_GIDER_BAKIYEDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_gıder_bakıye.Ekle__TBL_GIDER_BAKIYE(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_GIDER_BAKIYE sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_GIDER_BAKIYE(TBL_GIDER_BAKIYEDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_gıder_bakıye.Sil__TBL_GIDER_BAKIYE(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_GIDER_BAKIYE degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_GIDER_BAKIYE(TBL_GIDER_BAKIYEDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_gıder_bakıye.Degistir__TBL_GIDER_BAKIYE(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_GIDER_BAKIYE listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_GIDER_BAKIYEDTO> Listele__TBL_GIDER_BAKIYE()
        {
            try
            {
                return _tbl_gıder_bakıye.Listele__TBL_GIDER_BAKIYE();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_GIDER_BAKIYE Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_GIDER_BAKIYEDTO  Bul_TBL_GIDER_BAKIYE(int ID)
        { 
                 try
                {
                    return _tbl_gıder_bakıye.Bul_TBL_GIDER_BAKIYE(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
