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
        ///TBL_SIRKET_TIPI_MODEL  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        Task<bool>  Ekle__TBL_SIRKET_TIPI_MODEL(TBL_SIRKET_TIPI_MODEL item);
        
        /// <summary>
        ///TBL_SIRKET_TIPI  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
      Task<bool>  Sil__TBL_SIRKET_TIPI_MODEL(TBL_SIRKET_TIPI_MODEL item);
        
        /// <summary>
        ///TBL_SIRKET_TIPI  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		  
        Task<bool>  Degistir__TBL_SIRKET_TIPI_MODEL(TBL_SIRKET_TIPI_MODEL item);
		 /// <summary>
        ///TBL_SIRKET_TIPI  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
	 
         Task<ObservableCollection<TBL_SIRKET_TIPI_MODEL>>  Listele__TBL_SIRKET_TIPI_MODEL();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         Task<TBL_SIRKET_TIPI_MODEL>  Bul_TBL_SIRKET_TIPI_MODEL(int ID);
	}
}
