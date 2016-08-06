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
        ///TBL_BANKA_BAKIYE  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_BANKA_BAKIYE(TBL_BANKA_BAKIYEDTO item);
        
        /// <summary>
        ///TBL_BANKA_BAKIYE  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_BANKA_BAKIYE(TBL_BANKA_BAKIYEDTO item);
        
        /// <summary>
        ///TBL_BANKA_BAKIYE  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_BANKA_BAKIYE(TBL_BANKA_BAKIYEDTO item);
		 /// <summary>
        ///TBL_BANKA_BAKIYE  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_BANKA_BAKIYEDTO>  Listele__TBL_BANKA_BAKIYE();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_BANKA_BAKIYEDTO  Bul_TBL_BANKA_BAKIYE(int ID);
	}
}
