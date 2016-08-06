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
        ///TBL_ODEME_TIPI  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_ODEME_TIPI(TBL_ODEME_TIPIDTO item);
        
        /// <summary>
        ///TBL_ODEME_TIPI  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_ODEME_TIPI(TBL_ODEME_TIPIDTO item);
        
        /// <summary>
        ///TBL_ODEME_TIPI  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_ODEME_TIPI(TBL_ODEME_TIPIDTO item);
		 /// <summary>
        ///TBL_ODEME_TIPI  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_ODEME_TIPIDTO>  Listele__TBL_ODEME_TIPI();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_ODEME_TIPIDTO  Bul_TBL_ODEME_TIPI(int ID);
	}
}
