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

    public static readonly ITBL_ODEME _tbl_odeme = DataAccess.tbl_odeme;


		/// <summary>
        /// TBL_ODEME ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_ODEME(TBL_ODEMEDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_odeme.Ekle__TBL_ODEME(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_ODEME sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_ODEME(TBL_ODEMEDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_odeme.Sil__TBL_ODEME(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_ODEME degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_ODEME(TBL_ODEMEDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_odeme.Degistir__TBL_ODEME(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_ODEME listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_ODEMEDTO> Listele__TBL_ODEME()
        {
            try
            {
                return _tbl_odeme.Listele__TBL_ODEME();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_ODEME Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_ODEMEDTO  Bul_TBL_ODEME(int ID)
        { 
                 try
                {
                    return _tbl_odeme.Bul_TBL_ODEME(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
