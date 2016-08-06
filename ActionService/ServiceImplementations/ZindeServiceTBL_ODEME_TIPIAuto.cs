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

    public static readonly ITBL_ODEME_TIPI _tbl_odeme_tıpı = DataAccess.tbl_odeme_tıpı;


		/// <summary>
        /// TBL_ODEME_TIPI ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_ODEME_TIPI(TBL_ODEME_TIPIDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_odeme_tıpı.Ekle__TBL_ODEME_TIPI(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_ODEME_TIPI sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_ODEME_TIPI(TBL_ODEME_TIPIDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_odeme_tıpı.Sil__TBL_ODEME_TIPI(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_ODEME_TIPI degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_ODEME_TIPI(TBL_ODEME_TIPIDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_odeme_tıpı.Degistir__TBL_ODEME_TIPI(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_ODEME_TIPI listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_ODEME_TIPIDTO> Listele__TBL_ODEME_TIPI()
        {
            try
            {
                return _tbl_odeme_tıpı.Listele__TBL_ODEME_TIPI();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_ODEME_TIPI Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_ODEME_TIPIDTO  Bul_TBL_ODEME_TIPI(int ID)
        { 
                 try
                {
                    return _tbl_odeme_tıpı.Bul_TBL_ODEME_TIPI(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
