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
        ///TBL_URUN_CINSI  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_URUN_CINSI(TBL_URUN_CINSIDTO item);
        
        /// <summary>
        ///TBL_URUN_CINSI  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_URUN_CINSI(TBL_URUN_CINSIDTO item);
        
        /// <summary>
        ///TBL_URUN_CINSI  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_URUN_CINSI(TBL_URUN_CINSIDTO item);
		 /// <summary>
        ///TBL_URUN_CINSI  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_URUN_CINSIDTO>  Listele__TBL_URUN_CINSI();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_URUN_CINSIDTO  Bul_TBL_URUN_CINSI(int ID);
	}
}
