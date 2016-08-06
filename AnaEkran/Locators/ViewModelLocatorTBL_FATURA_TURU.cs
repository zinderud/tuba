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
        /// TBL_FATURA_TURU Locator
        /// </summary>
        /// <param name="item">Item</param>
	 
		 public    TBL_FATURA_TURUViewModel   TBL_FATURA_TURUViewModel 
        {
		 
           get
            {
                IProvider serviceAgent = new Provider.Provider();
                return new TBL_FATURA_TURUViewModel(serviceAgent);
            }
        }

	  
      
     }    
}
