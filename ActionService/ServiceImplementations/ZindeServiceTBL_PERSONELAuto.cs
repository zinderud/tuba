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

    public static readonly ITBL_PERSONEL _tbl_personel = DataAccess.tbl_personel;


		/// <summary>
        /// TBL_PERSONEL ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_PERSONEL(TBL_PERSONELDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_personel.Ekle__TBL_PERSONEL(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_PERSONEL sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_PERSONEL(TBL_PERSONELDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_personel.Sil__TBL_PERSONEL(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_PERSONEL degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_PERSONEL(TBL_PERSONELDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_personel.Degistir__TBL_PERSONEL(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_PERSONEL listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_PERSONELDTO> Listele__TBL_PERSONEL()
        {
            try
            {
                return _tbl_personel.Listele__TBL_PERSONEL();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_PERSONEL Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_PERSONELDTO  Bul_TBL_PERSONEL(int ID)
        { 
                 try
                {
                    return _tbl_personel.Bul_TBL_PERSONEL(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
