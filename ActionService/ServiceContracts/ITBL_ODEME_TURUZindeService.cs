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
        ///TBL_ODEME_TURU  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_ODEME_TURU(TBL_ODEME_TURUDTO item);
        
        /// <summary>
        ///TBL_ODEME_TURU  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_ODEME_TURU(TBL_ODEME_TURUDTO item);
        
        /// <summary>
        ///TBL_ODEME_TURU  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_ODEME_TURU(TBL_ODEME_TURUDTO item);
		 /// <summary>
        ///TBL_ODEME_TURU  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_ODEME_TURUDTO>  Listele__TBL_ODEME_TURU();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_ODEME_TURUDTO  Bul_TBL_ODEME_TURU(int ID);
	}
}
