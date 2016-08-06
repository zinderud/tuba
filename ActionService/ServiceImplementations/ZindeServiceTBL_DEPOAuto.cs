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

    public static readonly ITBL_DEPO _tbl_depo = DataAccess.tbl_depo;


		/// <summary>
        /// TBL_DEPO ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_DEPO(TBL_DEPODTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_depo.Ekle__TBL_DEPO(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_DEPO sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_DEPO(TBL_DEPODTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_depo.Sil__TBL_DEPO(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_DEPO degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_DEPO(TBL_DEPODTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_depo.Degistir__TBL_DEPO(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_DEPO listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_DEPODTO> Listele__TBL_DEPO()
        {
            try
            {
                return _tbl_depo.Listele__TBL_DEPO();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_DEPO Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_DEPODTO  Bul_TBL_DEPO(int ID)
        { 
                 try
                {
                    return _tbl_depo.Bul_TBL_DEPO(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
