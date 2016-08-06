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
	public partial interface ITBL_SIRKET_SINIF   
    {
		/// <summary>
        ///TBL_SIRKET_SINIF  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_SIRKET_SINIF(TBL_SIRKET_SINIFDTO item);
        
        /// <summary>
        ///TBL_SIRKET_SINIF  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_SIRKET_SINIF(TBL_SIRKET_SINIFDTO item);
        
        /// <summary>
        ///TBL_SIRKET_SINIF  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_SIRKET_SINIF(TBL_SIRKET_SINIFDTO item);
		 /// <summary>
        ///TBL_SIRKET_SINIF  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_SIRKET_SINIFDTO>  Listele__TBL_SIRKET_SINIF();
         /// <summary>
        ///TBL_SIRKET_SINIF  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_SIRKET_SINIFDTO  Bul_TBL_SIRKET_SINIF(int ID);
        
        
         
	}
}
