//===================================================================================
// Sio
// Sio
//===================================================================================

#region
using System;
 
using System.Linq;
 
using System.Collections.Generic;
using AnaEkran.Provider;
using AnaEkran.ViewModels;
#endregion

namespace  AnaEkran
{
 	public partial class ViewModelLocator  
   {

 

		/// <summary>
        /// TBL_ODEME_TURU Locator
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public    TBL_ODEME_TURUViewModel   TBL_ODEME_TURUViewModel 
        {
		 
           get
            {
                IProvider serviceAgent = new Provider.Provider();
                return new TBL_ODEME_TURUViewModel(serviceAgent);
            }
        }

	  
      
     }    
}
