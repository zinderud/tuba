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
        /// TBL_SIRKET Locator
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public    TBL_SIRKETViewModel   TBL_SIRKETViewModel 
        {
		 
           get
            {
                IProvider serviceAgent = new Provider.Provider();
                return new TBL_SIRKETViewModel(serviceAgent);
            }
        }

	  
      
     }    
}
