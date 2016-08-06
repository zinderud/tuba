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
        ///TBL_PERSONEL  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_PERSONEL(TBL_PERSONELDTO item);
        
        /// <summary>
        ///TBL_PERSONEL  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_PERSONEL(TBL_PERSONELDTO item);
        
        /// <summary>
        ///TBL_PERSONEL  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_PERSONEL(TBL_PERSONELDTO item);
		 /// <summary>
        ///TBL_PERSONEL  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_PERSONELDTO>  Listele__TBL_PERSONEL();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_PERSONELDTO  Bul_TBL_PERSONEL(int ID);
	}
}
