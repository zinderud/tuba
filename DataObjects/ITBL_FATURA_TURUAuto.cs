//===================================================================================
// Sio
// Sio
//===================================================================================

#region
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoBusinessObjects;
using DataObjects.EntityFramework;
#endregion

namespace DataObjects
{
	public partial interface ITBL_FATURA_TURU   
    {
		/// <summary>
        ///TBL_FATURA_TURU  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_FATURA_TURU(TBL_FATURA_TURUDTO item);
        
        /// <summary>
        ///TBL_FATURA_TURU  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_FATURA_TURU(TBL_FATURA_TURUDTO item);
        
        /// <summary>
        ///TBL_FATURA_TURU  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_FATURA_TURU(TBL_FATURA_TURUDTO item);
		 /// <summary>
        ///TBL_FATURA_TURU  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_FATURA_TURUDTO>  Listele__TBL_FATURA_TURU();
         /// <summary>
        ///TBL_FATURA_TURU  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_FATURA_TURUDTO  Bul_TBL_FATURA_TURU(int ID);
        
        
         
	}
}
