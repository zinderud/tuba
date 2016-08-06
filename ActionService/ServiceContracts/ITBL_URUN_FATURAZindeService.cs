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
        ///TBL_URUN_FATURA  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_URUN_FATURA(TBL_URUN_FATURADTO item);
        
        /// <summary>
        ///TBL_URUN_FATURA  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_URUN_FATURA(TBL_URUN_FATURADTO item);
        
        /// <summary>
        ///TBL_URUN_FATURA  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_URUN_FATURA(TBL_URUN_FATURADTO item);
		 /// <summary>
        ///TBL_URUN_FATURA  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_URUN_FATURADTO>  Listele__TBL_URUN_FATURA();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_URUN_FATURADTO  Bul_TBL_URUN_FATURA(int ID);
	}
}
