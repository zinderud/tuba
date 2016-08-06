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

    public static readonly ITBL_SPARIS _tbl_sparıs = DataAccess.tbl_sparıs;


		/// <summary>
        /// TBL_SPARIS ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_SPARIS(TBL_SPARISDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_sparıs.Ekle__TBL_SPARIS(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_SPARIS sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_SPARIS(TBL_SPARISDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_sparıs.Sil__TBL_SPARIS(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_SPARIS degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_SPARIS(TBL_SPARISDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_sparıs.Degistir__TBL_SPARIS(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_SPARIS listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_SPARISDTO> Listele__TBL_SPARIS()
        {
            try
            {
                return _tbl_sparıs.Listele__TBL_SPARIS();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_SPARIS Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_SPARISDTO  Bul_TBL_SPARIS(int ID)
        { 
                 try
                {
                    return _tbl_sparıs.Bul_TBL_SPARIS(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
