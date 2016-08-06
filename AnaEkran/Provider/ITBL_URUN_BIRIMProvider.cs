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
        ///TBL_URUN_BIRIM_MODEL  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        Task<bool>  Ekle__TBL_URUN_BIRIM_MODEL(TBL_URUN_BIRIM_MODEL item);
        
        /// <summary>
        ///TBL_URUN_BIRIM  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
      Task<bool>  Sil__TBL_URUN_BIRIM_MODEL(TBL_URUN_BIRIM_MODEL item);
        
        /// <summary>
        ///TBL_URUN_BIRIM  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		  
        Task<bool>  Degistir__TBL_URUN_BIRIM_MODEL(TBL_URUN_BIRIM_MODEL item);
		 /// <summary>
        ///TBL_URUN_BIRIM  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
	 
         Task<ObservableCollection<TBL_URUN_BIRIM_MODEL>>  Listele__TBL_URUN_BIRIM_MODEL();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         Task<TBL_URUN_BIRIM_MODEL>  Bul_TBL_URUN_BIRIM_MODEL(int ID);
	}
}
