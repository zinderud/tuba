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
        ///TBL_DEPO_TRANSFER  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_DEPO_TRANSFER(TBL_DEPO_TRANSFERDTO item);
        
        /// <summary>
        ///TBL_DEPO_TRANSFER  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_DEPO_TRANSFER(TBL_DEPO_TRANSFERDTO item);
        
        /// <summary>
        ///TBL_DEPO_TRANSFER  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_DEPO_TRANSFER(TBL_DEPO_TRANSFERDTO item);
		 /// <summary>
        ///TBL_DEPO_TRANSFER  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_DEPO_TRANSFERDTO>  Listele__TBL_DEPO_TRANSFER();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_DEPO_TRANSFERDTO  Bul_TBL_DEPO_TRANSFER(int ID);
	}
}
