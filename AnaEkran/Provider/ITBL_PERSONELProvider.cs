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
        ///TBL_PERSONEL_MODEL  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        Task<bool>  Ekle__TBL_PERSONEL_MODEL(TBL_PERSONEL_MODEL item);
        
        /// <summary>
        ///TBL_PERSONEL  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
      Task<bool>  Sil__TBL_PERSONEL_MODEL(TBL_PERSONEL_MODEL item);
        
        /// <summary>
        ///TBL_PERSONEL  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		  
        Task<bool>  Degistir__TBL_PERSONEL_MODEL(TBL_PERSONEL_MODEL item);
		 /// <summary>
        ///TBL_PERSONEL  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
	 
         Task<ObservableCollection<TBL_PERSONEL_MODEL>>  Listele__TBL_PERSONEL_MODEL();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         Task<TBL_PERSONEL_MODEL>  Bul_TBL_PERSONEL_MODEL(int ID);
	}
}
