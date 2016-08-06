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
	public partial class TBL_URUN_BIRIMViewModel  : ViewModelDetailBase< TBL_URUN_BIRIMViewModel,TBL_URUN_BIRIM_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_URUN_BIRIMViewModel () { }
TBL_URUN_BIRIM_MODEL model=new TBL_URUN_BIRIM_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_URUN_BIRIMViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_URUN_BIRIM  tablosu modeli
        /// </summary>
     
        private TBL_URUN_BIRIM_MODEL _Propurun_bırım;

        public TBL_URUN_BIRIM_MODEL Propurun_bırım
        {
            get { return _Propurun_bırım; }
            set { _Propurun_bırım = value;
                NotifyPropertyChanged(m=>m.Propurun_bırım);
                } 
        }
		 /// <summary>
        ///TBL_URUN_BIRIM  tablosu Secilen
        /// </summary>
     
        private TBL_URUN_BIRIM_MODEL _Propurun_bırımSecilen;

        public TBL_URUN_BIRIM_MODEL Propurun_bırımSecilen
        {
            get { return _Propurun_bırımSecilen; }
            set { _Propurun_bırımSecilen = value;
                NotifyPropertyChanged(m=>m.Propurun_bırımSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_URUN_BIRIM  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_URUN_BIRIM_MODEL> _Propurun_bırımListe;

        public ObservableCollection<TBL_URUN_BIRIM_MODEL> Propurun_bırımListe
        {
            get { return _Propurun_bırımListe; }
            set { _Propurun_bırımListe = value; 
                NotifyPropertyChanged(m=>m.Propurun_bırımListe);
                }
        }
         /// <summary>
        ///TBL_URUN_BIRIM  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_URUN_BIRIM_MODEL> _Propurun_bırımListeSecilen;

        public ObservableCollection<TBL_URUN_BIRIM_MODEL> Propurun_bırımListeSecilen
        {
            get { return _Propurun_bırımListeSecilen; }
            set { _Propurun_bırımListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propurun_bırımListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_URUN_BIRIM_MODEL model1 = new TBL_URUN_BIRIM_MODEL();
              //  model1 = Propurun_bırımSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_URUN_BIRIM_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_URUN_BIRIMMesaj>(new EkleTBL_URUN_BIRIMMesaj() { MesajTBL_URUN_BIRIM= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_URUN_BIRIMMesaj>(new EkleTBL_URUN_BIRIMMesaj() { MesajTBL_URUN_BIRIM= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_URUN_BIRIMMesaj>(new HataTBL_URUN_BIRIMMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_URUN_BIRIM_MODEL model1 = new TBL_URUN_BIRIM_MODEL();
                model1 = Propurun_bırımSecilen;
                if (await serviceAgent.Sil__TBL_URUN_BIRIM_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_URUN_BIRIMMesaj>(new SilTBL_URUN_BIRIMMesaj() { MesajTBL_URUN_BIRIM= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_URUN_BIRIMMesaj>(new SilTBL_URUN_BIRIMMesaj() { MesajTBL_URUN_BIRIM= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_URUN_BIRIMMesaj>(new HataTBL_URUN_BIRIMMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_URUN_BIRIM_MODEL model1 = new TBL_URUN_BIRIM_MODEL();
                model1 = Propurun_bırımSecilen;
            if (await serviceAgent.Degistir__TBL_URUN_BIRIM_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_URUN_BIRIMMesaj>(new DegistirTBL_URUN_BIRIMMesaj() { MesajTBL_URUN_BIRIM= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_URUN_BIRIMMesaj>(new DegistirTBL_URUN_BIRIMMesaj() { MesajTBL_URUN_BIRIM= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_URUN_BIRIMMesaj>(new HataTBL_URUN_BIRIMMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propurun_bırımListe = await serviceAgent.Listele__TBL_URUN_BIRIM_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_URUN_BIRIMMesaj>(new HataTBL_URUN_BIRIMMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propurun_bırım = await serviceAgent.Bul_TBL_URUN_BIRIM_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_URUN_BIRIMMesaj>(new HataTBL_URUN_BIRIMMesaj() { Hatamesaji = ex.ToString()});


             }
        }
        
        #endregion
		#region komut
	 public ICommand EkleCommand
        {
            get
            {
                return new DelegateCommand(Ekle);
            }
        }
		 public ICommand SiCommand
        {
            get
            {
                return new DelegateCommand(Sil);
            }
        }
		 public ICommand DegistirCommand
        {
            get
            {
                return new DelegateCommand(Degistir);
            }
        }
		 public ICommand ListeleCommand
        {
            get
            {
                return new DelegateCommand(Listele);
            }
        }
		 public ICommand BulCommand
        {
            get
            {
                return new DelegateCommand<int>(Bul);
            }
        }
	   #endregion

        
         
	}
}
