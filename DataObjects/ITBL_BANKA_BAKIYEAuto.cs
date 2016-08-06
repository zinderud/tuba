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
	public partial interface ITBL_BANKA_BAKIYE   
    {
		/// <summary>
        ///TBL_BANKA_BAKIYE  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_BANKA_BAKIYE(TBL_BANKA_BAKIYEDTO item);
        
        /// <summary>
        ///TBL_BANKA_BAKIYE  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_BANKA_BAKIYE(TBL_BANKA_BAKIYEDTO item);
        
        /// <summary>
        ///TBL_BANKA_BAKIYE  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_BANKA_BAKIYE(TBL_BANKA_BAKIYEDTO item);
		 /// <summary>
        ///TBL_BANKA_BAKIYE  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_BANKA_BAKIYEDTO>  Listele__TBL_BANKA_BAKIYE();
         /// <summary>
        ///TBL_BANKA_BAKIYE  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_BANKA_BAKIYEDTO  Bul_TBL_BANKA_BAKIYE(int ID);
        
        
         
	}
}
