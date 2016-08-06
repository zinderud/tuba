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
	public partial interface ITBL_URUN_FATURA   
    {
		/// <summary>
        ///TBL_URUN_FATURA  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_URUN_FATURA(TBL_URUN_FATURADTO item);
        
        /// <summary>
        ///TBL_URUN_FATURA  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_URUN_FATURA(TBL_URUN_FATURADTO item);
        
        /// <summary>
        ///TBL_URUN_FATURA  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_URUN_FATURA(TBL_URUN_FATURADTO item);
		 /// <summary>
        ///TBL_URUN_FATURA  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_URUN_FATURADTO>  Listele__TBL_URUN_FATURA();
         /// <summary>
        ///TBL_URUN_FATURA  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_URUN_FATURADTO  Bul_TBL_URUN_FATURA(int ID);
        
        
         
	}
}
