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
	public partial interface ITBL_URUN_BIRIM   
    {
		/// <summary>
        ///TBL_URUN_BIRIM  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_URUN_BIRIM(TBL_URUN_BIRIMDTO item);
        
        /// <summary>
        ///TBL_URUN_BIRIM  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_URUN_BIRIM(TBL_URUN_BIRIMDTO item);
        
        /// <summary>
        ///TBL_URUN_BIRIM  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_URUN_BIRIM(TBL_URUN_BIRIMDTO item);
		 /// <summary>
        ///TBL_URUN_BIRIM  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_URUN_BIRIMDTO>  Listele__TBL_URUN_BIRIM();
         /// <summary>
        ///TBL_URUN_BIRIM  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_URUN_BIRIMDTO  Bul_TBL_URUN_BIRIM(int ID);
        
        
         
	}
}
