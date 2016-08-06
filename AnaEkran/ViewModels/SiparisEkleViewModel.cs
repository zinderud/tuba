using AnaEkran.Models;
using AnaEkran.Provider;
using SimpleMvvmToolkit;

namespace AnaEkran.ViewModels
{
    public class SiparisEkleViewModel : ViewModelDetailBase<SiparisEkleViewModel, TBL_SPARIS_MODEL> 
    { 
        #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public SiparisEkleViewModel () { }
TBL_SPARIS_MODEL model=new TBL_SPARIS_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public SiparisEkleViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
       
        }
		 #endregion
         
    }
}