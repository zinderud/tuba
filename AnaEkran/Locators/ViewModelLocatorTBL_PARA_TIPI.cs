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
        /// TBL_PARA_TIPI Locator
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public    TBL_PARA_TIPIViewModel   TBL_PARA_TIPIViewModel 
        {
		 
           get
            {
                IProvider serviceAgent = new Provider.Provider();
                return new TBL_PARA_TIPIViewModel(serviceAgent);
            }
        }

	  
      
     }    
}
