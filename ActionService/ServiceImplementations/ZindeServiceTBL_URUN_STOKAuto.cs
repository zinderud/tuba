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

    public static readonly ITBL_URUN_STOK _tbl_urun_stok = DataAccess.tbl_urun_stok;


		/// <summary>
        /// TBL_URUN_STOK ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_URUN_STOK(TBL_URUN_STOKDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_urun_stok.Ekle__TBL_URUN_STOK(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_URUN_STOK sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_URUN_STOK(TBL_URUN_STOKDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_urun_stok.Sil__TBL_URUN_STOK(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_URUN_STOK degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_URUN_STOK(TBL_URUN_STOKDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_urun_stok.Degistir__TBL_URUN_STOK(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_URUN_STOK listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_URUN_STOKDTO> Listele__TBL_URUN_STOK()
        {
            try
            {
                return _tbl_urun_stok.Listele__TBL_URUN_STOK();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_URUN_STOK Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_URUN_STOKDTO  Bul_TBL_URUN_STOK(int ID)
        { 
                 try
                {
                    return _tbl_urun_stok.Bul_TBL_URUN_STOK(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
