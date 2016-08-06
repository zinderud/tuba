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
        ///TBL_FIS_MODEL  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        Task<bool>  Ekle__TBL_FIS_MODEL(TBL_FIS_MODEL item);
        
        /// <summary>
        ///TBL_FIS  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
      Task<bool>  Sil__TBL_FIS_MODEL(TBL_FIS_MODEL item);
        
        /// <summary>
        ///TBL_FIS  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		  
        Task<bool>  Degistir__TBL_FIS_MODEL(TBL_FIS_MODEL item);
		 /// <summary>
        ///TBL_FIS  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
	 
         Task<ObservableCollection<TBL_FIS_MODEL>>  Listele__TBL_FIS_MODEL();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         Task<TBL_FIS_MODEL>  Bul_TBL_FIS_MODEL(int ID);
	}
}
