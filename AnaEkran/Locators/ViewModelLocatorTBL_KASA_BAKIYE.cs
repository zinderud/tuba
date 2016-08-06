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
        /// TBL_KASA_BAKIYE Locator
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public    TBL_KASA_BAKIYEViewModel   TBL_KASA_BAKIYEViewModel 
        {
		 
           get
            {
                IProvider serviceAgent = new Provider.Provider();
                return new TBL_KASA_BAKIYEViewModel(serviceAgent);
            }
        }

	  
      
     }    
}
