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
	public partial interface ITBL_SPARIS   
    {
		/// <summary>
        ///TBL_SPARIS  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_SPARIS(TBL_SPARISDTO item);
        
        /// <summary>
        ///TBL_SPARIS  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_SPARIS(TBL_SPARISDTO item);
        
        /// <summary>
        ///TBL_SPARIS  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_SPARIS(TBL_SPARISDTO item);
		 /// <summary>
        ///TBL_SPARIS  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_SPARISDTO>  Listele__TBL_SPARIS();
         /// <summary>
        ///TBL_SPARIS  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_SPARISDTO  Bul_TBL_SPARIS(int ID);
        
        
         
	}
}
