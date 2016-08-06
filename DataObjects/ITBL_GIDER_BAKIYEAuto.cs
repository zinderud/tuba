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
	public partial interface ITBL_GIDER_BAKIYE   
    {
		/// <summary>
        ///TBL_GIDER_BAKIYE  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_GIDER_BAKIYE(TBL_GIDER_BAKIYEDTO item);
        
        /// <summary>
        ///TBL_GIDER_BAKIYE  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_GIDER_BAKIYE(TBL_GIDER_BAKIYEDTO item);
        
        /// <summary>
        ///TBL_GIDER_BAKIYE  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_GIDER_BAKIYE(TBL_GIDER_BAKIYEDTO item);
		 /// <summary>
        ///TBL_GIDER_BAKIYE  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_GIDER_BAKIYEDTO>  Listele__TBL_GIDER_BAKIYE();
         /// <summary>
        ///TBL_GIDER_BAKIYE  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_GIDER_BAKIYEDTO  Bul_TBL_GIDER_BAKIYE(int ID);
        
        
         
	}
}
