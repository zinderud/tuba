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
	public partial interface ITBL_DEPO_TRANSFER   
    {
		/// <summary>
        ///TBL_DEPO_TRANSFER  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_DEPO_TRANSFER(TBL_DEPO_TRANSFERDTO item);
        
        /// <summary>
        ///TBL_DEPO_TRANSFER  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_DEPO_TRANSFER(TBL_DEPO_TRANSFERDTO item);
        
        /// <summary>
        ///TBL_DEPO_TRANSFER  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_DEPO_TRANSFER(TBL_DEPO_TRANSFERDTO item);
		 /// <summary>
        ///TBL_DEPO_TRANSFER  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_DEPO_TRANSFERDTO>  Listele__TBL_DEPO_TRANSFER();
         /// <summary>
        ///TBL_DEPO_TRANSFER  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_DEPO_TRANSFERDTO  Bul_TBL_DEPO_TRANSFER(int ID);
        
        
         
	}
}
