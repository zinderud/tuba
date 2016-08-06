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

    public static readonly ITBL_URUN_SPARIS _tbl_urun_sparıs = DataAccess.tbl_urun_sparıs;


		/// <summary>
        /// TBL_URUN_SPARIS ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_URUN_SPARIS(TBL_URUN_SPARISDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_urun_sparıs.Ekle__TBL_URUN_SPARIS(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_URUN_SPARIS sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_URUN_SPARIS(TBL_URUN_SPARISDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_urun_sparıs.Sil__TBL_URUN_SPARIS(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_URUN_SPARIS degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_URUN_SPARIS(TBL_URUN_SPARISDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_urun_sparıs.Degistir__TBL_URUN_SPARIS(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_URUN_SPARIS listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_URUN_SPARISDTO> Listele__TBL_URUN_SPARIS()
        {
            try
            {
                return _tbl_urun_sparıs.Listele__TBL_URUN_SPARIS();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_URUN_SPARIS Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_URUN_SPARISDTO  Bul_TBL_URUN_SPARIS(int ID)
        { 
                 try
                {
                    return _tbl_urun_sparıs.Bul_TBL_URUN_SPARIS(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
