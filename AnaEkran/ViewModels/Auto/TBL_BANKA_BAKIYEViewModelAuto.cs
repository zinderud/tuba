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
	public partial class TBL_BANKA_BAKIYEViewModel  : ViewModelDetailBase< TBL_BANKA_BAKIYEViewModel,TBL_BANKA_BAKIYE_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_BANKA_BAKIYEViewModel () { }
TBL_BANKA_BAKIYE_MODEL model=new TBL_BANKA_BAKIYE_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_BANKA_BAKIYEViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_BANKA_BAKIYE  tablosu modeli
        /// </summary>
     
        private TBL_BANKA_BAKIYE_MODEL _Propbanka_bakıye;

        public TBL_BANKA_BAKIYE_MODEL Propbanka_bakıye
        {
            get { return _Propbanka_bakıye; }
            set { _Propbanka_bakıye = value;
                NotifyPropertyChanged(m=>m.Propbanka_bakıye);
                } 
        }
		 /// <summary>
        ///TBL_BANKA_BAKIYE  tablosu Secilen
        /// </summary>
     
        private TBL_BANKA_BAKIYE_MODEL _Propbanka_bakıyeSecilen;

        public TBL_BANKA_BAKIYE_MODEL Propbanka_bakıyeSecilen
        {
            get { return _Propbanka_bakıyeSecilen; }
            set { _Propbanka_bakıyeSecilen = value;
                NotifyPropertyChanged(m=>m.Propbanka_bakıyeSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_BANKA_BAKIYE  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_BANKA_BAKIYE_MODEL> _Propbanka_bakıyeListe;

        public ObservableCollection<TBL_BANKA_BAKIYE_MODEL> Propbanka_bakıyeListe
        {
            get { return _Propbanka_bakıyeListe; }
            set { _Propbanka_bakıyeListe = value; 
                NotifyPropertyChanged(m=>m.Propbanka_bakıyeListe);
                }
        }
         /// <summary>
        ///TBL_BANKA_BAKIYE  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_BANKA_BAKIYE_MODEL> _Propbanka_bakıyeListeSecilen;

        public ObservableCollection<TBL_BANKA_BAKIYE_MODEL> Propbanka_bakıyeListeSecilen
        {
            get { return _Propbanka_bakıyeListeSecilen; }
            set { _Propbanka_bakıyeListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propbanka_bakıyeListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_BANKA_BAKIYE_MODEL model1 = new TBL_BANKA_BAKIYE_MODEL();
              //  model1 = Propbanka_bakıyeSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_BANKA_BAKIYE_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_BANKA_BAKIYEMesaj>(new EkleTBL_BANKA_BAKIYEMesaj() { MesajTBL_BANKA_BAKIYE= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_BANKA_BAKIYEMesaj>(new EkleTBL_BANKA_BAKIYEMesaj() { MesajTBL_BANKA_BAKIYE= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_BANKA_BAKIYEMesaj>(new HataTBL_BANKA_BAKIYEMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_BANKA_BAKIYE_MODEL model1 = new TBL_BANKA_BAKIYE_MODEL();
                model1 = Propbanka_bakıyeSecilen;
                if (await serviceAgent.Sil__TBL_BANKA_BAKIYE_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_BANKA_BAKIYEMesaj>(new SilTBL_BANKA_BAKIYEMesaj() { MesajTBL_BANKA_BAKIYE= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_BANKA_BAKIYEMesaj>(new SilTBL_BANKA_BAKIYEMesaj() { MesajTBL_BANKA_BAKIYE= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_BANKA_BAKIYEMesaj>(new HataTBL_BANKA_BAKIYEMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_BANKA_BAKIYE_MODEL model1 = new TBL_BANKA_BAKIYE_MODEL();
                model1 = Propbanka_bakıyeSecilen;
            if (await serviceAgent.Degistir__TBL_BANKA_BAKIYE_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_BANKA_BAKIYEMesaj>(new DegistirTBL_BANKA_BAKIYEMesaj() { MesajTBL_BANKA_BAKIYE= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_BANKA_BAKIYEMesaj>(new DegistirTBL_BANKA_BAKIYEMesaj() { MesajTBL_BANKA_BAKIYE= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_BANKA_BAKIYEMesaj>(new HataTBL_BANKA_BAKIYEMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propbanka_bakıyeListe = await serviceAgent.Listele__TBL_BANKA_BAKIYE_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_BANKA_BAKIYEMesaj>(new HataTBL_BANKA_BAKIYEMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propbanka_bakıye = await serviceAgent.Bul_TBL_BANKA_BAKIYE_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_BANKA_BAKIYEMesaj>(new HataTBL_BANKA_BAKIYEMesaj() { Hatamesaji = ex.ToString()});


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
