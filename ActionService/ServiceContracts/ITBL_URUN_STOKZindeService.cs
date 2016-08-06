//===================================================================================
// Sio
// Sio
//===================================================================================

#region
using System.Collections.Generic;
using System.ServiceModel;
using System;
using System.Collections;
using System.Text;
using AutoBusinessObjects;
using DataObjects.EntityFramework;
#endregion

namespace ZindeService.ServiceContracts
{     
  
	public partial interface IZindeService
    {
		/// <summary>
        ///TBL_URUN_STOK  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_URUN_STOK(TBL_URUN_STOKDTO item);
        
        /// <summary>
        ///TBL_URUN_STOK  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_URUN_STOK(TBL_URUN_STOKDTO item);
        
        /// <summary>
        ///TBL_URUN_STOK  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_URUN_STOK(TBL_URUN_STOKDTO item);
		 /// <summary>
        ///TBL_URUN_STOK  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_URUN_STOKDTO>  Listele__TBL_URUN_STOK();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_URUN_STOKDTO  Bul_TBL_URUN_STOK(int ID);
	}
}
