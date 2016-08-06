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
        /// TBL_URUN_STOK Locator
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public    TBL_URUN_STOKViewModel   TBL_URUN_STOKViewModel 
        {
		 
           get
            {
                IProvider serviceAgent = new Provider.Provider();
                return new TBL_URUN_STOKViewModel(serviceAgent);
            }
        }

	  
      
     }    
}
