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
        ///TBL_PARA_TIPI  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_PARA_TIPI(TBL_PARA_TIPIDTO item);
        
        /// <summary>
        ///TBL_PARA_TIPI  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_PARA_TIPI(TBL_PARA_TIPIDTO item);
        
        /// <summary>
        ///TBL_PARA_TIPI  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_PARA_TIPI(TBL_PARA_TIPIDTO item);
		 /// <summary>
        ///TBL_PARA_TIPI  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_PARA_TIPIDTO>  Listele__TBL_PARA_TIPI();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_PARA_TIPIDTO  Bul_TBL_PARA_TIPI(int ID);
	}
}
