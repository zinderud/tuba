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

    public static readonly ITBL_KDV _tbl_kdv = DataAccess.tbl_kdv;


		/// <summary>
        /// TBL_KDV ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_KDV(TBL_KDVDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_kdv.Ekle__TBL_KDV(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_KDV sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_KDV(TBL_KDVDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_kdv.Sil__TBL_KDV(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_KDV degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_KDV(TBL_KDVDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_kdv.Degistir__TBL_KDV(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_KDV listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_KDVDTO> Listele__TBL_KDV()
        {
            try
            {
                return _tbl_kdv.Listele__TBL_KDV();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_KDV Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_KDVDTO  Bul_TBL_KDV(int ID)
        { 
                 try
                {
                    return _tbl_kdv.Bul_TBL_KDV(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
