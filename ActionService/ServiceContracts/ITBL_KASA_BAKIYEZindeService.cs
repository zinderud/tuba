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
        ///TBL_KASA_BAKIYE  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_KASA_BAKIYE(TBL_KASA_BAKIYEDTO item);
        
        /// <summary>
        ///TBL_KASA_BAKIYE  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_KASA_BAKIYE(TBL_KASA_BAKIYEDTO item);
        
        /// <summary>
        ///TBL_KASA_BAKIYE  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_KASA_BAKIYE(TBL_KASA_BAKIYEDTO item);
		 /// <summary>
        ///TBL_KASA_BAKIYE  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_KASA_BAKIYEDTO>  Listele__TBL_KASA_BAKIYE();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_KASA_BAKIYEDTO  Bul_TBL_KASA_BAKIYE(int ID);
	}
}
