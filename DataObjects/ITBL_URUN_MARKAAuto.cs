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
	public partial interface ITBL_URUN_MARKA   
    {
		/// <summary>
        ///TBL_URUN_MARKA  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_URUN_MARKA(TBL_URUN_MARKADTO item);
        
        /// <summary>
        ///TBL_URUN_MARKA  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_URUN_MARKA(TBL_URUN_MARKADTO item);
        
        /// <summary>
        ///TBL_URUN_MARKA  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_URUN_MARKA(TBL_URUN_MARKADTO item);
		 /// <summary>
        ///TBL_URUN_MARKA  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_URUN_MARKADTO>  Listele__TBL_URUN_MARKA();
         /// <summary>
        ///TBL_URUN_MARKA  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_URUN_MARKADTO  Bul_TBL_URUN_MARKA(int ID);
        
        
         
	}
}
