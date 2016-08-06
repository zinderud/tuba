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
using AnaEkran.Static;
using SimpleMvvmToolkit;
using AnaEkran.Models;
using ZindeMesajServisi.Messaging;
using AnaEkran.Mesaj;


#endregion

namespace AnaEkran.ViewModels
{
	public partial class TBL_FATURAViewModel  : ViewModelDetailBase<TBL_FATURAViewModel, TBL_FATURA_MODEL> 
    {
	  
		
	 public void Baslangic()
	 {
	     TBL_SIRKETListesi();
	     TBL_FATURA_TURUListesi();
	     TBL_PARA_TIPIListesi();
	     TBL_ODEME_TIPIListesi();
	     TBL_KASAListesi();
	     TBL_URUNListesi();
	     TBL_DEPOListesi();
	     TBL_PERSONELListesi();
	     TBL_SPARISListesi();
	     UrunSparisListele();
	 }

     #region TBL_SIRKET
     private ObservableCollection<TBL_SIRKET_MODEL> _TBL_SIRKETlistesiCollection;
     public ObservableCollection<TBL_SIRKET_MODEL> PropTBL_SIRKETlistesiCollection
     {
         get { return _TBL_SIRKETlistesiCollection; }
         set
         {
             _TBL_SIRKETlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_SIRKETlistesiCollection);
         }
     }
     private TBL_SIRKET_MODEL _TBL_SIRKET_MODELModel;
     public TBL_SIRKET_MODEL SecilenTBL_SIRKET_MODEL
     {
         get { return _TBL_SIRKET_MODELModel; }
         set
         {
             _TBL_SIRKET_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_SIRKET_MODEL);
             try
             {
                 this.Model.TBL_SIRKET_ID = SecilenTBL_SIRKET_MODEL.TBL_SIRKET_ID;

             }
             catch (Exception)
             {
                 
             
             }
         }
     }
     public async void TBL_SIRKETListesi()
     {
         PropTBL_SIRKETlistesiCollection = await serviceAgent.Listele__TBL_SIRKET_MODEL();
     }
     #endregion
     #region TBL_FATURA_TURU
     private ObservableCollection<TBL_FATURA_TURU_MODEL> _TBL_FATURA_TURUlistesiCollection;
     public ObservableCollection<TBL_FATURA_TURU_MODEL> PropTBL_FATURA_TURUlistesiCollection
     {
         get { return _TBL_FATURA_TURUlistesiCollection; }
         set
         {
             _TBL_FATURA_TURUlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_FATURA_TURUlistesiCollection);
         }
     }
     private TBL_FATURA_TURU_MODEL _TBL_FATURA_TURU_MODELModel;
     public TBL_FATURA_TURU_MODEL SecilenTBL_FATURA_TURU_MODEL
     {
         get { return _TBL_FATURA_TURU_MODELModel; }
         set
         {
             _TBL_FATURA_TURU_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_FATURA_TURU_MODEL);
             try
             {
                 this.Model.TBL_FATURA_TURU_ID = SecilenTBL_FATURA_TURU_MODEL.TBL_FATURA_TURU_ID;

             }
             catch (Exception)
             {
                 
                
             }
         }
     }
     public async void TBL_FATURA_TURUListesi()
     {
         PropTBL_FATURA_TURUlistesiCollection = await serviceAgent.Listele__TBL_FATURA_TURU_MODEL();
     }
     #endregion
     #region TBL_PARA_TIPI
     private ObservableCollection<TBL_PARA_TIPI_MODEL> _TBL_PARA_TIPIlistesiCollection;
     public ObservableCollection<TBL_PARA_TIPI_MODEL> PropTBL_PARA_TIPIlistesiCollection
     {
         get { return _TBL_PARA_TIPIlistesiCollection; }
         set
         {
             _TBL_PARA_TIPIlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_PARA_TIPIlistesiCollection);
         }
     }
     private TBL_PARA_TIPI_MODEL _TBL_PARA_TIPI_MODELModel;
     public TBL_PARA_TIPI_MODEL SecilenTBL_PARA_TIPI_MODEL
     {
         get { return _TBL_PARA_TIPI_MODELModel; }
         set
         {
             _TBL_PARA_TIPI_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_PARA_TIPI_MODEL);
             try
             {
                 this.Model.TBL_PARA_TIPI_ID = SecilenTBL_PARA_TIPI_MODEL.TBL_PARA_TIPI_ID;

             }
             catch (Exception)
             {
                 
               
             }
         }
     }
     public async void TBL_PARA_TIPIListesi()
     {
         PropTBL_PARA_TIPIlistesiCollection = await serviceAgent.Listele__TBL_PARA_TIPI_MODEL();
     }
     #endregion
     #region TBL_ODEME_TIPI
     private ObservableCollection<TBL_ODEME_TIPI_MODEL> _TBL_ODEME_TIPIlistesiCollection;
     public ObservableCollection<TBL_ODEME_TIPI_MODEL> PropTBL_ODEME_TIPIlistesiCollection
     {
         get { return _TBL_ODEME_TIPIlistesiCollection; }
         set
         {
             _TBL_ODEME_TIPIlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_ODEME_TIPIlistesiCollection);
         }
     }
     private TBL_ODEME_TIPI_MODEL _TBL_ODEME_TIPI_MODELModel;
     public TBL_ODEME_TIPI_MODEL SecilenTBL_ODEME_TIPI_MODEL
     {
         get { return _TBL_ODEME_TIPI_MODELModel; }
         set
         {
             _TBL_ODEME_TIPI_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_ODEME_TIPI_MODEL);
             try
             {
                 this.Model.TBL_ODEME_TIPI_ID = SecilenTBL_ODEME_TIPI_MODEL.TBL_ODEME_TIPI_ID;

             }
             catch (Exception)
             {
                 
        
             }
         }
     }
     public async void TBL_ODEME_TIPIListesi()
     {
         PropTBL_ODEME_TIPIlistesiCollection = await serviceAgent.Listele__TBL_ODEME_TIPI_MODEL();
     }
     #endregion
     #region TBL_KASA
     private ObservableCollection<TBL_KASA_MODEL> _TBL_KASAlistesiCollection;
     public ObservableCollection<TBL_KASA_MODEL> PropTBL_KASAlistesiCollection
     {
         get { return _TBL_KASAlistesiCollection; }
         set
         {
             _TBL_KASAlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_KASAlistesiCollection);
         }
     }
     private TBL_KASA_MODEL _TBL_KASA_MODELModel;
     public TBL_KASA_MODEL SecilenTBL_KASA_MODEL
     {
         get { return _TBL_KASA_MODELModel; }
         set
         {
             _TBL_KASA_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_KASA_MODEL);
             try
             {
                 this.Model.TBL_KASA_ID = SecilenTBL_KASA_MODEL.TBL_KASA_ID;
             }
             catch (Exception)
             {
                 
                 throw;
             }
           
         }
     }
     public async void TBL_KASAListesi()
     {
         PropTBL_KASAlistesiCollection = await serviceAgent.Listele__TBL_KASA_MODEL();
     }
     #endregion
     #region TBL_URUN
     private ObservableCollection<TBL_URUN_MODEL> _TBL_URUNlistesiCollection;
     public ObservableCollection<TBL_URUN_MODEL> PropTBL_URUNlistesiCollection
     {
         get { return _TBL_URUNlistesiCollection; }
         set
         {
             _TBL_URUNlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_URUNlistesiCollection);
         }
     }
     private TBL_URUN_MODEL _TBL_URUN_MODELModel;
     public TBL_URUN_MODEL SecilenTBL_URUN_MODEL
     {
         get { return _TBL_URUN_MODELModel; }
         set
         {
             _TBL_URUN_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_URUN_MODEL);
             //TODO DÜZENLE
             //this.Model.TBL_URUN_ID = SecilenTBL_URUN_MODEL.TBL_URUN_ID;
         }
     }
     public async void TBL_URUNListesi()
     {
         PropTBL_URUNlistesiCollection = await serviceAgent.Listele__TBL_URUN_MODEL();
     }
     #endregion
     #region TBL_DEPO
     private ObservableCollection<TBL_DEPO_MODEL> _TBL_DEPOlistesiCollection;
     public ObservableCollection<TBL_DEPO_MODEL> PropTBL_DEPOlistesiCollection
     {
         get { return _TBL_DEPOlistesiCollection; }
         set
         {
             _TBL_DEPOlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_DEPOlistesiCollection);
         }
     }
     private TBL_DEPO_MODEL _TBL_DEPO_MODELModel;
     public TBL_DEPO_MODEL SecilenTBL_DEPO_MODEL
     {
         get { return _TBL_DEPO_MODELModel; }
         set
         {
             _TBL_DEPO_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_DEPO_MODEL);
             try
             {
                 this.Model.TBL_DEPO_ID = SecilenTBL_DEPO_MODEL.TBL_DEPO_ID;
             }
             catch (Exception)
             {
                 
            
             }
        
         }
     }
     public async void TBL_DEPOListesi()
     {
         PropTBL_DEPOlistesiCollection = await serviceAgent.Listele__TBL_DEPO_MODEL();
     }
     #endregion
     #region TBL_PERSONEL
     private ObservableCollection<TBL_PERSONEL_MODEL> _TBL_PERSONELlistesiCollection;
     public ObservableCollection<TBL_PERSONEL_MODEL> PropTBL_PERSONELlistesiCollection
     {
         get { return _TBL_PERSONELlistesiCollection; }
         set
         {
             _TBL_PERSONELlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_PERSONELlistesiCollection);
         }
     }
     private TBL_PERSONEL_MODEL _TBL_PERSONEL_MODELModel;
     public TBL_PERSONEL_MODEL SecilenTBL_PERSONEL_MODEL
     {
         get { return _TBL_PERSONEL_MODELModel; }
         set
         {
             _TBL_PERSONEL_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_PERSONEL_MODEL);
             try
             {
                 this.Model.TBL_PERSONEL_ID = SecilenTBL_PERSONEL_MODEL.TBL_PERSONEL_ID;
             }
             catch (Exception)
             {
                 
              
             }
            
         }
     }
     public async void TBL_PERSONELListesi()
     {
         PropTBL_PERSONELlistesiCollection = await serviceAgent.Listele__TBL_PERSONEL_MODEL();
     }
     #endregion

     #region TBL_SPARIS
     private ObservableCollection<TBL_SPARIS_MODEL> _TBL_SPARISlistesiCollection;
     public ObservableCollection<TBL_SPARIS_MODEL> PropTBL_SPARISlistesiCollection
     {
         get { return _TBL_SPARISlistesiCollection; }
         set
         {
             _TBL_SPARISlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_SPARISlistesiCollection);
         }
     }
     private TBL_SPARIS_MODEL _TBL_SPARIS_MODELModel;
     public TBL_SPARIS_MODEL SecilenTBL_SPARIS_MODEL
     {
         get { return _TBL_SPARIS_MODELModel; }
         set
         {
             _TBL_SPARIS_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_SPARIS_MODEL);
             //todo bak

             try
             {
                 SecilenUrunSparisListesi(SecilenTBL_SPARIS_MODEL.TBL_SPARIS_ID);
                 SecilenParatipiniGoster(SecilenTBL_SPARIS_MODEL.TBL_PARA_TIPI_ID);
                 SecilenSirketiGoster(SecilenTBL_SPARIS_MODEL.TBL_SIRKET_ID);
                 SecilenOdemetipiniGoster(SecilenTBL_SPARIS_MODEL.TBL_ODEME_TIPI_ID);
                 SecilenDepoGoster(SecilenTBL_SPARIS_MODEL.TBL_DEPO_ID);
                 SecilenpersonelGoster(SecilenTBL_SPARIS_MODEL.TBL_PERSONEL_ID);
                 SecilenkasaGoster(SecilenTBL_SPARIS_MODEL.TBL_KASA_ID);
                 // TBL_SIRKET_MODEL model = new TBL_SIRKET_MODEL();
                 //this.SecilenTBL_SIRKET_MODEL = model;
                 ////model.TBL_SIRKET_ID = SecilenTBL_SPARIS_MODEL.TBL_SPARIS_ID;
                 // this.SecilenTBL_SIRKET_MODEL.TBL_SIRKET_ID = model.TBL_SIRKET_ID;


                 this.Model.TBL_SPARIS_ID = SecilenTBL_SPARIS_MODEL.TBL_SPARIS_ID;

                 //this.Model.TBL_SIRKET_ID = SecilenTBL_SPARIS_MODEL.TBL_SIRKET_ID;
                 //this.Model.TBL_PARA_TIPI_ID = SecilenTBL_SPARIS_MODEL.TBL_PARA_TIPI_ID;
                 //this.Model.TBL_ODEME_TIPI_ID = SecilenTBL_SPARIS_MODEL.TBL_ODEME_TIPI_ID;
                 //this.model.TBL_DEPO_ID = SecilenTBL_SPARIS_MODEL.TBL_DEPO_ID;
                 //this.model.TBL_PERSONEL_ID = SecilenTBL_SPARIS_MODEL.TBL_PERSONEL_ID;
                 this.model.FATURA_TARIH = SecilenTBL_SPARIS_MODEL.SPARIS_TARIH;
             }
             catch (Exception)
             {
                 
                  
             }
            
 
         }
     }
     public async void TBL_SPARISListesi()
     {
         PropTBL_SPARISlistesiCollection = await serviceAgent.Listele__TBL_SPARIS_MODEL();
     }

	    public void SecilenSirketiGoster(int? sirketid)
	    {
            SecilenTBL_SIRKET_MODEL =
	            (from k in PropTBL_SIRKETlistesiCollection where k.TBL_SIRKET_ID == sirketid select k).FirstOrDefault();
	    }

        public void SecilenParatipiniGoster(int? paratipiid)
	    {
            SecilenTBL_PARA_TIPI_MODEL = (from k in PropTBL_PARA_TIPIlistesiCollection where k.TBL_PARA_TIPI_ID == paratipiid select k).FirstOrDefault();
	    }
        public void SecilenOdemetipiniGoster(int? odemetipiid)
        {
            SecilenTBL_ODEME_TIPI_MODEL = (from k in PropTBL_ODEME_TIPIlistesiCollection where k.TBL_ODEME_TIPI_ID == odemetipiid select k).FirstOrDefault();
        }
        public void SecilenDepoGoster(int? depoiid)
        {
            SecilenTBL_DEPO_MODEL = (from k in PropTBL_DEPOlistesiCollection where k.TBL_DEPO_ID == depoiid select k).FirstOrDefault();
        }
        public void SecilenpersonelGoster(int? persid)
        {
            SecilenTBL_PERSONEL_MODEL = (from k in PropTBL_PERSONELlistesiCollection where k.TBL_PERSONEL_ID == persid select k).FirstOrDefault();
        }
        public void SecilenkasaGoster(int? kasid)
        {
            SecilenTBL_KASA_MODEL = (from k in PropTBL_KASAlistesiCollection where k.TBL_KASA_ID == kasid select k).FirstOrDefault();
        }

       
     #endregion

     #region SpariþUrunListele

     /// <summary>
     ///TBL_URUN_SPARIS  tablosu Listesi modeli
     /// </summary>

     private ObservableCollection<TBL_URUN_SPARIS_MODEL> _Propurun_sparýsListe;

     public ObservableCollection<TBL_URUN_SPARIS_MODEL> Propurun_sparýsListe
     {
         get { return _Propurun_sparýsListe; }
         set
         {
             _Propurun_sparýsListe = value;
             NotifyPropertyChanged(m => m.Propurun_sparýsListe);
         }
     }
     private TBL_URUN_SPARIS_MODEL _Propurun_sparýsSecilen;

     public TBL_URUN_SPARIS_MODEL Propurun_sparýsSecilen
     {
         get { return _Propurun_sparýsSecilen; }
         set
         {
             _Propurun_sparýsSecilen = value;
             NotifyPropertyChanged(m => m.Propurun_sparýsSecilen);
         }
     }
     public async void UrunSparisListele()
     {
         try
         {
             Propurun_sparýsListe = await serviceAgent.Listele__TBL_URUN_SPARIS_MODEL();
         }
         catch (Exception ex)
         {
             Messenger.Default.Send<HataTBL_URUN_SPARISMesaj>(new HataTBL_URUN_SPARISMesaj() { Hatamesaji = ex.ToString() });


         }

     }
     /// <summary>
     ///TBL_URUN_SPARIS  tablosu Listesi secilen modeli
     /// </summary>

     private ObservableCollection<TBL_URUN_SPARIS_MODEL> _Propurun_sparýsListeSecilen;

     public ObservableCollection<TBL_URUN_SPARIS_MODEL> Propurun_sparýsListeSecilen
     {
         get { return _Propurun_sparýsListeSecilen; }
         set
         {
             _Propurun_sparýsListeSecilen = value;
             NotifyPropertyChanged(m => m.Propurun_sparýsListeSecilen);
         }
     }


     public void SecilenUrunSparisListesi(int siparisid)
     {
         Propurun_sparýsListeSecilen =
             (from k in Propurun_sparýsListe where k.TBL_SIPARIS_ID == siparisid select k).ToObservableCollection();

     }
     #endregion
	}
}
