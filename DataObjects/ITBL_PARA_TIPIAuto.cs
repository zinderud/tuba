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
	public partial interface ITBL_PARA_TIPI   
    {
		/// <summary>
        ///TBL_PARA_TIPI  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_PARA_TIPI(TBL_PARA_TIPIDTO item);
        
        /// <summary>
        ///TBL_PARA_TIPI  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_PARA_TIPI(TBL_PARA_TIPIDTO item);
        
        /// <summary>
        ///TBL_PARA_TIPI  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_PARA_TIPI(TBL_PARA_TIPIDTO item);
		 /// <summary>
        ///TBL_PARA_TIPI  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_PARA_TIPIDTO>  Listele__TBL_PARA_TIPI();
         /// <summary>
        ///TBL_PARA_TIPI  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_PARA_TIPIDTO  Bul_TBL_PARA_TIPI(int ID);
        
        
         
	}
}
