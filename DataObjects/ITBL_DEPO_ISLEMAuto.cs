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
	public partial interface ITBL_DEPO_ISLEM   
    {
		/// <summary>
        ///TBL_DEPO_ISLEM  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_DEPO_ISLEM(TBL_DEPO_ISLEMDTO item);
        
        /// <summary>
        ///TBL_DEPO_ISLEM  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_DEPO_ISLEM(TBL_DEPO_ISLEMDTO item);
        
        /// <summary>
        ///TBL_DEPO_ISLEM  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_DEPO_ISLEM(TBL_DEPO_ISLEMDTO item);
		 /// <summary>
        ///TBL_DEPO_ISLEM  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_DEPO_ISLEMDTO>  Listele__TBL_DEPO_ISLEM();
         /// <summary>
        ///TBL_DEPO_ISLEM  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_DEPO_ISLEMDTO  Bul_TBL_DEPO_ISLEM(int ID);
        
        
         
	}
}
