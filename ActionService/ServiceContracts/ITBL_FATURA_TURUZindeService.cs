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
        ///TBL_FATURA_TURU  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_FATURA_TURU(TBL_FATURA_TURUDTO item);
        
        /// <summary>
        ///TBL_FATURA_TURU  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_FATURA_TURU(TBL_FATURA_TURUDTO item);
        
        /// <summary>
        ///TBL_FATURA_TURU  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_FATURA_TURU(TBL_FATURA_TURUDTO item);
		 /// <summary>
        ///TBL_FATURA_TURU  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_FATURA_TURUDTO>  Listele__TBL_FATURA_TURU();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_FATURA_TURUDTO  Bul_TBL_FATURA_TURU(int ID);
	}
}
