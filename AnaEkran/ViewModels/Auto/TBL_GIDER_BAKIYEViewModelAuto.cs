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
	public partial class TBL_GIDER_BAKIYEViewModel  : ViewModelDetailBase< TBL_GIDER_BAKIYEViewModel,TBL_GIDER_BAKIYE_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_GIDER_BAKIYEViewModel () { }
TBL_GIDER_BAKIYE_MODEL model=new TBL_GIDER_BAKIYE_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_GIDER_BAKIYEViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_GIDER_BAKIYE  tablosu modeli
        /// </summary>
     
        private TBL_GIDER_BAKIYE_MODEL _Propgıder_bakıye;

        public TBL_GIDER_BAKIYE_MODEL Propgıder_bakıye
        {
            get { return _Propgıder_bakıye; }
            set { _Propgıder_bakıye = value;
                NotifyPropertyChanged(m=>m.Propgıder_bakıye);
                } 
        }
		 /// <summary>
        ///TBL_GIDER_BAKIYE  tablosu Secilen
        /// </summary>
     
        private TBL_GIDER_BAKIYE_MODEL _Propgıder_bakıyeSecilen;

        public TBL_GIDER_BAKIYE_MODEL Propgıder_bakıyeSecilen
        {
            get { return _Propgıder_bakıyeSecilen; }
            set { _Propgıder_bakıyeSecilen = value;
                NotifyPropertyChanged(m=>m.Propgıder_bakıyeSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_GIDER_BAKIYE  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_GIDER_BAKIYE_MODEL> _Propgıder_bakıyeListe;

        public ObservableCollection<TBL_GIDER_BAKIYE_MODEL> Propgıder_bakıyeListe
        {
            get { return _Propgıder_bakıyeListe; }
            set { _Propgıder_bakıyeListe = value; 
                NotifyPropertyChanged(m=>m.Propgıder_bakıyeListe);
                }
        }
         /// <summary>
        ///TBL_GIDER_BAKIYE  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_GIDER_BAKIYE_MODEL> _Propgıder_bakıyeListeSecilen;

        public ObservableCollection<TBL_GIDER_BAKIYE_MODEL> Propgıder_bakıyeListeSecilen
        {
            get { return _Propgıder_bakıyeListeSecilen; }
            set { _Propgıder_bakıyeListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propgıder_bakıyeListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_GIDER_BAKIYE_MODEL model1 = new TBL_GIDER_BAKIYE_MODEL();
              //  model1 = Propgıder_bakıyeSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_GIDER_BAKIYE_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_GIDER_BAKIYEMesaj>(new EkleTBL_GIDER_BAKIYEMesaj() { MesajTBL_GIDER_BAKIYE= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_GIDER_BAKIYEMesaj>(new EkleTBL_GIDER_BAKIYEMesaj() { MesajTBL_GIDER_BAKIYE= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_GIDER_BAKIYEMesaj>(new HataTBL_GIDER_BAKIYEMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_GIDER_BAKIYE_MODEL model1 = new TBL_GIDER_BAKIYE_MODEL();
                model1 = Propgıder_bakıyeSecilen;
                if (await serviceAgent.Sil__TBL_GIDER_BAKIYE_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_GIDER_BAKIYEMesaj>(new SilTBL_GIDER_BAKIYEMesaj() { MesajTBL_GIDER_BAKIYE= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_GIDER_BAKIYEMesaj>(new SilTBL_GIDER_BAKIYEMesaj() { MesajTBL_GIDER_BAKIYE= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_GIDER_BAKIYEMesaj>(new HataTBL_GIDER_BAKIYEMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_GIDER_BAKIYE_MODEL model1 = new TBL_GIDER_BAKIYE_MODEL();
                model1 = Propgıder_bakıyeSecilen;
            if (await serviceAgent.Degistir__TBL_GIDER_BAKIYE_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_GIDER_BAKIYEMesaj>(new DegistirTBL_GIDER_BAKIYEMesaj() { MesajTBL_GIDER_BAKIYE= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_GIDER_BAKIYEMesaj>(new DegistirTBL_GIDER_BAKIYEMesaj() { MesajTBL_GIDER_BAKIYE= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_GIDER_BAKIYEMesaj>(new HataTBL_GIDER_BAKIYEMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propgıder_bakıyeListe = await serviceAgent.Listele__TBL_GIDER_BAKIYE_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_GIDER_BAKIYEMesaj>(new HataTBL_GIDER_BAKIYEMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propgıder_bakıye = await serviceAgent.Bul_TBL_GIDER_BAKIYE_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_GIDER_BAKIYEMesaj>(new HataTBL_GIDER_BAKIYEMesaj() { Hatamesaji = ex.ToString()});


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
