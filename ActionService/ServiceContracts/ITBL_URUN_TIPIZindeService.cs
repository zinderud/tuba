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
        ///TBL_URUN_TIPI  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_URUN_TIPI(TBL_URUN_TIPIDTO item);
        
        /// <summary>
        ///TBL_URUN_TIPI  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_URUN_TIPI(TBL_URUN_TIPIDTO item);
        
        /// <summary>
        ///TBL_URUN_TIPI  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_URUN_TIPI(TBL_URUN_TIPIDTO item);
		 /// <summary>
        ///TBL_URUN_TIPI  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_URUN_TIPIDTO>  Listele__TBL_URUN_TIPI();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_URUN_TIPIDTO  Bul_TBL_URUN_TIPI(int ID);
	}
}
