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
	public partial class TBL_SIRKET_BAKIYEViewModel  : ViewModelDetailBase< TBL_SIRKET_BAKIYEViewModel,TBL_SIRKET_BAKIYE_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_SIRKET_BAKIYEViewModel () { }
TBL_SIRKET_BAKIYE_MODEL model=new TBL_SIRKET_BAKIYE_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_SIRKET_BAKIYEViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_SIRKET_BAKIYE  tablosu modeli
        /// </summary>
     
        private TBL_SIRKET_BAKIYE_MODEL _Propsırket_bakıye;

        public TBL_SIRKET_BAKIYE_MODEL Propsırket_bakıye
        {
            get { return _Propsırket_bakıye; }
            set { _Propsırket_bakıye = value;
                NotifyPropertyChanged(m=>m.Propsırket_bakıye);
                } 
        }
		 /// <summary>
        ///TBL_SIRKET_BAKIYE  tablosu Secilen
        /// </summary>
     
        private TBL_SIRKET_BAKIYE_MODEL _Propsırket_bakıyeSecilen;

        public TBL_SIRKET_BAKIYE_MODEL Propsırket_bakıyeSecilen
        {
            get { return _Propsırket_bakıyeSecilen; }
            set { _Propsırket_bakıyeSecilen = value;
                NotifyPropertyChanged(m=>m.Propsırket_bakıyeSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_SIRKET_BAKIYE  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_SIRKET_BAKIYE_MODEL> _Propsırket_bakıyeListe;

        public ObservableCollection<TBL_SIRKET_BAKIYE_MODEL> Propsırket_bakıyeListe
        {
            get { return _Propsırket_bakıyeListe; }
            set { _Propsırket_bakıyeListe = value; 
                NotifyPropertyChanged(m=>m.Propsırket_bakıyeListe);
                }
        }
         /// <summary>
        ///TBL_SIRKET_BAKIYE  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_SIRKET_BAKIYE_MODEL> _Propsırket_bakıyeListeSecilen;

        public ObservableCollection<TBL_SIRKET_BAKIYE_MODEL> Propsırket_bakıyeListeSecilen
        {
            get { return _Propsırket_bakıyeListeSecilen; }
            set { _Propsırket_bakıyeListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propsırket_bakıyeListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_SIRKET_BAKIYE_MODEL model1 = new TBL_SIRKET_BAKIYE_MODEL();
              //  model1 = Propsırket_bakıyeSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_SIRKET_BAKIYE_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_SIRKET_BAKIYEMesaj>(new EkleTBL_SIRKET_BAKIYEMesaj() { MesajTBL_SIRKET_BAKIYE= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_SIRKET_BAKIYEMesaj>(new EkleTBL_SIRKET_BAKIYEMesaj() { MesajTBL_SIRKET_BAKIYE= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_SIRKET_BAKIYEMesaj>(new HataTBL_SIRKET_BAKIYEMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_SIRKET_BAKIYE_MODEL model1 = new TBL_SIRKET_BAKIYE_MODEL();
                model1 = Propsırket_bakıyeSecilen;
                if (await serviceAgent.Sil__TBL_SIRKET_BAKIYE_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_SIRKET_BAKIYEMesaj>(new SilTBL_SIRKET_BAKIYEMesaj() { MesajTBL_SIRKET_BAKIYE= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_SIRKET_BAKIYEMesaj>(new SilTBL_SIRKET_BAKIYEMesaj() { MesajTBL_SIRKET_BAKIYE= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_SIRKET_BAKIYEMesaj>(new HataTBL_SIRKET_BAKIYEMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_SIRKET_BAKIYE_MODEL model1 = new TBL_SIRKET_BAKIYE_MODEL();
                model1 = Propsırket_bakıyeSecilen;
            if (await serviceAgent.Degistir__TBL_SIRKET_BAKIYE_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_SIRKET_BAKIYEMesaj>(new DegistirTBL_SIRKET_BAKIYEMesaj() { MesajTBL_SIRKET_BAKIYE= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_SIRKET_BAKIYEMesaj>(new DegistirTBL_SIRKET_BAKIYEMesaj() { MesajTBL_SIRKET_BAKIYE= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_SIRKET_BAKIYEMesaj>(new HataTBL_SIRKET_BAKIYEMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propsırket_bakıyeListe = await serviceAgent.Listele__TBL_SIRKET_BAKIYE_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_SIRKET_BAKIYEMesaj>(new HataTBL_SIRKET_BAKIYEMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propsırket_bakıye = await serviceAgent.Bul_TBL_SIRKET_BAKIYE_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_SIRKET_BAKIYEMesaj>(new HataTBL_SIRKET_BAKIYEMesaj() { Hatamesaji = ex.ToString()});


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
