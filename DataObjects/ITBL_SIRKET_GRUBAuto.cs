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
	public partial interface ITBL_SIRKET_GRUB   
    {
		/// <summary>
        ///TBL_SIRKET_GRUB  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_SIRKET_GRUB(TBL_SIRKET_GRUBDTO item);
        
        /// <summary>
        ///TBL_SIRKET_GRUB  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_SIRKET_GRUB(TBL_SIRKET_GRUBDTO item);
        
        /// <summary>
        ///TBL_SIRKET_GRUB  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_SIRKET_GRUB(TBL_SIRKET_GRUBDTO item);
		 /// <summary>
        ///TBL_SIRKET_GRUB  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_SIRKET_GRUBDTO>  Listele__TBL_SIRKET_GRUB();
         /// <summary>
        ///TBL_SIRKET_GRUB  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_SIRKET_GRUBDTO  Bul_TBL_SIRKET_GRUB(int ID);
        
        
         
	}
}
