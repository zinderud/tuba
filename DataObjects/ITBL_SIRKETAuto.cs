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
	public partial interface ITBL_SIRKET   
    {
		/// <summary>
        ///TBL_SIRKET  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_SIRKET(TBL_SIRKETDTO item);
        
        /// <summary>
        ///TBL_SIRKET  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_SIRKET(TBL_SIRKETDTO item);
        
        /// <summary>
        ///TBL_SIRKET  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_SIRKET(TBL_SIRKETDTO item);
		 /// <summary>
        ///TBL_SIRKET  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_SIRKETDTO>  Listele__TBL_SIRKET();
         /// <summary>
        ///TBL_SIRKET  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_SIRKETDTO  Bul_TBL_SIRKET(int ID);
        
        
         
	}
}
