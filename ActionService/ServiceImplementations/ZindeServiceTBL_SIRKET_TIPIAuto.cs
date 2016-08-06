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

    public static readonly ITBL_SIRKET_TIPI _tbl_sırket_tıpı = DataAccess.tbl_sırket_tıpı;


		/// <summary>
        /// TBL_SIRKET_TIPI ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_SIRKET_TIPI(TBL_SIRKET_TIPIDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_sırket_tıpı.Ekle__TBL_SIRKET_TIPI(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_SIRKET_TIPI sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_SIRKET_TIPI(TBL_SIRKET_TIPIDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_sırket_tıpı.Sil__TBL_SIRKET_TIPI(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_SIRKET_TIPI degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_SIRKET_TIPI(TBL_SIRKET_TIPIDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_sırket_tıpı.Degistir__TBL_SIRKET_TIPI(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_SIRKET_TIPI listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_SIRKET_TIPIDTO> Listele__TBL_SIRKET_TIPI()
        {
            try
            {
                return _tbl_sırket_tıpı.Listele__TBL_SIRKET_TIPI();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_SIRKET_TIPI Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_SIRKET_TIPIDTO  Bul_TBL_SIRKET_TIPI(int ID)
        { 
                 try
                {
                    return _tbl_sırket_tıpı.Bul_TBL_SIRKET_TIPI(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
