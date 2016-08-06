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
	public partial interface ITBL_KDV   
    {
		/// <summary>
        ///TBL_KDV  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_KDV(TBL_KDVDTO item);
        
        /// <summary>
        ///TBL_KDV  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_KDV(TBL_KDVDTO item);
        
        /// <summary>
        ///TBL_KDV  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_KDV(TBL_KDVDTO item);
		 /// <summary>
        ///TBL_KDV  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_KDVDTO>  Listele__TBL_KDV();
         /// <summary>
        ///TBL_KDV  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_KDVDTO  Bul_TBL_KDV(int ID);
        
        
         
	}
}
