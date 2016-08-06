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
	public partial interface ITBL_URUN_SPARIS   
    {
		/// <summary>
        ///TBL_URUN_SPARIS  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_URUN_SPARIS(TBL_URUN_SPARISDTO item);
        
        /// <summary>
        ///TBL_URUN_SPARIS  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_URUN_SPARIS(TBL_URUN_SPARISDTO item);
        
        /// <summary>
        ///TBL_URUN_SPARIS  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_URUN_SPARIS(TBL_URUN_SPARISDTO item);
		 /// <summary>
        ///TBL_URUN_SPARIS  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_URUN_SPARISDTO>  Listele__TBL_URUN_SPARIS();
         /// <summary>
        ///TBL_URUN_SPARIS  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_URUN_SPARISDTO  Bul_TBL_URUN_SPARIS(int ID);
        
        
         
	}
}
