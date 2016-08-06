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

    public static readonly ITBL_DEPO_ISLEM _tbl_depo_ıslem = DataAccess.tbl_depo_ıslem;


		/// <summary>
        /// TBL_DEPO_ISLEM ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_DEPO_ISLEM(TBL_DEPO_ISLEMDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_depo_ıslem.Ekle__TBL_DEPO_ISLEM(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_DEPO_ISLEM sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_DEPO_ISLEM(TBL_DEPO_ISLEMDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_depo_ıslem.Sil__TBL_DEPO_ISLEM(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_DEPO_ISLEM degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_DEPO_ISLEM(TBL_DEPO_ISLEMDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_depo_ıslem.Degistir__TBL_DEPO_ISLEM(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_DEPO_ISLEM listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_DEPO_ISLEMDTO> Listele__TBL_DEPO_ISLEM()
        {
            try
            {
                return _tbl_depo_ıslem.Listele__TBL_DEPO_ISLEM();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_DEPO_ISLEM Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_DEPO_ISLEMDTO  Bul_TBL_DEPO_ISLEM(int ID)
        { 
                 try
                {
                    return _tbl_depo_ıslem.Bul_TBL_DEPO_ISLEM(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
