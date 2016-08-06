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
	public partial class TBL_FATURA_TURUViewModel  : ViewModelDetailBase< TBL_FATURA_TURUViewModel,TBL_FATURA_TURU_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_FATURA_TURUViewModel () { }
TBL_FATURA_TURU_MODEL model=new TBL_FATURA_TURU_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_FATURA_TURUViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_FATURA_TURU  tablosu modeli
        /// </summary>
     
        private TBL_FATURA_TURU_MODEL _Propfatura_turu;

        public TBL_FATURA_TURU_MODEL Propfatura_turu
        {
            get { return _Propfatura_turu; }
            set { _Propfatura_turu = value;
                NotifyPropertyChanged(m=>m.Propfatura_turu);
                } 
        }
		 /// <summary>
        ///TBL_FATURA_TURU  tablosu Secilen
        /// </summary>
     
        private TBL_FATURA_TURU_MODEL _Propfatura_turuSecilen;

        public TBL_FATURA_TURU_MODEL Propfatura_turuSecilen
        {
            get { return _Propfatura_turuSecilen; }
            set { _Propfatura_turuSecilen = value;
                NotifyPropertyChanged(m=>m.Propfatura_turuSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_FATURA_TURU  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_FATURA_TURU_MODEL> _Propfatura_turuListe;

        public ObservableCollection<TBL_FATURA_TURU_MODEL> Propfatura_turuListe
        {
            get { return _Propfatura_turuListe; }
            set { _Propfatura_turuListe = value; 
                NotifyPropertyChanged(m=>m.Propfatura_turuListe);
                }
        }
         /// <summary>
        ///TBL_FATURA_TURU  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_FATURA_TURU_MODEL> _Propfatura_turuListeSecilen;

        public ObservableCollection<TBL_FATURA_TURU_MODEL> Propfatura_turuListeSecilen
        {
            get { return _Propfatura_turuListeSecilen; }
            set { _Propfatura_turuListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propfatura_turuListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_FATURA_TURU_MODEL model1 = new TBL_FATURA_TURU_MODEL();
              //  model1 = Propfatura_turuSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_FATURA_TURU_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_FATURA_TURUMesaj>(new EkleTBL_FATURA_TURUMesaj() { MesajTBL_FATURA_TURU= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_FATURA_TURUMesaj>(new EkleTBL_FATURA_TURUMesaj() { MesajTBL_FATURA_TURU= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_FATURA_TURUMesaj>(new HataTBL_FATURA_TURUMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_FATURA_TURU_MODEL model1 = new TBL_FATURA_TURU_MODEL();
                model1 = Propfatura_turuSecilen;
                if (await serviceAgent.Sil__TBL_FATURA_TURU_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_FATURA_TURUMesaj>(new SilTBL_FATURA_TURUMesaj() { MesajTBL_FATURA_TURU= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_FATURA_TURUMesaj>(new SilTBL_FATURA_TURUMesaj() { MesajTBL_FATURA_TURU= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_FATURA_TURUMesaj>(new HataTBL_FATURA_TURUMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_FATURA_TURU_MODEL model1 = new TBL_FATURA_TURU_MODEL();
                model1 = Propfatura_turuSecilen;
            if (await serviceAgent.Degistir__TBL_FATURA_TURU_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_FATURA_TURUMesaj>(new DegistirTBL_FATURA_TURUMesaj() { MesajTBL_FATURA_TURU= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_FATURA_TURUMesaj>(new DegistirTBL_FATURA_TURUMesaj() { MesajTBL_FATURA_TURU= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_FATURA_TURUMesaj>(new HataTBL_FATURA_TURUMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propfatura_turuListe = await serviceAgent.Listele__TBL_FATURA_TURU_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_FATURA_TURUMesaj>(new HataTBL_FATURA_TURUMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propfatura_turu = await serviceAgent.Bul_TBL_FATURA_TURU_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_FATURA_TURUMesaj>(new HataTBL_FATURA_TURUMesaj() { Hatamesaji = ex.ToString()});


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
