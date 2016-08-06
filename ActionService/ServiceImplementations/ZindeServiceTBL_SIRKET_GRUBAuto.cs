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

    public static readonly ITBL_SIRKET_GRUB _tbl_sırket_grub = DataAccess.tbl_sırket_grub;


		/// <summary>
        /// TBL_SIRKET_GRUB ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_SIRKET_GRUB(TBL_SIRKET_GRUBDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_sırket_grub.Ekle__TBL_SIRKET_GRUB(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_SIRKET_GRUB sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_SIRKET_GRUB(TBL_SIRKET_GRUBDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_sırket_grub.Sil__TBL_SIRKET_GRUB(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_SIRKET_GRUB degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_SIRKET_GRUB(TBL_SIRKET_GRUBDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_sırket_grub.Degistir__TBL_SIRKET_GRUB(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_SIRKET_GRUB listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_SIRKET_GRUBDTO> Listele__TBL_SIRKET_GRUB()
        {
            try
            {
                return _tbl_sırket_grub.Listele__TBL_SIRKET_GRUB();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_SIRKET_GRUB Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_SIRKET_GRUBDTO  Bul_TBL_SIRKET_GRUB(int ID)
        { 
                 try
                {
                    return _tbl_sırket_grub.Bul_TBL_SIRKET_GRUB(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
