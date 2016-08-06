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

    public static readonly ITBL_DEPO_TRANSFER _tbl_depo_transfer = DataAccess.tbl_depo_transfer;


		/// <summary>
        /// TBL_DEPO_TRANSFER ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_DEPO_TRANSFER(TBL_DEPO_TRANSFERDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_depo_transfer.Ekle__TBL_DEPO_TRANSFER(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_DEPO_TRANSFER sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_DEPO_TRANSFER(TBL_DEPO_TRANSFERDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_depo_transfer.Sil__TBL_DEPO_TRANSFER(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_DEPO_TRANSFER degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_DEPO_TRANSFER(TBL_DEPO_TRANSFERDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_depo_transfer.Degistir__TBL_DEPO_TRANSFER(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_DEPO_TRANSFER listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_DEPO_TRANSFERDTO> Listele__TBL_DEPO_TRANSFER()
        {
            try
            {
                return _tbl_depo_transfer.Listele__TBL_DEPO_TRANSFER();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_DEPO_TRANSFER Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_DEPO_TRANSFERDTO  Bul_TBL_DEPO_TRANSFER(int ID)
        { 
                 try
                {
                    return _tbl_depo_transfer.Bul_TBL_DEPO_TRANSFER(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
