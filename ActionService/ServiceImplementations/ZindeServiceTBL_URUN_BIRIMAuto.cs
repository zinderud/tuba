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

    public static readonly ITBL_URUN_BIRIM _tbl_urun_bırım = DataAccess.tbl_urun_bırım;


		/// <summary>
        /// TBL_URUN_BIRIM ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_URUN_BIRIM(TBL_URUN_BIRIMDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_urun_bırım.Ekle__TBL_URUN_BIRIM(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_URUN_BIRIM sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_URUN_BIRIM(TBL_URUN_BIRIMDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_urun_bırım.Sil__TBL_URUN_BIRIM(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_URUN_BIRIM degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_URUN_BIRIM(TBL_URUN_BIRIMDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_urun_bırım.Degistir__TBL_URUN_BIRIM(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_URUN_BIRIM listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_URUN_BIRIMDTO> Listele__TBL_URUN_BIRIM()
        {
            try
            {
                return _tbl_urun_bırım.Listele__TBL_URUN_BIRIM();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_URUN_BIRIM Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_URUN_BIRIMDTO  Bul_TBL_URUN_BIRIM(int ID)
        { 
                 try
                {
                    return _tbl_urun_bırım.Bul_TBL_URUN_BIRIM(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
