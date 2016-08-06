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
	public partial class TBL_URUN_MARKAViewModel  : ViewModelDetailBase<TBL_URUN_MARKAViewModel, TBL_URUN_MARKA_MODEL> 
    {
	  
		
	 public void Baslangic()
	 {
	     TBL_URUN_TIPIListesi();
	     TBL_URUN_CINSIListesi();
	 }

     #region TBL_URUN_TIPI
     private ObservableCollection<TBL_URUN_TIPI_MODEL> _TBL_URUN_TIPIlistesiCollection;
     public ObservableCollection<TBL_URUN_TIPI_MODEL> PropTBL_URUN_TIPIlistesiCollection
     {
         get { return _TBL_URUN_TIPIlistesiCollection; }
         set
         {
             _TBL_URUN_TIPIlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_URUN_TIPIlistesiCollection);
         }
     }
     private TBL_URUN_TIPI_MODEL _TBL_URUN_TIPI_MODELModel;
     public TBL_URUN_TIPI_MODEL SecilenTBL_URUN_TIPI_MODEL
     {
         get { return _TBL_URUN_TIPI_MODELModel; }
         set
         {
             _TBL_URUN_TIPI_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_URUN_TIPI_MODEL);
             this.Model.TBL_URUN_TIPI_ID = SecilenTBL_URUN_TIPI_MODEL.TBL_URUN_TIPI_ID;
         }
     }
     public async void TBL_URUN_TIPIListesi()
     {
         PropTBL_URUN_TIPIlistesiCollection = await serviceAgent.Listele__TBL_URUN_TIPI_MODEL();
     }
     #endregion
     #region TBL_URUN_CINSI
     private ObservableCollection<TBL_URUN_CINSI_MODEL> _TBL_URUN_CINSIlistesiCollection;
     public ObservableCollection<TBL_URUN_CINSI_MODEL> PropTBL_URUN_CINSIlistesiCollection
     {
         get { return _TBL_URUN_CINSIlistesiCollection; }
         set
         {
             _TBL_URUN_CINSIlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_URUN_CINSIlistesiCollection);
         }
     }
     private TBL_URUN_CINSI_MODEL _TBL_URUN_CINSI_MODELModel;
     public TBL_URUN_CINSI_MODEL SecilenTBL_URUN_CINSI_MODEL
     {
         get { return _TBL_URUN_CINSI_MODELModel; }
         set
         {
             _TBL_URUN_CINSI_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_URUN_CINSI_MODEL);
             this.Model.TBL_URUN_CINSI_ID = SecilenTBL_URUN_CINSI_MODEL.TBL_URUN_CINSI_ID;
         }
     }
     public async void TBL_URUN_CINSIListesi()
     {
         PropTBL_URUN_CINSIlistesiCollection = await serviceAgent.Listele__TBL_URUN_CINSI_MODEL();
     }
     #endregion
         
	}
}
