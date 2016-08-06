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
        ///TBL_FATURA_MODEL  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        Task<bool>  Ekle__TBL_FATURA_MODEL(TBL_FATURA_MODEL item);
        
        /// <summary>
        ///TBL_FATURA  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
      Task<bool>  Sil__TBL_FATURA_MODEL(TBL_FATURA_MODEL item);
        
        /// <summary>
        ///TBL_FATURA  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		  
        Task<bool>  Degistir__TBL_FATURA_MODEL(TBL_FATURA_MODEL item);
		 /// <summary>
        ///TBL_FATURA  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
	 
         Task<ObservableCollection<TBL_FATURA_MODEL>>  Listele__TBL_FATURA_MODEL();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         Task<TBL_FATURA_MODEL>  Bul_TBL_FATURA_MODEL(int ID);
	}
}
