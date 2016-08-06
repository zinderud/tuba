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
        ///TBL_SIRKET_TIPI  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_SIRKET_TIPI(TBL_SIRKET_TIPIDTO item);
        
        /// <summary>
        ///TBL_SIRKET_TIPI  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_SIRKET_TIPI(TBL_SIRKET_TIPIDTO item);
        
        /// <summary>
        ///TBL_SIRKET_TIPI  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_SIRKET_TIPI(TBL_SIRKET_TIPIDTO item);
		 /// <summary>
        ///TBL_SIRKET_TIPI  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_SIRKET_TIPIDTO>  Listele__TBL_SIRKET_TIPI();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_SIRKET_TIPIDTO  Bul_TBL_SIRKET_TIPI(int ID);
	}
}
