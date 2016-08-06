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
        ///TBL_BANKA_MODEL  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        Task<bool>  Ekle__TBL_BANKA_MODEL(TBL_BANKA_MODEL item);
        
        /// <summary>
        ///TBL_BANKA  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
      Task<bool>  Sil__TBL_BANKA_MODEL(TBL_BANKA_MODEL item);
        
        /// <summary>
        ///TBL_BANKA  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		  
        Task<bool>  Degistir__TBL_BANKA_MODEL(TBL_BANKA_MODEL item);
		 /// <summary>
        ///TBL_BANKA  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
	 
         Task<ObservableCollection<TBL_BANKA_MODEL>>  Listele__TBL_BANKA_MODEL();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         Task<TBL_BANKA_MODEL>  Bul_TBL_BANKA_MODEL(int ID);
	}
}
