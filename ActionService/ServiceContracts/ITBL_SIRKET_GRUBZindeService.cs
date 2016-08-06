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
        ///TBL_SIRKET_GRUB  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Ekle__TBL_SIRKET_GRUB(TBL_SIRKET_GRUBDTO item);
        
        /// <summary>
        ///TBL_SIRKET_GRUB  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Sil__TBL_SIRKET_GRUB(TBL_SIRKET_GRUBDTO item);
        
        /// <summary>
        ///TBL_SIRKET_GRUB  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
        bool  Degistir__TBL_SIRKET_GRUB(TBL_SIRKET_GRUBDTO item);
		 /// <summary>
        ///TBL_SIRKET_GRUB  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		   [OperationContract]
         List<TBL_SIRKET_GRUBDTO>  Listele__TBL_SIRKET_GRUB();
          /// <summary>
        ///TBL_URUN  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 [OperationContract]
         TBL_SIRKET_GRUBDTO  Bul_TBL_SIRKET_GRUB(int ID);
	}
}
