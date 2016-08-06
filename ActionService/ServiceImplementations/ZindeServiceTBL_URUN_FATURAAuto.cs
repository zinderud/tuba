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

    public static readonly ITBL_URUN_FATURA _tbl_urun_fatura = DataAccess.tbl_urun_fatura;


		/// <summary>
        /// TBL_URUN_FATURA ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_URUN_FATURA(TBL_URUN_FATURADTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_urun_fatura.Ekle__TBL_URUN_FATURA(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_URUN_FATURA sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_URUN_FATURA(TBL_URUN_FATURADTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_urun_fatura.Sil__TBL_URUN_FATURA(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_URUN_FATURA degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_URUN_FATURA(TBL_URUN_FATURADTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_urun_fatura.Degistir__TBL_URUN_FATURA(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_URUN_FATURA listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_URUN_FATURADTO> Listele__TBL_URUN_FATURA()
        {
            try
            {
                return _tbl_urun_fatura.Listele__TBL_URUN_FATURA();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_URUN_FATURA Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_URUN_FATURADTO  Bul_TBL_URUN_FATURA(int ID)
        { 
                 try
                {
                    return _tbl_urun_fatura.Bul_TBL_URUN_FATURA(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
