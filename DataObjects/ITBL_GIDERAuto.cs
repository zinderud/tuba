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
	public partial interface ITBL_GIDER   
    {
		/// <summary>
        ///TBL_GIDER  Ekle komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Ekle__TBL_GIDER(TBL_GIDERDTO item);
        
        /// <summary>
        ///TBL_GIDER  sil komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Sil__TBL_GIDER(TBL_GIDERDTO item);
        
        /// <summary>
        ///TBL_GIDER  degistir komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
        bool  Degistir__TBL_GIDER(TBL_GIDERDTO item);
		 /// <summary>
        ///TBL_GIDER  listele komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         List<TBL_GIDERDTO>  Listele__TBL_GIDER();
         /// <summary>
        ///TBL_GIDER  Bul komutu
        /// </summary>
        /// <param name="item">Item</param>
		 
         TBL_GIDERDTO  Bul_TBL_GIDER(int ID);
        
        
         
	}
}
