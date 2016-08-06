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
	public partial interface ITBL_DEPO   
    {
		/// <summary>
        ///TBL_DEPO  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_DEPO(TBL_DEPODTO item);
        
        /// <summary>
        ///TBL_DEPO  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_DEPO(TBL_DEPODTO item);
        
        /// <summary>
        ///TBL_DEPO  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_DEPO(TBL_DEPODTO item);
		 /// <summary>
        ///TBL_DEPO  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_DEPODTO>  Listele__TBL_DEPO();
         /// <summary>
        ///TBL_DEPO  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_DEPODTO  Bul_TBL_DEPO(int ID);
        
        
         
	}
}
