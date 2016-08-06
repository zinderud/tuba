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
	public partial class TBL_KASA_BAKIYEViewModel  : ViewModelDetailBase< TBL_KASA_BAKIYEViewModel,TBL_KASA_BAKIYE_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_KASA_BAKIYEViewModel () { }
TBL_KASA_BAKIYE_MODEL model=new TBL_KASA_BAKIYE_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_KASA_BAKIYEViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_KASA_BAKIYE  tablosu modeli
        /// </summary>
     
        private TBL_KASA_BAKIYE_MODEL _Propkasa_bakıye;

        public TBL_KASA_BAKIYE_MODEL Propkasa_bakıye
        {
            get { return _Propkasa_bakıye; }
            set { _Propkasa_bakıye = value;
                NotifyPropertyChanged(m=>m.Propkasa_bakıye);
                } 
        }
		 /// <summary>
        ///TBL_KASA_BAKIYE  tablosu Secilen
        /// </summary>
     
        private TBL_KASA_BAKIYE_MODEL _Propkasa_bakıyeSecilen;

        public TBL_KASA_BAKIYE_MODEL Propkasa_bakıyeSecilen
        {
            get { return _Propkasa_bakıyeSecilen; }
            set { _Propkasa_bakıyeSecilen = value;
                NotifyPropertyChanged(m=>m.Propkasa_bakıyeSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_KASA_BAKIYE  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_KASA_BAKIYE_MODEL> _Propkasa_bakıyeListe;

        public ObservableCollection<TBL_KASA_BAKIYE_MODEL> Propkasa_bakıyeListe
        {
            get { return _Propkasa_bakıyeListe; }
            set { _Propkasa_bakıyeListe = value; 
                NotifyPropertyChanged(m=>m.Propkasa_bakıyeListe);
                }
        }
         /// <summary>
        ///TBL_KASA_BAKIYE  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_KASA_BAKIYE_MODEL> _Propkasa_bakıyeListeSecilen;

        public ObservableCollection<TBL_KASA_BAKIYE_MODEL> Propkasa_bakıyeListeSecilen
        {
            get { return _Propkasa_bakıyeListeSecilen; }
            set { _Propkasa_bakıyeListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propkasa_bakıyeListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_KASA_BAKIYE_MODEL model1 = new TBL_KASA_BAKIYE_MODEL();
              //  model1 = Propkasa_bakıyeSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_KASA_BAKIYE_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_KASA_BAKIYEMesaj>(new EkleTBL_KASA_BAKIYEMesaj() { MesajTBL_KASA_BAKIYE= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_KASA_BAKIYEMesaj>(new EkleTBL_KASA_BAKIYEMesaj() { MesajTBL_KASA_BAKIYE= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_KASA_BAKIYEMesaj>(new HataTBL_KASA_BAKIYEMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_KASA_BAKIYE_MODEL model1 = new TBL_KASA_BAKIYE_MODEL();
                model1 = Propkasa_bakıyeSecilen;
                if (await serviceAgent.Sil__TBL_KASA_BAKIYE_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_KASA_BAKIYEMesaj>(new SilTBL_KASA_BAKIYEMesaj() { MesajTBL_KASA_BAKIYE= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_KASA_BAKIYEMesaj>(new SilTBL_KASA_BAKIYEMesaj() { MesajTBL_KASA_BAKIYE= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_KASA_BAKIYEMesaj>(new HataTBL_KASA_BAKIYEMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_KASA_BAKIYE_MODEL model1 = new TBL_KASA_BAKIYE_MODEL();
                model1 = Propkasa_bakıyeSecilen;
            if (await serviceAgent.Degistir__TBL_KASA_BAKIYE_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_KASA_BAKIYEMesaj>(new DegistirTBL_KASA_BAKIYEMesaj() { MesajTBL_KASA_BAKIYE= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_KASA_BAKIYEMesaj>(new DegistirTBL_KASA_BAKIYEMesaj() { MesajTBL_KASA_BAKIYE= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_KASA_BAKIYEMesaj>(new HataTBL_KASA_BAKIYEMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propkasa_bakıyeListe = await serviceAgent.Listele__TBL_KASA_BAKIYE_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_KASA_BAKIYEMesaj>(new HataTBL_KASA_BAKIYEMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propkasa_bakıye = await serviceAgent.Bul_TBL_KASA_BAKIYE_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_KASA_BAKIYEMesaj>(new HataTBL_KASA_BAKIYEMesaj() { Hatamesaji = ex.ToString()});


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
