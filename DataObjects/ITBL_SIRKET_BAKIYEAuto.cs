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
	public partial interface ITBL_SIRKET_BAKIYE   
    {
		/// <summary>
        ///TBL_SIRKET_BAKIYE  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_SIRKET_BAKIYE(TBL_SIRKET_BAKIYEDTO item);
        
        /// <summary>
        ///TBL_SIRKET_BAKIYE  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_SIRKET_BAKIYE(TBL_SIRKET_BAKIYEDTO item);
        
        /// <summary>
        ///TBL_SIRKET_BAKIYE  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_SIRKET_BAKIYE(TBL_SIRKET_BAKIYEDTO item);
		 /// <summary>
        ///TBL_SIRKET_BAKIYE  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_SIRKET_BAKIYEDTO>  Listele__TBL_SIRKET_BAKIYE();
         /// <summary>
        ///TBL_SIRKET_BAKIYE  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_SIRKET_BAKIYEDTO  Bul_TBL_SIRKET_BAKIYE(int ID);
        
        
         
	}
}
