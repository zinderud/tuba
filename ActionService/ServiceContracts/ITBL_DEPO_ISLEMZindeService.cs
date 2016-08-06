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
        ///TBL_DEPO_ISLEM  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_DEPO_ISLEM(TBL_DEPO_ISLEMDTO item);
        
        /// <summary>
        ///TBL_DEPO_ISLEM  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_DEPO_ISLEM(TBL_DEPO_ISLEMDTO item);
        
        /// <summary>
        ///TBL_DEPO_ISLEM  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_DEPO_ISLEM(TBL_DEPO_ISLEMDTO item);
		 /// <summary>
        ///TBL_DEPO_ISLEM  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_DEPO_ISLEMDTO>  Listele__TBL_DEPO_ISLEM();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_DEPO_ISLEMDTO  Bul_TBL_DEPO_ISLEM(int ID);
	}
}
