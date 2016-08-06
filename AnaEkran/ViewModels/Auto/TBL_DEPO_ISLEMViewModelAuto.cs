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
	public partial class TBL_DEPO_ISLEMViewModel  : ViewModelDetailBase< TBL_DEPO_ISLEMViewModel,TBL_DEPO_ISLEM_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_DEPO_ISLEMViewModel () { }
TBL_DEPO_ISLEM_MODEL model=new TBL_DEPO_ISLEM_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_DEPO_ISLEMViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_DEPO_ISLEM  tablosu modeli
        /// </summary>
     
        private TBL_DEPO_ISLEM_MODEL _Propdepo_ıslem;

        public TBL_DEPO_ISLEM_MODEL Propdepo_ıslem
        {
            get { return _Propdepo_ıslem; }
            set { _Propdepo_ıslem = value;
                NotifyPropertyChanged(m=>m.Propdepo_ıslem);
                } 
        }
		 /// <summary>
        ///TBL_DEPO_ISLEM  tablosu Secilen
        /// </summary>
     
        private TBL_DEPO_ISLEM_MODEL _Propdepo_ıslemSecilen;

        public TBL_DEPO_ISLEM_MODEL Propdepo_ıslemSecilen
        {
            get { return _Propdepo_ıslemSecilen; }
            set { _Propdepo_ıslemSecilen = value;
                NotifyPropertyChanged(m=>m.Propdepo_ıslemSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_DEPO_ISLEM  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_DEPO_ISLEM_MODEL> _Propdepo_ıslemListe;

        public ObservableCollection<TBL_DEPO_ISLEM_MODEL> Propdepo_ıslemListe
        {
            get { return _Propdepo_ıslemListe; }
            set { _Propdepo_ıslemListe = value; 
                NotifyPropertyChanged(m=>m.Propdepo_ıslemListe);
                }
        }
         /// <summary>
        ///TBL_DEPO_ISLEM  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_DEPO_ISLEM_MODEL> _Propdepo_ıslemListeSecilen;

        public ObservableCollection<TBL_DEPO_ISLEM_MODEL> Propdepo_ıslemListeSecilen
        {
            get { return _Propdepo_ıslemListeSecilen; }
            set { _Propdepo_ıslemListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propdepo_ıslemListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_DEPO_ISLEM_MODEL model1 = new TBL_DEPO_ISLEM_MODEL();
              //  model1 = Propdepo_ıslemSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_DEPO_ISLEM_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_DEPO_ISLEMMesaj>(new EkleTBL_DEPO_ISLEMMesaj() { MesajTBL_DEPO_ISLEM= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_DEPO_ISLEMMesaj>(new EkleTBL_DEPO_ISLEMMesaj() { MesajTBL_DEPO_ISLEM= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_DEPO_ISLEMMesaj>(new HataTBL_DEPO_ISLEMMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_DEPO_ISLEM_MODEL model1 = new TBL_DEPO_ISLEM_MODEL();
                model1 = Propdepo_ıslemSecilen;
                if (await serviceAgent.Sil__TBL_DEPO_ISLEM_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_DEPO_ISLEMMesaj>(new SilTBL_DEPO_ISLEMMesaj() { MesajTBL_DEPO_ISLEM= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_DEPO_ISLEMMesaj>(new SilTBL_DEPO_ISLEMMesaj() { MesajTBL_DEPO_ISLEM= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_DEPO_ISLEMMesaj>(new HataTBL_DEPO_ISLEMMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_DEPO_ISLEM_MODEL model1 = new TBL_DEPO_ISLEM_MODEL();
                model1 = Propdepo_ıslemSecilen;
            if (await serviceAgent.Degistir__TBL_DEPO_ISLEM_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_DEPO_ISLEMMesaj>(new DegistirTBL_DEPO_ISLEMMesaj() { MesajTBL_DEPO_ISLEM= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_DEPO_ISLEMMesaj>(new DegistirTBL_DEPO_ISLEMMesaj() { MesajTBL_DEPO_ISLEM= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_DEPO_ISLEMMesaj>(new HataTBL_DEPO_ISLEMMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propdepo_ıslemListe = await serviceAgent.Listele__TBL_DEPO_ISLEM_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_DEPO_ISLEMMesaj>(new HataTBL_DEPO_ISLEMMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propdepo_ıslem = await serviceAgent.Bul_TBL_DEPO_ISLEM_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_DEPO_ISLEMMesaj>(new HataTBL_DEPO_ISLEMMesaj() { Hatamesaji = ex.ToString()});


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
