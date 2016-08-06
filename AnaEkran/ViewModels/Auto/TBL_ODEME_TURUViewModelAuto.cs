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
	public partial class TBL_ODEME_TURUViewModel  : ViewModelDetailBase< TBL_ODEME_TURUViewModel,TBL_ODEME_TURU_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_ODEME_TURUViewModel () { }
TBL_ODEME_TURU_MODEL model=new TBL_ODEME_TURU_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_ODEME_TURUViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_ODEME_TURU  tablosu modeli
        /// </summary>
     
        private TBL_ODEME_TURU_MODEL _Propodeme_turu;

        public TBL_ODEME_TURU_MODEL Propodeme_turu
        {
            get { return _Propodeme_turu; }
            set { _Propodeme_turu = value;
                NotifyPropertyChanged(m=>m.Propodeme_turu);
                } 
        }
		 /// <summary>
        ///TBL_ODEME_TURU  tablosu Secilen
        /// </summary>
     
        private TBL_ODEME_TURU_MODEL _Propodeme_turuSecilen;

        public TBL_ODEME_TURU_MODEL Propodeme_turuSecilen
        {
            get { return _Propodeme_turuSecilen; }
            set { _Propodeme_turuSecilen = value;
                NotifyPropertyChanged(m=>m.Propodeme_turuSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_ODEME_TURU  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_ODEME_TURU_MODEL> _Propodeme_turuListe;

        public ObservableCollection<TBL_ODEME_TURU_MODEL> Propodeme_turuListe
        {
            get { return _Propodeme_turuListe; }
            set { _Propodeme_turuListe = value; 
                NotifyPropertyChanged(m=>m.Propodeme_turuListe);
                }
        }
         /// <summary>
        ///TBL_ODEME_TURU  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_ODEME_TURU_MODEL> _Propodeme_turuListeSecilen;

        public ObservableCollection<TBL_ODEME_TURU_MODEL> Propodeme_turuListeSecilen
        {
            get { return _Propodeme_turuListeSecilen; }
            set { _Propodeme_turuListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propodeme_turuListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_ODEME_TURU_MODEL model1 = new TBL_ODEME_TURU_MODEL();
              //  model1 = Propodeme_turuSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_ODEME_TURU_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_ODEME_TURUMesaj>(new EkleTBL_ODEME_TURUMesaj() { MesajTBL_ODEME_TURU= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_ODEME_TURUMesaj>(new EkleTBL_ODEME_TURUMesaj() { MesajTBL_ODEME_TURU= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_ODEME_TURUMesaj>(new HataTBL_ODEME_TURUMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_ODEME_TURU_MODEL model1 = new TBL_ODEME_TURU_MODEL();
                model1 = Propodeme_turuSecilen;
                if (await serviceAgent.Sil__TBL_ODEME_TURU_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_ODEME_TURUMesaj>(new SilTBL_ODEME_TURUMesaj() { MesajTBL_ODEME_TURU= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_ODEME_TURUMesaj>(new SilTBL_ODEME_TURUMesaj() { MesajTBL_ODEME_TURU= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_ODEME_TURUMesaj>(new HataTBL_ODEME_TURUMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_ODEME_TURU_MODEL model1 = new TBL_ODEME_TURU_MODEL();
                model1 = Propodeme_turuSecilen;
            if (await serviceAgent.Degistir__TBL_ODEME_TURU_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_ODEME_TURUMesaj>(new DegistirTBL_ODEME_TURUMesaj() { MesajTBL_ODEME_TURU= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_ODEME_TURUMesaj>(new DegistirTBL_ODEME_TURUMesaj() { MesajTBL_ODEME_TURU= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_ODEME_TURUMesaj>(new HataTBL_ODEME_TURUMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propodeme_turuListe = await serviceAgent.Listele__TBL_ODEME_TURU_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_ODEME_TURUMesaj>(new HataTBL_ODEME_TURUMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propodeme_turu = await serviceAgent.Bul_TBL_ODEME_TURU_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_ODEME_TURUMesaj>(new HataTBL_ODEME_TURUMesaj() { Hatamesaji = ex.ToString()});


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
