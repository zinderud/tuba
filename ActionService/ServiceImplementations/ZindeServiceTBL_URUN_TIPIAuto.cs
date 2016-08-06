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

    public static readonly ITBL_URUN_TIPI _tbl_urun_tıpı = DataAccess.tbl_urun_tıpı;


		/// <summary>
        /// TBL_URUN_TIPI ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_URUN_TIPI(TBL_URUN_TIPIDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_urun_tıpı.Ekle__TBL_URUN_TIPI(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_URUN_TIPI sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_URUN_TIPI(TBL_URUN_TIPIDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_urun_tıpı.Sil__TBL_URUN_TIPI(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_URUN_TIPI degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_URUN_TIPI(TBL_URUN_TIPIDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_urun_tıpı.Degistir__TBL_URUN_TIPI(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_URUN_TIPI listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_URUN_TIPIDTO> Listele__TBL_URUN_TIPI()
        {
            try
            {
                return _tbl_urun_tıpı.Listele__TBL_URUN_TIPI();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_URUN_TIPI Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_URUN_TIPIDTO  Bul_TBL_URUN_TIPI(int ID)
        { 
                 try
                {
                    return _tbl_urun_tıpı.Bul_TBL_URUN_TIPI(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
