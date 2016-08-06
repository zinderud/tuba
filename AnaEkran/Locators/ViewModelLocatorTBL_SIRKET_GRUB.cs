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
        /// TBL_SIRKET_GRUB Locator
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public    TBL_SIRKET_GRUBViewModel   TBL_SIRKET_GRUBViewModel 
        {
		 
           get
            {
                IProvider serviceAgent = new Provider.Provider();
                return new TBL_SIRKET_GRUBViewModel(serviceAgent);
            }
        }

	  
      
     }    
}
