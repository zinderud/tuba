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
        /// TBL_SPARIS_TURU Locator
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public    TBL_SPARIS_TURUViewModel   TBL_SPARIS_TURUViewModel 
        {
		 
           get
            {
                IProvider serviceAgent = new Provider.Provider();
                return new TBL_SPARIS_TURUViewModel(serviceAgent);
            }
        }

	  
      
     }    
}
