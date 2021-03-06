//===================================================================================
// Sio
// Sio
//===================================================================================

#region
using System.Collections.Generic;
 
using System;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using AnaEkran.Models;
using System.Collections.ObjectModel;

#endregion

namespace AnaEkran.Provider
{     
 
	public partial interface IProvider
    {
		/// <summary>
        ///TBL_SPARIS_TURU_MODEL  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        Task<bool>  Ekle__TBL_SPARIS_TURU_MODEL(TBL_SPARIS_TURU_MODEL item);
        
        /// <summary>
        ///TBL_SPARIS_TURU  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
      Task<bool>  Sil__TBL_SPARIS_TURU_MODEL(TBL_SPARIS_TURU_MODEL item);
        
        /// <summary>
        ///TBL_SPARIS_TURU  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		  
        Task<bool>  Degistir__TBL_SPARIS_TURU_MODEL(TBL_SPARIS_TURU_MODEL item);
		 /// <summary>
        ///TBL_SPARIS_TURU  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
	 
         Task<ObservableCollection<TBL_SPARIS_TURU_MODEL>>  Listele__TBL_SPARIS_TURU_MODEL();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         Task<TBL_SPARIS_TURU_MODEL>  Bul_TBL_SPARIS_TURU_MODEL(int ID);
	}
}
