//===================================================================================
// Sio
// Sio
//===================================================================================

#region
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using AnaEkran.Provider;
using System.Collections.ObjectModel;
using SimpleMvvmToolkit;
using AnaEkran.Models;
using ZindeMesajServisi.Messaging;
using AnaEkran.Mesaj;


#endregion

namespace AnaEkran.ViewModels
{
	public partial class TBL_FISViewModel  : ViewModelDetailBase<TBL_FISViewModel, TBL_FIS_MODEL> 
    {
	  
		
	 public void Baslangic()
     {
     }
     private string _fisid;
     public string propFisid
     {
         get { return _fisid; }
         set
         {
             _fisid = value;
             NotifyPropertyChanged(m => m.propFisid);
         }
     }
     #region TBL_FIS
     private ObservableCollection<TBL_FIS_MODEL> _TBL_FISlistesiCollection;
     public ObservableCollection<TBL_FIS_MODEL> PropTBL_FISlistesiCollection
     {
         get { return _TBL_FISlistesiCollection; }
         set
         {
             _TBL_FISlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_FISlistesiCollection);
         }
     }
     private TBL_FIS_MODEL _TBL_FIS_MODELModel;
     public TBL_FIS_MODEL SecilenTBL_FIS_MODEL
     {
         get { return _TBL_FIS_MODELModel; }
         set
         {
             _TBL_FIS_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_FIS_MODEL);
             this.Model.TBL_FIS_ID = SecilenTBL_FIS_MODEL.TBL_FIS_ID;
         }
     }

     public async void TBL_FISListesi()
     {
         PropTBL_FISlistesiCollection = await serviceAgent.Listele__TBL_FIS_MODEL();
         var sayi = PropTBL_FISlistesiCollection.Count + 1;
         propFisid = sayi.ToString();
     }

       
     #endregion
         
	}
}
