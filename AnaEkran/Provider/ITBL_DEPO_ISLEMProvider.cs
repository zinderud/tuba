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
        ///TBL_DEPO_ISLEM_MODEL  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        Task<bool>  Ekle__TBL_DEPO_ISLEM_MODEL(TBL_DEPO_ISLEM_MODEL item);
        
        /// <summary>
        ///TBL_DEPO_ISLEM  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
      Task<bool>  Sil__TBL_DEPO_ISLEM_MODEL(TBL_DEPO_ISLEM_MODEL item);
        
        /// <summary>
        ///TBL_DEPO_ISLEM  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		  
        Task<bool>  Degistir__TBL_DEPO_ISLEM_MODEL(TBL_DEPO_ISLEM_MODEL item);
		 /// <summary>
        ///TBL_DEPO_ISLEM  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
	 
         Task<ObservableCollection<TBL_DEPO_ISLEM_MODEL>>  Listele__TBL_DEPO_ISLEM_MODEL();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         Task<TBL_DEPO_ISLEM_MODEL>  Bul_TBL_DEPO_ISLEM_MODEL(int ID);
	}
}
