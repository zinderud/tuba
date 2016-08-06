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

    public static readonly ITBL_SIRKET_SINIF _tbl_sırket_sınıf = DataAccess.tbl_sırket_sınıf;


		/// <summary>
        /// TBL_SIRKET_SINIF ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_SIRKET_SINIF(TBL_SIRKET_SINIFDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_sırket_sınıf.Ekle__TBL_SIRKET_SINIF(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_SIRKET_SINIF sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_SIRKET_SINIF(TBL_SIRKET_SINIFDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_sırket_sınıf.Sil__TBL_SIRKET_SINIF(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_SIRKET_SINIF degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_SIRKET_SINIF(TBL_SIRKET_SINIFDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_sırket_sınıf.Degistir__TBL_SIRKET_SINIF(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_SIRKET_SINIF listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_SIRKET_SINIFDTO> Listele__TBL_SIRKET_SINIF()
        {
            try
            {
                return _tbl_sırket_sınıf.Listele__TBL_SIRKET_SINIF();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_SIRKET_SINIF Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_SIRKET_SINIFDTO  Bul_TBL_SIRKET_SINIF(int ID)
        { 
                 try
                {
                    return _tbl_sırket_sınıf.Bul_TBL_SIRKET_SINIF(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
