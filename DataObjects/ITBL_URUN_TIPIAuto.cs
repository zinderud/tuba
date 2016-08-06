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
	public partial interface ITBL_URUN_TIPI   
    {
		/// <summary>
        ///TBL_URUN_TIPI  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_URUN_TIPI(TBL_URUN_TIPIDTO item);
        
        /// <summary>
        ///TBL_URUN_TIPI  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_URUN_TIPI(TBL_URUN_TIPIDTO item);
        
        /// <summary>
        ///TBL_URUN_TIPI  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_URUN_TIPI(TBL_URUN_TIPIDTO item);
		 /// <summary>
        ///TBL_URUN_TIPI  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_URUN_TIPIDTO>  Listele__TBL_URUN_TIPI();
         /// <summary>
        ///TBL_URUN_TIPI  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_URUN_TIPIDTO  Bul_TBL_URUN_TIPI(int ID);
        
        
         
	}
}
