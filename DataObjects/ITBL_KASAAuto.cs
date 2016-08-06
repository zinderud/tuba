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
	public partial interface ITBL_KASA   
    {
		/// <summary>
        ///TBL_KASA  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_KASA(TBL_KASADTO item);
        
        /// <summary>
        ///TBL_KASA  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_KASA(TBL_KASADTO item);
        
        /// <summary>
        ///TBL_KASA  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_KASA(TBL_KASADTO item);
		 /// <summary>
        ///TBL_KASA  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_KASADTO>  Listele__TBL_KASA();
         /// <summary>
        ///TBL_KASA  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_KASADTO  Bul_TBL_KASA(int ID);
        
        
         
	}
}
