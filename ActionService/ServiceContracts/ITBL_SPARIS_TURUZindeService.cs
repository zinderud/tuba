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
        ///TBL_SPARIS_TURU  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_SPARIS_TURU(TBL_SPARIS_TURUDTO item);
        
        /// <summary>
        ///TBL_SPARIS_TURU  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_SPARIS_TURU(TBL_SPARIS_TURUDTO item);
        
        /// <summary>
        ///TBL_SPARIS_TURU  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_SPARIS_TURU(TBL_SPARIS_TURUDTO item);
		 /// <summary>
        ///TBL_SPARIS_TURU  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_SPARIS_TURUDTO>  Listele__TBL_SPARIS_TURU();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_SPARIS_TURUDTO  Bul_TBL_SPARIS_TURU(int ID);
	}
}
