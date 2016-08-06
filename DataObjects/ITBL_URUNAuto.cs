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
	public partial interface ITBL_URUN   
    {
		/// <summary>
        ///TBL_URUN  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_URUN(TBL_URUNDTO item);
        
        /// <summary>
        ///TBL_URUN  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_URUN(TBL_URUNDTO item);
        
        /// <summary>
        ///TBL_URUN  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_URUN(TBL_URUNDTO item);
		 /// <summary>
        ///TBL_URUN  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_URUNDTO>  Listele__TBL_URUN();
         /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_URUNDTO  Bul_TBL_URUN(int ID);
        
        
         
	}
}
