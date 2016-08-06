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
	public partial interface ITBL_KASA_BAKIYE   
    {
		/// <summary>
        ///TBL_KASA_BAKIYE  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_KASA_BAKIYE(TBL_KASA_BAKIYEDTO item);
        
        /// <summary>
        ///TBL_KASA_BAKIYE  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_KASA_BAKIYE(TBL_KASA_BAKIYEDTO item);
        
        /// <summary>
        ///TBL_KASA_BAKIYE  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_KASA_BAKIYE(TBL_KASA_BAKIYEDTO item);
		 /// <summary>
        ///TBL_KASA_BAKIYE  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_KASA_BAKIYEDTO>  Listele__TBL_KASA_BAKIYE();
         /// <summary>
        ///TBL_KASA_BAKIYE  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_KASA_BAKIYEDTO  Bul_TBL_KASA_BAKIYE(int ID);
        
        
         
	}
}
