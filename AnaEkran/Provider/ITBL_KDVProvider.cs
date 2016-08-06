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
        ///TBL_KDV_MODEL  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        Task<bool>  Ekle__TBL_KDV_MODEL(TBL_KDV_MODEL item);
        
        /// <summary>
        ///TBL_KDV  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
      Task<bool>  Sil__TBL_KDV_MODEL(TBL_KDV_MODEL item);
        
        /// <summary>
        ///TBL_KDV  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		  
        Task<bool>  Degistir__TBL_KDV_MODEL(TBL_KDV_MODEL item);
		 /// <summary>
        ///TBL_KDV  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
	 
         Task<ObservableCollection<TBL_KDV_MODEL>>  Listele__TBL_KDV_MODEL();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         Task<TBL_KDV_MODEL>  Bul_TBL_KDV_MODEL(int ID);
	}
}
