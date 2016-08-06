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
        ///TBL_KASA_MODEL  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        Task<bool>  Ekle__TBL_KASA_MODEL(TBL_KASA_MODEL item);
        
        /// <summary>
        ///TBL_KASA  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
      Task<bool>  Sil__TBL_KASA_MODEL(TBL_KASA_MODEL item);
        
        /// <summary>
        ///TBL_KASA  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		  
        Task<bool>  Degistir__TBL_KASA_MODEL(TBL_KASA_MODEL item);
		 /// <summary>
        ///TBL_KASA  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
	 
         Task<ObservableCollection<TBL_KASA_MODEL>>  Listele__TBL_KASA_MODEL();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         Task<TBL_KASA_MODEL>  Bul_TBL_KASA_MODEL(int ID);
	}
}
