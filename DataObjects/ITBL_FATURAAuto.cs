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
	public partial interface ITBL_FATURA   
    {
		/// <summary>
        ///TBL_FATURA  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_FATURA(TBL_FATURADTO item);
        
        /// <summary>
        ///TBL_FATURA  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_FATURA(TBL_FATURADTO item);
        
        /// <summary>
        ///TBL_FATURA  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_FATURA(TBL_FATURADTO item);
		 /// <summary>
        ///TBL_FATURA  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_FATURADTO>  Listele__TBL_FATURA();
         /// <summary>
        ///TBL_FATURA  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_FATURADTO  Bul_TBL_FATURA(int ID);
        
        
         
	}
}
