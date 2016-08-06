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
	public partial interface ITBL_ODEME_TIPI   
    {
		/// <summary>
        ///TBL_ODEME_TIPI  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_ODEME_TIPI(TBL_ODEME_TIPIDTO item);
        
        /// <summary>
        ///TBL_ODEME_TIPI  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_ODEME_TIPI(TBL_ODEME_TIPIDTO item);
        
        /// <summary>
        ///TBL_ODEME_TIPI  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_ODEME_TIPI(TBL_ODEME_TIPIDTO item);
		 /// <summary>
        ///TBL_ODEME_TIPI  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_ODEME_TIPIDTO>  Listele__TBL_ODEME_TIPI();
         /// <summary>
        ///TBL_ODEME_TIPI  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_ODEME_TIPIDTO  Bul_TBL_ODEME_TIPI(int ID);
        
        
         
	}
}
