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
	public partial interface ITBL_URUN_CINSI   
    {
		/// <summary>
        ///TBL_URUN_CINSI  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_URUN_CINSI(TBL_URUN_CINSIDTO item);
        
        /// <summary>
        ///TBL_URUN_CINSI  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_URUN_CINSI(TBL_URUN_CINSIDTO item);
        
        /// <summary>
        ///TBL_URUN_CINSI  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_URUN_CINSI(TBL_URUN_CINSIDTO item);
		 /// <summary>
        ///TBL_URUN_CINSI  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_URUN_CINSIDTO>  Listele__TBL_URUN_CINSI();
         /// <summary>
        ///TBL_URUN_CINSI  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_URUN_CINSIDTO  Bul_TBL_URUN_CINSI(int ID);
        
        
         
	}
}
