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
	public partial interface ITBL_PERSONEL   
    {
		/// <summary>
        ///TBL_PERSONEL  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_PERSONEL(TBL_PERSONELDTO item);
        
        /// <summary>
        ///TBL_PERSONEL  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_PERSONEL(TBL_PERSONELDTO item);
        
        /// <summary>
        ///TBL_PERSONEL  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_PERSONEL(TBL_PERSONELDTO item);
		 /// <summary>
        ///TBL_PERSONEL  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_PERSONELDTO>  Listele__TBL_PERSONEL();
         /// <summary>
        ///TBL_PERSONEL  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_PERSONELDTO  Bul_TBL_PERSONEL(int ID);
        
        
         
	}
}
