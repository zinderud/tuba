//===================================================================================
// Sio
// Sio
//===================================================================================

#region
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoBusinessObjects;
using DataObjects.EntityFramework;
#endregion

namespace DataObjects
{
	public partial interface ITBL_ODEME   
    {
		/// <summary>
        ///TBL_ODEME  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_ODEME(TBL_ODEMEDTO item);
        
        /// <summary>
        ///TBL_ODEME  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_ODEME(TBL_ODEMEDTO item);
        
        /// <summary>
        ///TBL_ODEME  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_ODEME(TBL_ODEMEDTO item);
		 /// <summary>
        ///TBL_ODEME  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_ODEMEDTO>  Listele__TBL_ODEME();
         /// <summary>
        ///TBL_ODEME  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_ODEMEDTO  Bul_TBL_ODEME(int ID);
        
        
         
	}
}
