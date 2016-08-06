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
        /// TBL_GIDER Locator
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public    TBL_GIDERViewModel   TBL_GIDERViewModel 
        {
		 
           get
            {
                IProvider serviceAgent = new Provider.Provider();
                return new TBL_GIDERViewModel(serviceAgent);
            }
        }

	  
      
     }    
}
