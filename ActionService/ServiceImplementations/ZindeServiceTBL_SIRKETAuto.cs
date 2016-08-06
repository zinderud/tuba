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

    public static readonly ITBL_SIRKET _tbl_sırket = DataAccess.tbl_sırket;


		/// <summary>
        /// TBL_SIRKET ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_SIRKET(TBL_SIRKETDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_sırket.Ekle__TBL_SIRKET(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_SIRKET sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_SIRKET(TBL_SIRKETDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_sırket.Sil__TBL_SIRKET(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_SIRKET degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_SIRKET(TBL_SIRKETDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_sırket.Degistir__TBL_SIRKET(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_SIRKET listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_SIRKETDTO> Listele__TBL_SIRKET()
        {
            try
            {
                return _tbl_sırket.Listele__TBL_SIRKET();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_SIRKET Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_SIRKETDTO  Bul_TBL_SIRKET(int ID)
        { 
                 try
                {
                    return _tbl_sırket.Bul_TBL_SIRKET(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
