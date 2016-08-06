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

    public static readonly ITBL_PARA_TIPI _tbl_para_tıpı = DataAccess.tbl_para_tıpı;


		/// <summary>
        /// TBL_PARA_TIPI ekle
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public bool Ekle__TBL_PARA_TIPI(TBL_PARA_TIPIDTO item)
        {
		var sonuc = false;
            try
            {
              sonuc=  _tbl_para_tıpı.Ekle__TBL_PARA_TIPI(item);
			 
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;

        }

	    /// <summary>
        /// TBL_PARA_TIPI sil
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Sil__TBL_PARA_TIPI(TBL_PARA_TIPIDTO item)
        {
				var sonuc = false;

             try
            {
              sonuc=  _tbl_para_tıpı.Sil__TBL_PARA_TIPI(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }
        /// <summary>
        /// TBL_PARA_TIPI degistir
        /// </summary>
        /// <param name="item">Item</param>
	    public bool Degistir__TBL_PARA_TIPI(TBL_PARA_TIPIDTO item)
        {
				var sonuc = false;

              try
            {
              sonuc=  _tbl_para_tıpı.Degistir__TBL_PARA_TIPI(item);
            }
             catch (Exception  )
            {
			 
            }
			return sonuc;
        }

		 /// <summary>
        /// TBL_PARA_TIPI listele
        /// </summary>
        /// <param name="item">Item</param>
	    public  List<TBL_PARA_TIPIDTO> Listele__TBL_PARA_TIPI()
        {
            try
            {
                return _tbl_para_tıpı.Listele__TBL_PARA_TIPI();
            }
            catch (Exception)
            {
                return null;
            }
            }
       
        /// <summary>
        /// TBL_PARA_TIPI Bul
        /// </summary>
        /// <param name="item">Item</param>
	    public  TBL_PARA_TIPIDTO  Bul_TBL_PARA_TIPI(int ID)
        { 
                 try
                {
                    return _tbl_para_tıpı.Bul_TBL_PARA_TIPI(ID);
                   
            
                }
                catch (Exception ex)
                {

 					return null;
                }
             
        }
   }
         
}
