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
	public partial interface ITBL_BANKA   
    {
		/// <summary>
        ///TBL_BANKA  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_BANKA(TBL_BANKADTO item);
        
        /// <summary>
        ///TBL_BANKA  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_BANKA(TBL_BANKADTO item);
        
        /// <summary>
        ///TBL_BANKA  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_BANKA(TBL_BANKADTO item);
		 /// <summary>
        ///TBL_BANKA  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_BANKADTO>  Listele__TBL_BANKA();
         /// <summary>
        ///TBL_BANKA  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_BANKADTO  Bul_TBL_BANKA(int ID);
        
        
         
	}
}
