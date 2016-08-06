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
	public partial interface ITBL_SIRKET_TIPI   
    {
		/// <summary>
        ///TBL_SIRKET_TIPI  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_SIRKET_TIPI(TBL_SIRKET_TIPIDTO item);
        
        /// <summary>
        ///TBL_SIRKET_TIPI  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_SIRKET_TIPI(TBL_SIRKET_TIPIDTO item);
        
        /// <summary>
        ///TBL_SIRKET_TIPI  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_SIRKET_TIPI(TBL_SIRKET_TIPIDTO item);
		 /// <summary>
        ///TBL_SIRKET_TIPI  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_SIRKET_TIPIDTO>  Listele__TBL_SIRKET_TIPI();
         /// <summary>
        ///TBL_SIRKET_TIPI  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_SIRKET_TIPIDTO  Bul_TBL_SIRKET_TIPI(int ID);
        
        
         
	}
}
