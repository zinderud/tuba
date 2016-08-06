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
	public partial interface ITBL_ODEME_TURU   
    {
		/// <summary>
        ///TBL_ODEME_TURU  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_ODEME_TURU(TBL_ODEME_TURUDTO item);
        
        /// <summary>
        ///TBL_ODEME_TURU  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_ODEME_TURU(TBL_ODEME_TURUDTO item);
        
        /// <summary>
        ///TBL_ODEME_TURU  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_ODEME_TURU(TBL_ODEME_TURUDTO item);
		 /// <summary>
        ///TBL_ODEME_TURU  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_ODEME_TURUDTO>  Listele__TBL_ODEME_TURU();
         /// <summary>
        ///TBL_ODEME_TURU  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_ODEME_TURUDTO  Bul_TBL_ODEME_TURU(int ID);
        
        
         
	}
}
