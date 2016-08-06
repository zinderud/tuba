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
        /// TBL_FIS Locator
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public    TBL_FISViewModel   TBL_FISViewModel 
        {
		 
           get
            {
                IProvider serviceAgent = new Provider.Provider();
                return new TBL_FISViewModel(serviceAgent);
            }
        }

	  
      
     }    
}
