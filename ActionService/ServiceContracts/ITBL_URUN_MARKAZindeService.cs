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
        ///TBL_URUN_MARKA  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_URUN_MARKA(TBL_URUN_MARKADTO item);
        
        /// <summary>
        ///TBL_URUN_MARKA  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_URUN_MARKA(TBL_URUN_MARKADTO item);
        
        /// <summary>
        ///TBL_URUN_MARKA  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_URUN_MARKA(TBL_URUN_MARKADTO item);
		 /// <summary>
        ///TBL_URUN_MARKA  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_URUN_MARKADTO>  Listele__TBL_URUN_MARKA();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_URUN_MARKADTO  Bul_TBL_URUN_MARKA(int ID);
	}
}
