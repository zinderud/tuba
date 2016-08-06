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
	public partial interface ITBL_FIS   
    {
		/// <summary>
        ///TBL_FIS  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_FIS(TBL_FISDTO item);
        
        /// <summary>
        ///TBL_FIS  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_FIS(TBL_FISDTO item);
        
        /// <summary>
        ///TBL_FIS  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_FIS(TBL_FISDTO item);
		 /// <summary>
        ///TBL_FIS  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_FISDTO>  Listele__TBL_FIS();
         /// <summary>
        ///TBL_FIS  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_FISDTO  Bul_TBL_FIS(int ID);
        
        
         
	}
}
