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

    public static readonly ITBL_FATURA _tbl_fatura = DataAccess.tbl_fatura;


		/// <summary>
        /// TBL_FATURA ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_FATURA(TBL_FATURADTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_fatura.Ekle__TBL_FATURA(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_FATURA sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_FATURA(TBL_FATURADTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_fatura.Sil__TBL_FATURA(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_FATURA degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_FATURA(TBL_FATURADTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_fatura.Degistir__TBL_FATURA(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_FATURA listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_FATURADTO> Listele__TBL_FATURA()
        {
            try
            {
                return _tbl_fatura.Listele__TBL_FATURA();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_FATURA Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_FATURADTO  Bul_TBL_FATURA(int ID)
        { 
                 try
                {
                    return _tbl_fatura.Bul_TBL_FATURA(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
