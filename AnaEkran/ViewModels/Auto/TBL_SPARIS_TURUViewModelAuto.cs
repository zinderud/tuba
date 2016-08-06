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
	public partial class TBL_SPARIS_TURUViewModel  : ViewModelDetailBase< TBL_SPARIS_TURUViewModel,TBL_SPARIS_TURU_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_SPARIS_TURUViewModel () { }
TBL_SPARIS_TURU_MODEL model=new TBL_SPARIS_TURU_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_SPARIS_TURUViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_SPARIS_TURU  tablosu modeli
        /// </summary>
     
        private TBL_SPARIS_TURU_MODEL _Propsparıs_turu;

        public TBL_SPARIS_TURU_MODEL Propsparıs_turu
        {
            get { return _Propsparıs_turu; }
            set { _Propsparıs_turu = value;
                NotifyPropertyChanged(m=>m.Propsparıs_turu);
                } 
        }
		 /// <summary>
        ///TBL_SPARIS_TURU  tablosu Secilen
        /// </summary>
     
        private TBL_SPARIS_TURU_MODEL _Propsparıs_turuSecilen;

        public TBL_SPARIS_TURU_MODEL Propsparıs_turuSecilen
        {
            get { return _Propsparıs_turuSecilen; }
            set { _Propsparıs_turuSecilen = value;
                NotifyPropertyChanged(m=>m.Propsparıs_turuSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_SPARIS_TURU  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_SPARIS_TURU_MODEL> _Propsparıs_turuListe;

        public ObservableCollection<TBL_SPARIS_TURU_MODEL> Propsparıs_turuListe
        {
            get { return _Propsparıs_turuListe; }
            set { _Propsparıs_turuListe = value; 
                NotifyPropertyChanged(m=>m.Propsparıs_turuListe);
                }
        }
         /// <summary>
        ///TBL_SPARIS_TURU  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_SPARIS_TURU_MODEL> _Propsparıs_turuListeSecilen;

        public ObservableCollection<TBL_SPARIS_TURU_MODEL> Propsparıs_turuListeSecilen
        {
            get { return _Propsparıs_turuListeSecilen; }
            set { _Propsparıs_turuListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propsparıs_turuListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_SPARIS_TURU_MODEL model1 = new TBL_SPARIS_TURU_MODEL();
              //  model1 = Propsparıs_turuSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_SPARIS_TURU_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_SPARIS_TURUMesaj>(new EkleTBL_SPARIS_TURUMesaj() { MesajTBL_SPARIS_TURU= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_SPARIS_TURUMesaj>(new EkleTBL_SPARIS_TURUMesaj() { MesajTBL_SPARIS_TURU= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_SPARIS_TURUMesaj>(new HataTBL_SPARIS_TURUMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_SPARIS_TURU_MODEL model1 = new TBL_SPARIS_TURU_MODEL();
                model1 = Propsparıs_turuSecilen;
                if (await serviceAgent.Sil__TBL_SPARIS_TURU_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_SPARIS_TURUMesaj>(new SilTBL_SPARIS_TURUMesaj() { MesajTBL_SPARIS_TURU= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_SPARIS_TURUMesaj>(new SilTBL_SPARIS_TURUMesaj() { MesajTBL_SPARIS_TURU= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_SPARIS_TURUMesaj>(new HataTBL_SPARIS_TURUMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_SPARIS_TURU_MODEL model1 = new TBL_SPARIS_TURU_MODEL();
                model1 = Propsparıs_turuSecilen;
            if (await serviceAgent.Degistir__TBL_SPARIS_TURU_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_SPARIS_TURUMesaj>(new DegistirTBL_SPARIS_TURUMesaj() { MesajTBL_SPARIS_TURU= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_SPARIS_TURUMesaj>(new DegistirTBL_SPARIS_TURUMesaj() { MesajTBL_SPARIS_TURU= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_SPARIS_TURUMesaj>(new HataTBL_SPARIS_TURUMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propsparıs_turuListe = await serviceAgent.Listele__TBL_SPARIS_TURU_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_SPARIS_TURUMesaj>(new HataTBL_SPARIS_TURUMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propsparıs_turu = await serviceAgent.Bul_TBL_SPARIS_TURU_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_SPARIS_TURUMesaj>(new HataTBL_SPARIS_TURUMesaj() { Hatamesaji = ex.ToString()});


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
