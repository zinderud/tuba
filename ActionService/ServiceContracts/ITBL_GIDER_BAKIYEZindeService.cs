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
        ///TBL_GIDER_BAKIYE  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_GIDER_BAKIYE(TBL_GIDER_BAKIYEDTO item);
        
        /// <summary>
        ///TBL_GIDER_BAKIYE  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_GIDER_BAKIYE(TBL_GIDER_BAKIYEDTO item);
        
        /// <summary>
        ///TBL_GIDER_BAKIYE  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_GIDER_BAKIYE(TBL_GIDER_BAKIYEDTO item);
		 /// <summary>
        ///TBL_GIDER_BAKIYE  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_GIDER_BAKIYEDTO>  Listele__TBL_GIDER_BAKIYE();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_GIDER_BAKIYEDTO  Bul_TBL_GIDER_BAKIYE(int ID);
	}
}
