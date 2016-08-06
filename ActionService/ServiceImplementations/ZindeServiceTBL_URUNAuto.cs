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

    public static readonly ITBL_URUN _tbl_urun = DataAccess.tbl_urun;


		/// <summary>
        /// TBL_URUN ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_URUN(TBL_URUNDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_urun.Ekle__TBL_URUN(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_URUN sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_URUN(TBL_URUNDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_urun.Sil__TBL_URUN(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_URUN degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_URUN(TBL_URUNDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_urun.Degistir__TBL_URUN(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_URUN listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_URUNDTO> Listele__TBL_URUN()
        {
            try
            {
                return _tbl_urun.Listele__TBL_URUN();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_URUN Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_URUNDTO  Bul_TBL_URUN(int ID)
        { 
                 try
                {
                    return _tbl_urun.Bul_TBL_URUN(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
