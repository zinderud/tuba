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
        ///TBL_SIRKET_SINIF  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_SIRKET_SINIF(TBL_SIRKET_SINIFDTO item);
        
        /// <summary>
        ///TBL_SIRKET_SINIF  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_SIRKET_SINIF(TBL_SIRKET_SINIFDTO item);
        
        /// <summary>
        ///TBL_SIRKET_SINIF  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_SIRKET_SINIF(TBL_SIRKET_SINIFDTO item);
		 /// <summary>
        ///TBL_SIRKET_SINIF  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_SIRKET_SINIFDTO>  Listele__TBL_SIRKET_SINIF();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_SIRKET_SINIFDTO  Bul_TBL_SIRKET_SINIF(int ID);
	}
}
