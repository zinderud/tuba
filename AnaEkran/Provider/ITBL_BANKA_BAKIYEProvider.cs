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
        ///TBL_BANKA_BAKIYE_MODEL  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        Task<bool>  Ekle__TBL_BANKA_BAKIYE_MODEL(TBL_BANKA_BAKIYE_MODEL item);
        
        /// <summary>
        ///TBL_BANKA_BAKIYE  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
      Task<bool>  Sil__TBL_BANKA_BAKIYE_MODEL(TBL_BANKA_BAKIYE_MODEL item);
        
        /// <summary>
        ///TBL_BANKA_BAKIYE  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		  
        Task<bool>  Degistir__TBL_BANKA_BAKIYE_MODEL(TBL_BANKA_BAKIYE_MODEL item);
		 /// <summary>
        ///TBL_BANKA_BAKIYE  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
	 
         Task<ObservableCollection<TBL_BANKA_BAKIYE_MODEL>>  Listele__TBL_BANKA_BAKIYE_MODEL();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         Task<TBL_BANKA_BAKIYE_MODEL>  Bul_TBL_BANKA_BAKIYE_MODEL(int ID);
	}
}
