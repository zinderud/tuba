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
        ///TBL_URUN_BIRIM  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_URUN_BIRIM(TBL_URUN_BIRIMDTO item);
        
        /// <summary>
        ///TBL_URUN_BIRIM  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_URUN_BIRIM(TBL_URUN_BIRIMDTO item);
        
        /// <summary>
        ///TBL_URUN_BIRIM  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_URUN_BIRIM(TBL_URUN_BIRIMDTO item);
		 /// <summary>
        ///TBL_URUN_BIRIM  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_URUN_BIRIMDTO>  Listele__TBL_URUN_BIRIM();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_URUN_BIRIMDTO  Bul_TBL_URUN_BIRIM(int ID);
	}
}
