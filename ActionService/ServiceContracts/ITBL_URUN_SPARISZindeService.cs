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
        ///TBL_URUN_SPARIS  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_URUN_SPARIS(TBL_URUN_SPARISDTO item);
        
        /// <summary>
        ///TBL_URUN_SPARIS  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_URUN_SPARIS(TBL_URUN_SPARISDTO item);
        
        /// <summary>
        ///TBL_URUN_SPARIS  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_URUN_SPARIS(TBL_URUN_SPARISDTO item);
		 /// <summary>
        ///TBL_URUN_SPARIS  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_URUN_SPARISDTO>  Listele__TBL_URUN_SPARIS();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_URUN_SPARISDTO  Bul_TBL_URUN_SPARIS(int ID);
	}
}
