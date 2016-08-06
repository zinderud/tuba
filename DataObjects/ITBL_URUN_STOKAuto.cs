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
	public partial interface ITBL_URUN_STOK   
    {
		/// <summary>
        ///TBL_URUN_STOK  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_URUN_STOK(TBL_URUN_STOKDTO item);
        
        /// <summary>
        ///TBL_URUN_STOK  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_URUN_STOK(TBL_URUN_STOKDTO item);
        
        /// <summary>
        ///TBL_URUN_STOK  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_URUN_STOK(TBL_URUN_STOKDTO item);
		 /// <summary>
        ///TBL_URUN_STOK  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_URUN_STOKDTO>  Listele__TBL_URUN_STOK();
         /// <summary>
        ///TBL_URUN_STOK  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_URUN_STOKDTO  Bul_TBL_URUN_STOK(int ID);
        
        
         
	}
}
