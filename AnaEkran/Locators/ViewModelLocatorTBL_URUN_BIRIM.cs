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
        /// TBL_URUN_BIRIM Locator
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public    TBL_URUN_BIRIMViewModel   TBL_URUN_BIRIMViewModel 
        {
		 
           get
            {
                IProvider serviceAgent = new Provider.Provider();
                return new TBL_URUN_BIRIMViewModel(serviceAgent);
            }
        }

	  
      
     }    
}
