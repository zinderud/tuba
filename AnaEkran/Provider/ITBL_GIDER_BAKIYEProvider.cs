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
        ///TBL_GIDER_BAKIYE_MODEL  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        Task<bool>  Ekle__TBL_GIDER_BAKIYE_MODEL(TBL_GIDER_BAKIYE_MODEL item);
        
        /// <summary>
        ///TBL_GIDER_BAKIYE  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
      Task<bool>  Sil__TBL_GIDER_BAKIYE_MODEL(TBL_GIDER_BAKIYE_MODEL item);
        
        /// <summary>
        ///TBL_GIDER_BAKIYE  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		  
        Task<bool>  Degistir__TBL_GIDER_BAKIYE_MODEL(TBL_GIDER_BAKIYE_MODEL item);
		 /// <summary>
        ///TBL_GIDER_BAKIYE  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
	 
         Task<ObservableCollection<TBL_GIDER_BAKIYE_MODEL>>  Listele__TBL_GIDER_BAKIYE_MODEL();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         Task<TBL_GIDER_BAKIYE_MODEL>  Bul_TBL_GIDER_BAKIYE_MODEL(int ID);
	}
}
